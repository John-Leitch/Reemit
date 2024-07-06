namespace Reemit.Decompiler.Clr.Disassembler;

public enum Opcode : byte
{
    [CilMnemonic("nop", false)]
    @nop = 0x00,
    [CilMnemonic("break", false)]
    @break = 0x01,
    [CilMnemonic("ldarg.0", false)]
    @ldarg_0 = 0x02,
    [CilMnemonic("ldarg.1", false)]
    @ldarg_1 = 0x03,
    [CilMnemonic("ldarg.2", false)]
    @ldarg_2 = 0x04,
    [CilMnemonic("ldarg.3", false)]
    @ldarg_3 = 0x05,
    [CilMnemonic("ldloc.0", false)]
    @ldloc_0 = 0x06,
    [CilMnemonic("ldloc.1", false)]
    @ldloc_1 = 0x07,
    [CilMnemonic("ldloc.2", false)]
    @ldloc_2 = 0x08,
    [CilMnemonic("ldloc.3", false)]
    @ldloc_3 = 0x09,
    [CilMnemonic("stloc.0", false)]
    @stloc_0 = 0x0A,
    [CilMnemonic("stloc.1", false)]
    @stloc_1 = 0x0B,
    [CilMnemonic("stloc.2", false)]
    @stloc_2 = 0x0C,
    [CilMnemonic("stloc.3", false)]
    @stloc_3 = 0x0D,
    [CilMnemonic("ldarg.s", false)]
    @ldarg_s = 0x0E,
    [CilMnemonic("ldarga.s", false)]
    @ldarga_s = 0x0F,
    [CilMnemonic("starg.s", false)]
    @starg_s = 0x10,
    [CilMnemonic("ldloc.s", false)]
    @ldloc_s = 0x11,
    [CilMnemonic("ldloca.s", false)]
    @ldloca_s = 0x12,
    [CilMnemonic("stloc.s", false)]
    @stloc_s = 0x13,
    [CilMnemonic("ldnull", false)]
    @ldnull = 0x14,
    [CilMnemonic("ldc.i4.m1", false)]
    @ldc_i4_m1 = 0x15,
    [CilMnemonic("ldc.i4.0", false)]
    @ldc_i4_0 = 0x16,
    [CilMnemonic("ldc.i4.1", false)]
    @ldc_i4_1 = 0x17,
    [CilMnemonic("ldc.i4.2", false)]
    @ldc_i4_2 = 0x18,
    [CilMnemonic("ldc.i4.3", false)]
    @ldc_i4_3 = 0x19,
    [CilMnemonic("ldc.i4.4", false)]
    @ldc_i4_4 = 0x1A,
    [CilMnemonic("ldc.i4.5", false)]
    @ldc_i4_5 = 0x1B,
    [CilMnemonic("ldc.i4.6", false)]
    @ldc_i4_6 = 0x1C,
    [CilMnemonic("ldc.i4.7", false)]
    @ldc_i4_7 = 0x1D,
    [CilMnemonic("ldc.i4.8", false)]
    @ldc_i4_8 = 0x1E,
    [CilMnemonic("ldc.i4.s", false)]
    @ldc_i4_s = 0x1F,
    [CilMnemonic("ldc.i4", false)]
    @ldc_i4 = 0x20,
    [CilMnemonic("ldc.i8", false)]
    @ldc_i8 = 0x21,
    [CilMnemonic("ldc.r4", false)]
    @ldc_r4 = 0x22,
    [CilMnemonic("ldc.r8", false)]
    @ldc_r8 = 0x23,
    [CilMnemonic("dup", false)]
    @dup = 0x25,
    [CilMnemonic("pop", false)]
    @pop = 0x26,
    [CilMnemonic("jmp", false)]
    @jmp = 0x27,
    [CilMnemonic("call", false)]
    @call = 0x28,
    [CilMnemonic("calli", false)]
    @calli = 0x29,
    [CilMnemonic("ret", false)]
    @ret = 0x2A,
    [CilMnemonic("br.s", false)]
    @br_s = 0x2B,
    [CilMnemonic("brfalse.s", false)]
    @brfalse_s = 0x2C,
    [CilMnemonic("brtrue.s", false)]
    @brtrue_s = 0x2D,
    [CilMnemonic("beq.s", false)]
    @beq_s = 0x2E,
    [CilMnemonic("bge.s", false)]
    @bge_s = 0x2F,
    [CilMnemonic("bgt.s", false)]
    @bgt_s = 0x30,
    [CilMnemonic("ble.s", false)]
    @ble_s = 0x31,
    [CilMnemonic("blt.s", false)]
    @blt_s = 0x32,
    [CilMnemonic("bne.un.s", false)]
    @bne_un_s = 0x33,
    [CilMnemonic("bge.un.s", false)]
    @bge_un_s = 0x34,
    [CilMnemonic("bgt.un.s", false)]
    @bgt_un_s = 0x35,
    [CilMnemonic("ble.un.s", false)]
    @ble_un_s = 0x36,
    [CilMnemonic("blt.un.s", false)]
    @blt_un_s = 0x37,
    [CilMnemonic("br", false)]
    @br = 0x38,
    [CilMnemonic("brfalse", false)]
    @brfalse = 0x39,
    [CilMnemonic("brtrue", false)]
    @brtrue = 0x3A,
    [CilMnemonic("beq", false)]
    @beq = 0x3B,
    [CilMnemonic("bge", false)]
    @bge = 0x3C,
    [CilMnemonic("bgt", false)]
    @bgt = 0x3D,
    [CilMnemonic("ble", false)]
    @ble = 0x3E,
    [CilMnemonic("blt", false)]
    @blt = 0x3F,
    [CilMnemonic("bne.un", false)]
    @bne_un = 0x40,
    [CilMnemonic("bge.un", false)]
    @bge_un = 0x41,
    [CilMnemonic("bgt.un", false)]
    @bgt_un = 0x42,
    [CilMnemonic("ble.un", false)]
    @ble_un = 0x43,
    [CilMnemonic("blt.un", false)]
    @blt_un = 0x44,
    [CilMnemonic("switch", false)]
    @switch = 0x45,
    [CilMnemonic("ldind.i1", false)]
    @ldind_i1 = 0x46,
    [CilMnemonic("ldind.u1", false)]
    @ldind_u1 = 0x47,
    [CilMnemonic("ldind.i2", false)]
    @ldind_i2 = 0x48,
    [CilMnemonic("ldind.u2", false)]
    @ldind_u2 = 0x49,
    [CilMnemonic("ldind.i4", false)]
    @ldind_i4 = 0x4A,
    [CilMnemonic("ldind.u4", false)]
    @ldind_u4 = 0x4B,
    [CilMnemonic("ldind.i8", false)]
    @ldind_i8 = 0x4C,
    [CilMnemonic("ldind.i", false)]
    @ldind_i = 0x4D,
    [CilMnemonic("ldind.r4", false)]
    @ldind_r4 = 0x4E,
    [CilMnemonic("ldind.r8", false)]
    @ldind_r8 = 0x4F,
    [CilMnemonic("ldind.ref", false)]
    @ldind_ref = 0x50,
    [CilMnemonic("stind.ref", false)]
    @stind_ref = 0x51,
    [CilMnemonic("stind.i1", false)]
    @stind_i1 = 0x52,
    [CilMnemonic("stind.i2", false)]
    @stind_i2 = 0x53,
    [CilMnemonic("stind.i4", false)]
    @stind_i4 = 0x54,
    [CilMnemonic("stind.i8", false)]
    @stind_i8 = 0x55,
    [CilMnemonic("stind.r4", false)]
    @stind_r4 = 0x56,
    [CilMnemonic("stind.r8", false)]
    @stind_r8 = 0x57,
    [CilMnemonic("add", false)]
    @add = 0x58,
    [CilMnemonic("sub", false)]
    @sub = 0x59,
    [CilMnemonic("mul", false)]
    @mul = 0x5A,
    [CilMnemonic("div", false)]
    @div = 0x5B,
    [CilMnemonic("div.un", false)]
    @div_un = 0x5C,
    [CilMnemonic("rem", false)]
    @rem = 0x5D,
    [CilMnemonic("rem.un", false)]
    @rem_un = 0x5E,
    [CilMnemonic("and", false)]
    @and = 0x5F,
    [CilMnemonic("or", false)]
    @or = 0x60,
    [CilMnemonic("xor", false)]
    @xor = 0x61,
    [CilMnemonic("shl", false)]
    @shl = 0x62,
    [CilMnemonic("shr", false)]
    @shr = 0x63,
    [CilMnemonic("shr.un", false)]
    @shr_un = 0x64,
    [CilMnemonic("neg", false)]
    @neg = 0x65,
    [CilMnemonic("not", false)]
    @not = 0x66,
    [CilMnemonic("conv.i1", false)]
    @conv_i1 = 0x67,
    [CilMnemonic("conv.i2", false)]
    @conv_i2 = 0x68,
    [CilMnemonic("conv.i4", false)]
    @conv_i4 = 0x69,
    [CilMnemonic("conv.i8", false)]
    @conv_i8 = 0x6A,
    [CilMnemonic("conv.r4", false)]
    @conv_r4 = 0x6B,
    [CilMnemonic("conv.r8", false)]
    @conv_r8 = 0x6C,
    [CilMnemonic("conv.u4", false)]
    @conv_u4 = 0x6D,
    [CilMnemonic("conv.u8", false)]
    @conv_u8 = 0x6E,
    [CilMnemonic("callvirt", false)]
    @callvirt = 0x6F,
    [CilMnemonic("cpobj", false)]
    @cpobj = 0x70,
    [CilMnemonic("ldobj", false)]
    @ldobj = 0x71,
    [CilMnemonic("ldstr", false)]
    @ldstr = 0x72,
    [CilMnemonic("newobj", false)]
    @newobj = 0x73,
    [CilMnemonic("castclass", false)]
    @castclass = 0x74,
    [CilMnemonic("isinst", false)]
    @isinst = 0x75,
    [CilMnemonic("conv.r.un", false)]
    @conv_r_un = 0x76,
    [CilMnemonic("unbox", false)]
    @unbox = 0x79,
    [CilMnemonic("throw", false)]
    @throw = 0x7A,
    [CilMnemonic("ldfld", false)]
    @ldfld = 0x7B,
    [CilMnemonic("ldflda", false)]
    @ldflda = 0x7C,
    [CilMnemonic("stfld", false)]
    @stfld = 0x7D,
    [CilMnemonic("ldsfld", false)]
    @ldsfld = 0x7E,
    [CilMnemonic("ldsflda", false)]
    @ldsflda = 0x7F,
    [CilMnemonic("stsfld", false)]
    @stsfld = 0x80,
    [CilMnemonic("stobj", false)]
    @stobj = 0x81,
    [CilMnemonic("conv.ovf.i1.un", false)]
    @conv_ovf_i1_un = 0x82,
    [CilMnemonic("conv.ovf.i2.un", false)]
    @conv_ovf_i2_un = 0x83,
    [CilMnemonic("conv.ovf.i4.un", false)]
    @conv_ovf_i4_un = 0x84,
    [CilMnemonic("conv.ovf.i8.un", false)]
    @conv_ovf_i8_un = 0x85,
    [CilMnemonic("conv.ovf.u1.un", false)]
    @conv_ovf_u1_un = 0x86,
    [CilMnemonic("conv.ovf.u2.un", false)]
    @conv_ovf_u2_un = 0x87,
    [CilMnemonic("conv.ovf.u4.un", false)]
    @conv_ovf_u4_un = 0x88,
    [CilMnemonic("conv.ovf.u8.un", false)]
    @conv_ovf_u8_un = 0x89,
    [CilMnemonic("conv.ovf.i.un", false)]
    @conv_ovf_i_un = 0x8A,
    [CilMnemonic("conv.ovf.u.un", false)]
    @conv_ovf_u_un = 0x8B,
    [CilMnemonic("box", false)]
    @box = 0x8C,
    [CilMnemonic("newarr", false)]
    @newarr = 0x8D,
    [CilMnemonic("ldlen", false)]
    @ldlen = 0x8E,
    [CilMnemonic("ldelema", false)]
    @ldelema = 0x8F,
    [CilMnemonic("ldelem.i1", false)]
    @ldelem_i1 = 0x90,
    [CilMnemonic("ldelem.u1", false)]
    @ldelem_u1 = 0x91,
    [CilMnemonic("ldelem.i2", false)]
    @ldelem_i2 = 0x92,
    [CilMnemonic("ldelem.u2", false)]
    @ldelem_u2 = 0x93,
    [CilMnemonic("ldelem.i4", false)]
    @ldelem_i4 = 0x94,
    [CilMnemonic("ldelem.u4", false)]
    @ldelem_u4 = 0x95,
    [CilMnemonic("ldelem.i8", false)]
    @ldelem_i8 = 0x96,
    [CilMnemonic("ldelem.i", false)]
    @ldelem_i = 0x97,
    [CilMnemonic("ldelem.r4", false)]
    @ldelem_r4 = 0x98,
    [CilMnemonic("ldelem.r8", false)]
    @ldelem_r8 = 0x99,
    [CilMnemonic("ldelem.ref", false)]
    @ldelem_ref = 0x9A,
    [CilMnemonic("stelem.i", false)]
    @stelem_i = 0x9B,
    [CilMnemonic("stelem.i1", false)]
    @stelem_i1 = 0x9C,
    [CilMnemonic("stelem.i2", false)]
    @stelem_i2 = 0x9D,
    [CilMnemonic("stelem.i4", false)]
    @stelem_i4 = 0x9E,
    [CilMnemonic("stelem.i8", false)]
    @stelem_i8 = 0x9F,
    [CilMnemonic("stelem.r4", false)]
    @stelem_r4 = 0xA0,
    [CilMnemonic("stelem.r8", false)]
    @stelem_r8 = 0xA1,
    [CilMnemonic("stelem.ref", false)]
    @stelem_ref = 0xA2,
    [CilMnemonic("ldelem", false)]
    @ldelem = 0xA3,
    [CilMnemonic("stelem", false)]
    @stelem = 0xA4,
    [CilMnemonic("unbox.any", false)]
    @unbox_any = 0xA5,
    [CilMnemonic("conv.ovf.i1", false)]
    @conv_ovf_i1 = 0xB3,
    [CilMnemonic("conv.ovf.u1", false)]
    @conv_ovf_u1 = 0xB4,
    [CilMnemonic("conv.ovf.i2", false)]
    @conv_ovf_i2 = 0xB5,
    [CilMnemonic("conv.ovf.u2", false)]
    @conv_ovf_u2 = 0xB6,
    [CilMnemonic("conv.ovf.i4", false)]
    @conv_ovf_i4 = 0xB7,
    [CilMnemonic("conv.ovf.u4", false)]
    @conv_ovf_u4 = 0xB8,
    [CilMnemonic("conv.ovf.i8", false)]
    @conv_ovf_i8 = 0xB9,
    [CilMnemonic("conv.ovf.u8", false)]
    @conv_ovf_u8 = 0xBA,
    [CilMnemonic("refanyval", false)]
    @refanyval = 0xC2,
    [CilMnemonic("ckfinite", false)]
    @ckfinite = 0xC3,
    [CilMnemonic("mkrefany", false)]
    @mkrefany = 0xC6,
    [CilMnemonic("ldtoken", false)]
    @ldtoken = 0xD0,
    [CilMnemonic("conv.u2", false)]
    @conv_u2 = 0xD1,
    [CilMnemonic("conv.u1", false)]
    @conv_u1 = 0xD2,
    [CilMnemonic("conv.i", false)]
    @conv_i = 0xD3,
    [CilMnemonic("conv.ovf.i", false)]
    @conv_ovf_i = 0xD4,
    [CilMnemonic("conv.ovf.u", false)]
    @conv_ovf_u = 0xD5,
    [CilMnemonic("add.ovf", false)]
    @add_ovf = 0xD6,
    [CilMnemonic("add.ovf.un", false)]
    @add_ovf_un = 0xD7,
    [CilMnemonic("mul.ovf", false)]
    @mul_ovf = 0xD8,
    [CilMnemonic("mul.ovf.un", false)]
    @mul_ovf_un = 0xD9,
    [CilMnemonic("sub.ovf", false)]
    @sub_ovf = 0xDA,
    [CilMnemonic("sub.ovf.un", false)]
    @sub_ovf_un = 0xDB,
    [CilMnemonic("endfinally", false)]
    @endfinally = 0xDC,
    [CilMnemonic("leave", false)]
    @leave = 0xDD,
    [CilMnemonic("leave.s", false)]
    @leave_s = 0xDE,
    [CilMnemonic("stind.i", false)]
    @stind_i = 0xDF,
    [CilMnemonic("conv.u", false)]
    @conv_u = 0xE0,
    Extended = 0xFE,
}

