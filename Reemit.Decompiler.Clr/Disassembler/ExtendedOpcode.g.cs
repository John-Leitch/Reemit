namespace Reemit.Decompiler.Clr.Disassembler;

public enum ExtendedOpcode : byte
{
    [CilMnemonic("arglist", true)]
    @arglist = 0x00,
    [CilMnemonic("ceq", true)]
    @ceq = 0x01,
    [CilMnemonic("cgt", true)]
    @cgt = 0x02,
    [CilMnemonic("cgt.un", true)]
    @cgt_un = 0x03,
    [CilMnemonic("clt", true)]
    @clt = 0x04,
    [CilMnemonic("clt.un", true)]
    @clt_un = 0x05,
    [CilMnemonic("ldftn", true)]
    @ldftn = 0x06,
    [CilMnemonic("ldvirtftn", true)]
    @ldvirtftn = 0x07,
    [CilMnemonic("ldarg", true)]
    @ldarg = 0x09,
    [CilMnemonic("ldarga", true)]
    @ldarga = 0x0A,
    [CilMnemonic("starg", true)]
    @starg = 0x0B,
    [CilMnemonic("ldloc", true)]
    @ldloc = 0x0C,
    [CilMnemonic("ldloca", true)]
    @ldloca = 0x0D,
    [CilMnemonic("stloc", true)]
    @stloc = 0x0E,
    [CilMnemonic("localloc", true)]
    @localloc = 0x0F,
    [CilMnemonic("endfilter", true)]
    @endfilter = 0x11,
    [CilMnemonic("unaligned.", true)]
    @unaligned = 0x12,
    [CilMnemonic("volatile.", true)]
    @volatile = 0x13,
    [CilMnemonic("tail.", true)]
    @tail = 0x14,
    [CilMnemonic("Initobj", true)]
    @Initobj = 0x15,
    [CilMnemonic("constrained.", true)]
    @constrained = 0x16,
    [CilMnemonic("cpblk", true)]
    @cpblk = 0x17,
    [CilMnemonic("initblk", true)]
    @initblk = 0x18,
    [CilMnemonic("no.", true)]
    @no = 0x19,
    [CilMnemonic("rethrow", true)]
    @rethrow = 0x1A,
    [CilMnemonic("sizeof", true)]
    @sizeof = 0x1C,
    [CilMnemonic("Refanytype", true)]
    @Refanytype = 0x1D,
    [CilMnemonic("readonly.", true)]
    @readonly = 0x1E,
}

