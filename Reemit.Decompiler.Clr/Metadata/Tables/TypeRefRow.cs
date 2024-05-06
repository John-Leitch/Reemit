namespace Reemit.Decompiler.Cli.Metadata.Tables;

public class TypeRefRow : IMetadataTableRow
{
    public CodedIndex ResolutionScope { get; private set; } = null!;
    public uint TypeName { get; private set; }
    public uint TypeNamespace { get; private set; }

    public void Read(MetadataTableDataReader reader)
    {
        ResolutionScope = reader.ReadCodedRid(CodedIndexTagFamily.ResolutionScope);
        TypeName = reader.ReadStringRid();
        TypeNamespace = reader.ReadStringRid();
    }
}