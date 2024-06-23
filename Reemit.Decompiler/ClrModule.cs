﻿using Reemit.Common;
using Reemit.Decompiler.Clr.Metadata;
using Reemit.Decompiler.Clr.Metadata.Streams;
using Reemit.Decompiler.PE;
using System.Collections.Immutable;
using System.Diagnostics;

namespace Reemit.Decompiler;

public class ClrModule
{
    public RangeMapped<string> Name { get; }
    public IReadOnlyList<ClrType> Types { get; }
    public IReadOnlyList<ClrNamespace> Namespaces { get; }
    public IReadOnlyCollection<byte> Bytes { get; }

    private ClrModule(RangeMapped<string> name, IReadOnlyList<ClrType>? types, ImmutableArray<byte> bytes)
    {
        Name = name;
        Types = types ?? [];
        Namespaces = Types
            .GroupBy(t => t.Namespace)
            .Select(g => new ClrNamespace(g.Key, g.ToArray().AsReadOnly()))
            .ToArray()
            .AsReadOnly();
        Bytes = bytes;
    }

    public static ClrModule Open(string fileName)
    {
        var fileStream = new FileStream(fileName, FileMode.Open);
        var bytes = new byte[fileStream.Length];
        var len = fileStream.Read(bytes, 0, bytes.Length);
        Debug.Assert(len == bytes.Length);
        fileStream.Seek(0, SeekOrigin.Begin);
        var peFile = new PEFile(new BinaryReader(fileStream));

        const int clrHeaderDirIndex = 14;

        if (peFile.DataDirectories.Count - 1 < clrHeaderDirIndex)
        {
            throw new BadImageFormatException("This image does not have a CLR header");
        }

        var clrRuntimeHeaderDir = peFile.DataDirectories[clrHeaderDirIndex];
        var clrRuntimeHeader = peFile.GetStructureDescribedByDataDirectory<CliHeader>(clrRuntimeHeaderDir);

        var metadataOffset = peFile.GetFileOffset(clrRuntimeHeader.Metadata.VirtualAddress);
        var metadataReader = peFile.CreateReaderAt(metadataOffset);
        var metadata = new MetadataRoot(metadataReader);

        var stringsStreamHeader = metadata.StreamHeaders.Single(x => x.Name == StringsHeapStream.Name);
        var stringsStreamOffset = metadataOffset + stringsStreamHeader.Offset;
        var stringsStream = new StringsHeapStream(peFile.CreateReaderAt(stringsStreamOffset), stringsStreamHeader);

        var metadataStreamHeader = metadata.StreamHeaders.Single(x => x.Name == MetadataTablesStream.Name);
        var metadataStreamOffset = metadataOffset + metadataStreamHeader.Offset;
        var metadataStream = new MetadataTablesStream(peFile.CreateReaderAt(metadataStreamOffset));

        var context = new ClrMetadataContext(metadataStream, stringsStream);

        var types = metadataStream.TypeDef?.Rows.Select(x => ClrType.FromTypeDefRow(x, context)).ToArray().AsReadOnly();

        var name = stringsStream.ReadMapped(metadataStream.Module.Rows[0].Name);

        return new ClrModule(name, types, bytes.ToImmutableArray());
    }
}