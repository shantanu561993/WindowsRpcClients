//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\webplatstorageserver.dll
// Interface ID: 46f91c6b-1f95-4bff-8490-eb648ca0a9b9
// Interface Version: 1.0



namespace rpc_46f91c6b_1f95_4bff_8490_eb648ca0a9b9_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_0 p0)
        {
            WriteStruct<Struct_0>(p0);
        }
        public void Write_1(Struct_2 p0)
        {
            WriteStruct<Struct_2>(p0);
        }
        public void Write_2(Struct_3 p0)
        {
            WriteStruct<Struct_3>(p0);
        }
        public void Write_3(Struct_4 p0)
        {
            WriteStruct<Struct_4>(p0);
        }
        public void Write_4(Struct_5 p0)
        {
            WriteStruct<Struct_5>(p0);
        }
        public void Write_5(Struct_6 p0)
        {
            WriteStruct<Struct_6>(p0);
        }
        public void Write_6(Struct_7 p0)
        {
            WriteStruct<Struct_7>(p0);
        }
        public void Write_7(Struct_8 p0)
        {
            WriteStruct<Struct_8>(p0);
        }
        public void Write_8(Struct_9 p0)
        {
            WriteStruct<Struct_9>(p0);
        }
        public void Write_9(Struct_10 p0)
        {
            WriteStruct<Struct_10>(p0);
        }
        public void Write_10(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_11(char[] p0, long p1)
        {
            WriteConformantArray<char>(p0, p1);
        }
        public void Write_12(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_13(byte[] p0)
        {
            WriteFixedByteArray(p0, 65);
        }
        public void Write_14(byte[] p0)
        {
            WriteFixedByteArray(p0, 32);
        }
        public void Write_15(byte[] p0)
        {
            WriteFixedByteArray(p0, 16);
        }
        public void Write_16(Struct_0[] p0, long p1)
        {
            WriteConformantStructArray<Struct_0>(p0, p1);
        }
        public void Write_17(Struct_3[] p0, long p1)
        {
            WriteConformantStructArray<Struct_3>(p0, p1);
        }
        public void Write_18(Struct_3[] p0, long p1)
        {
            WriteConformantStructArray<Struct_3>(p0, p1);
        }
    }
    internal class _Unmarshal_Helper : NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer
    {
        public _Unmarshal_Helper(NtApiDotNet.Win32.Rpc.RpcClientResponse r) : 
                base(r.NdrBuffer, r.Handles, r.DataRepresentation)
        {
        }
        public _Unmarshal_Helper(byte[] ba) : 
                base(ba)
        {
        }
        public Struct_0 Read_0()
        {
            return ReadStruct<Struct_0>();
        }
        public Struct_2 Read_1()
        {
            return ReadStruct<Struct_2>();
        }
        public Struct_3 Read_2()
        {
            return ReadStruct<Struct_3>();
        }
        public Struct_4 Read_3()
        {
            return ReadStruct<Struct_4>();
        }
        public Struct_5 Read_4()
        {
            return ReadStruct<Struct_5>();
        }
        public Struct_6 Read_5()
        {
            return ReadStruct<Struct_6>();
        }
        public Struct_7 Read_6()
        {
            return ReadStruct<Struct_7>();
        }
        public Struct_8 Read_7()
        {
            return ReadStruct<Struct_8>();
        }
        public Struct_9 Read_8()
        {
            return ReadStruct<Struct_9>();
        }
        public Struct_10 Read_9()
        {
            return ReadStruct<Struct_10>();
        }
        public byte[] Read_10()
        {
            return ReadConformantArray<byte>();
        }
        public char[] Read_11()
        {
            return ReadConformantArray<char>();
        }
        public byte[] Read_12()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_13()
        {
            return ReadFixedByteArray(65);
        }
        public byte[] Read_14()
        {
            return ReadFixedByteArray(32);
        }
        public byte[] Read_15()
        {
            return ReadFixedByteArray(16);
        }
        public Struct_0[] Read_16()
        {
            return ReadConformantStructArray<Struct_0>();
        }
        public Struct_3[] Read_17()
        {
            return ReadConformantStructArray<Struct_3>();
        }
        public Struct_3[] Read_18()
        {
            return ReadConformantStructArray<Struct_3>();
        }
    }
    #endregion
    #region Complex Types
    public struct Struct_0 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteByte(Member0);
            m.WriteInt32(Member4);
            m.WriteInt32(Member8);
            m.WriteGuid(MemberC);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadByte();
            Member4 = u.ReadInt32();
            Member8 = u.ReadInt32();
            MemberC = u.ReadGuid();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public byte Member0;
        public int Member4;
        public int Member8;
        public System.Guid MemberC;
        public static Struct_0 CreateDefault()
        {
            return new Struct_0();
        }
        public Struct_0(byte Member0, int Member4, int Member8, System.Guid MemberC)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
            this.MemberC = MemberC;
        }
    }
    public struct Struct_2 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
            m.WriteEmbeddedPointer<byte[], long>(Member8, new System.Action<byte[], long>(m.Write_10), Member4);
            m.WriteInt32(Member10);
            m.WriteEmbeddedPointer<char[], long>(Member18, new System.Action<char[], long>(m.Write_11), Member10);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
            Member8 = u.ReadEmbeddedPointer<byte[]>(new System.Func<byte[]>(u.Read_10), false);
            Member10 = u.ReadInt32();
            Member18 = u.ReadEmbeddedPointer<char[]>(new System.Func<char[]>(u.Read_11), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<byte[]> Member8;
        public int Member10;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<char[]> Member18;
        public static Struct_2 CreateDefault()
        {
            Struct_2 ret = new Struct_2();
            ret.Member8 = new byte[0];
            return ret;
        }
        public Struct_2(int Member0, int Member4, byte[] Member8, int Member10, char[] Member18)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
            this.Member10 = Member10;
            this.Member18 = Member18;
        }
    }
    public struct Struct_3 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteGuid(Member0);
            m.WriteInt32(Member10);
            m.WriteEmbeddedPointer<string>(Member18, new System.Action<string>(m.WriteTerminatedString));
            m.WriteInt64(Member20);
            m.WriteByte(Member28);
            m.WriteInt64(Member30);
            m.WriteInt32(Member38);
            m.WriteEmbeddedPointer<Struct_4>(Member40, new System.Action<Struct_4>(m.Write_3));
            m.WriteEmbeddedPointer<Struct_4>(Member48, new System.Action<Struct_4>(m.Write_3));
            m.WriteEmbeddedPointer<Struct_4>(Member50, new System.Action<Struct_4>(m.Write_3));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadGuid();
            Member10 = u.ReadInt32();
            Member18 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member20 = u.ReadInt64();
            Member28 = u.ReadByte();
            Member30 = u.ReadInt64();
            Member38 = u.ReadInt32();
            Member40 = u.ReadEmbeddedPointer<Struct_4>(new System.Func<Struct_4>(u.Read_3), false);
            Member48 = u.ReadEmbeddedPointer<Struct_4>(new System.Func<Struct_4>(u.Read_3), false);
            Member50 = u.ReadEmbeddedPointer<Struct_4>(new System.Func<Struct_4>(u.Read_3), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public System.Guid Member0;
        public int Member10;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member18;
        public long Member20;
        public byte Member28;
        public long Member30;
        public int Member38;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_4> Member40;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_4> Member48;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_4> Member50;
        public static Struct_3 CreateDefault()
        {
            return new Struct_3();
        }
        public Struct_3(System.Guid Member0, int Member10, string Member18, long Member20, byte Member28, long Member30, int Member38, System.Nullable<Struct_4> Member40, System.Nullable<Struct_4> Member48, System.Nullable<Struct_4> Member50)
        {
            this.Member0 = Member0;
            this.Member10 = Member10;
            this.Member18 = Member18;
            this.Member20 = Member20;
            this.Member28 = Member28;
            this.Member30 = Member30;
            this.Member38 = Member38;
            this.Member40 = Member40;
            this.Member48 = Member48;
            this.Member50 = Member50;
        }
    }
    public struct Struct_4 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteGuid(Member0);
            m.WriteEmbeddedPointer<string>(Member10, new System.Action<string>(m.WriteTerminatedString));
            m.WriteByte(Member18);
            m.WriteByte(Member19);
            m.WriteSByte(Member1A);
            m.WriteInt32(Member1C);
            m.WriteInt64(Member20);
            m.WriteInt32(Member28);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadGuid();
            Member10 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member18 = u.ReadByte();
            Member19 = u.ReadByte();
            Member1A = u.ReadSByte();
            Member1C = u.ReadInt32();
            Member20 = u.ReadInt64();
            Member28 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public System.Guid Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member10;
        public byte Member18;
        public byte Member19;
        public sbyte Member1A;
        public int Member1C;
        public long Member20;
        public int Member28;
        public static Struct_4 CreateDefault()
        {
            return new Struct_4();
        }
        public Struct_4(System.Guid Member0, string Member10, byte Member18, byte Member19, sbyte Member1A, int Member1C, long Member20, int Member28)
        {
            this.Member0 = Member0;
            this.Member10 = Member10;
            this.Member18 = Member18;
            this.Member19 = Member19;
            this.Member1A = Member1A;
            this.Member1C = Member1C;
            this.Member20 = Member20;
            this.Member28 = Member28;
        }
    }
    public struct Struct_5 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteSByte(Member0);
            m.Write_5(Member8);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadSByte();
            Member8 = u.Read_5();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public sbyte Member0;
        public Struct_6 Member8;
        public static Struct_5 CreateDefault()
        {
            return new Struct_5();
        }
        public Struct_5(sbyte Member0, Struct_6 Member8)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
        }
    }
    public struct Struct_6 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteEmbeddedPointer<byte[], long>(Member8, new System.Action<byte[], long>(m.Write_12), Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member8 = u.ReadEmbeddedPointer<byte[]>(new System.Func<byte[]>(u.Read_12), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<byte[]> Member8;
        public static Struct_6 CreateDefault()
        {
            return new Struct_6();
        }
        public Struct_6(int Member0, byte[] Member8)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
        }
    }
    public struct Struct_7 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.Write_7(Member4);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.Read_7();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public Struct_8 Member4;
        public static Struct_7 CreateDefault()
        {
            return new Struct_7();
        }
        public Struct_7(int Member0, Struct_8 Member4)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
        }
    }
    public struct Struct_8 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteInt16(Member4);
            m.WriteInt16(Member6);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt16();
            Member6 = u.ReadInt16();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public short Member4;
        public short Member6;
        public static Struct_8 CreateDefault()
        {
            return new Struct_8();
        }
        public Struct_8(int Member0, short Member4, short Member6)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member6 = Member6;
        }
    }
    public struct Struct_9 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteGuid(Member0);
            m.WriteInt64(Member10);
            m.WriteEmbeddedPointer<string>(Member18, new System.Action<string>(m.WriteTerminatedString));
            m.Write_13(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member20, "Member20"));
            m.Write_14(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member61, "Member61"));
            m.Write_15(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member81, "Member81"));
            m.Write_9(Member91);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadGuid();
            Member10 = u.ReadInt64();
            Member18 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member20 = u.Read_13();
            Member61 = u.Read_14();
            Member81 = u.Read_15();
            Member91 = u.Read_9();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public System.Guid Member0;
        public long Member10;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member18;
        public byte[] Member20;
        public byte[] Member61;
        public byte[] Member81;
        public Struct_10 Member91;
        public static Struct_9 CreateDefault()
        {
            Struct_9 ret = new Struct_9();
            ret.Member20 = new byte[65];
            ret.Member61 = new byte[32];
            ret.Member81 = new byte[16];
            return ret;
        }
        public Struct_9(System.Guid Member0, long Member10, string Member18, byte[] Member20, byte[] Member61, byte[] Member81, Struct_10 Member91)
        {
            this.Member0 = Member0;
            this.Member10 = Member10;
            this.Member18 = Member18;
            this.Member20 = Member20;
            this.Member61 = Member61;
            this.Member81 = Member81;
            this.Member91 = Member91;
        }
    }
    public struct Struct_10 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteSByte(Member0);
            m.Write_13(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member1, "Member1"));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadSByte();
            Member1 = u.Read_13();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 1;
        }
        public sbyte Member0;
        public byte[] Member1;
        public static Struct_10 CreateDefault()
        {
            Struct_10 ret = new Struct_10();
            ret.Member1 = new byte[65];
            return ret;
        }
        public Struct_10(sbyte Member0, byte[] Member1)
        {
            this.Member0 = Member0;
            this.Member1 = Member1;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("46f91c6b-1f95-4bff-8490-eb648ca0a9b9", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int s_ServiceWorkerSession_Open(int p0, Struct_0 p1, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p2, out string p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.Write_0(p1);
            _Unmarshal_Helper u = SendReceive(0, m);
            p2 = u.ReadContextHandle();
            p3 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public void s_ServiceWorkerSession_Close(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(1, m);
            p0 = u.ReadContextHandle();
        }
        public int s_ServiceWorkerSession_EnumerateAllSessions(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out int p1, out Struct_0[] p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(2, m);
            p1 = u.ReadInt32();
            p2 = u.ReadReferent<Struct_0[]>(new System.Func<Struct_0[]>(u.Read_16), false);
            return u.ReadInt32();
        }
        public int s_ServiceWorkerSession_CreateNewRegistration(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, Struct_2 p2, string p3, byte p4, out System.Nullable<Struct_3> p5, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p6)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.Write_1(p2);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p3, "p3"));
            m.WriteByte(p4);
            _Unmarshal_Helper u = SendReceive(3, m);
            p5 = u.ReadReferentValue<Struct_3>(new System.Func<Struct_3>(u.Read_2), false);
            p6 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int s_ServiceWorkerSession_GetRegistrationWithScopeUrl(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, Struct_2 p2, string p3, out System.Nullable<Struct_3> p4, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.Write_1(p2);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p3, "p3"));
            _Unmarshal_Helper u = SendReceive(4, m);
            p4 = u.ReadReferentValue<Struct_3>(new System.Func<Struct_3>(u.Read_2), false);
            p5 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int s_ServiceWorkerSession_GetRegistrationWithUniqueId(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, System.Guid p1, out System.Nullable<Struct_3> p2, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteGuid(p1);
            _Unmarshal_Helper u = SendReceive(5, m);
            p2 = u.ReadReferentValue<Struct_3>(new System.Func<Struct_3>(u.Read_2), false);
            p3 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int s_ServiceWorkerSession_FindActiveMatchingRegistration(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, Struct_2 p2, string p3, out System.Nullable<Struct_3> p4, out System.Nullable<Struct_5> p5, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p6)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.Write_1(p2);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p3, "p3"));
            _Unmarshal_Helper u = SendReceive(6, m);
            p4 = u.ReadReferentValue<Struct_3>(new System.Func<Struct_3>(u.Read_2), false);
            p5 = u.ReadReferentValue<Struct_5>(new System.Func<Struct_5>(u.Read_4), false);
            p6 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int s_ServiceWorkerSession_FindAllRegistrationsForOrigin(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, Struct_2 p2, out int p3, out Struct_3[] p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.Write_1(p2);
            _Unmarshal_Helper u = SendReceive(7, m);
            p3 = u.ReadInt32();
            p4 = u.ReadReferent<Struct_3[]>(new System.Func<Struct_3[]>(u.Read_17), false);
            return u.ReadInt32();
        }
        public int s_ServiceWorkerSession_FindAllRegistrationsWithPendingTaskTypes(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, out int p2, out Struct_3[] p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(8, m);
            p2 = u.ReadInt32();
            p3 = u.ReadReferent<Struct_3[]>(new System.Func<Struct_3[]>(u.Read_18), false);
            return u.ReadInt32();
        }
        public void s_ServiceWorkerRegistration_Close(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(9, m);
            p0 = u.ReadContextHandle();
        }
        public int s_ServiceWorkerRegistration_SetInstallingWorker(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, Struct_4 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.Write_3(p1);
            _Unmarshal_Helper u = SendReceive(10, m);
            return u.ReadInt32();
        }
        public int s_ServiceWorkerRegistration_UpdateState(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, System.Guid p1, byte p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteGuid(p1);
            m.WriteByte(p2);
            _Unmarshal_Helper u = SendReceive(11, m);
            return u.ReadInt32();
        }
        public int s_ServiceWorkerRegistration_Unregister(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(12, m);
            return u.ReadInt32();
        }
        public int s_ServiceWorkerRegistration_ClearWorkerUninstallingFlag(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, System.Guid p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteGuid(p1);
            _Unmarshal_Helper u = SendReceive(13, m);
            return u.ReadInt32();
        }
        public int s_ServiceWorkerRegistration_Delete(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(14, m);
            return u.ReadInt32();
        }
        public int s_ServiceWorkerRegistration_SetLastUpdateCheckTime(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, long p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt64(p1);
            _Unmarshal_Helper u = SendReceive(15, m);
            return u.ReadInt32();
        }
        public int s_ServiceWorkerRegistration_SetHasRequestedUpdate(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(16, m);
            return u.ReadInt32();
        }
        public int s_ServiceWorkerRegistration_SetUpdateViaCache(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, byte p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteByte(p1);
            _Unmarshal_Helper u = SendReceive(17, m);
            return u.ReadInt32();
        }
        public int s_ServiceWorkerRegistration_HasPushSubscriptionPolicyViolation(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out sbyte p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(18, m);
            p1 = u.ReadSByte();
            return u.ReadInt32();
        }
        public int s_ServiceWorkerRegistration_GetPolicyViolations(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out Struct_7 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(19, m);
            p1 = u.Read_6();
            return u.ReadInt32();
        }
        public int s_ServiceWorkerRegistration_IncrementPolicyViolations(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, System.Guid p1, byte p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteGuid(p1);
            m.WriteByte(p2);
            _Unmarshal_Helper u = SendReceive(20, m);
            return u.ReadInt32();
        }
        public int s_ServiceWorkerRegistration_ResetPolicyViolations(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, System.Guid p1, byte p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteGuid(p1);
            m.WriteByte(p2);
            _Unmarshal_Helper u = SendReceive(21, m);
            return u.ReadInt32();
        }
        public int s_ServiceWorkerRegistration_SetIsNavigationPreloadEnabled(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, sbyte p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteSByte(p1);
            _Unmarshal_Helper u = SendReceive(22, m);
            return u.ReadInt32();
        }
        public int s_ServiceWorkerRegistration_SetNavigationPreloadHeader(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, Struct_6 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.Write_5(p1);
            _Unmarshal_Helper u = SendReceive(23, m);
            return u.ReadInt32();
        }
        public int s_ServiceWorkerRegistration_GetNavigationPreloadState(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out System.Nullable<Struct_5> p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(24, m);
            p1 = u.ReadReferentValue<Struct_5>(new System.Func<Struct_5>(u.Read_4), false);
            return u.ReadInt32();
        }
        public int s_ServiceWorkerRegistration_GetPushSubscription(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out System.Nullable<Struct_9> p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(25, m);
            p1 = u.ReadReferentValue<Struct_9>(new System.Func<Struct_9>(u.Read_8), false);
            return u.ReadInt32();
        }
        public int s_ServiceWorkerRegistration_SetPushSubscription(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, Struct_9 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.Write_8(p1);
            _Unmarshal_Helper u = SendReceive(26, m);
            return u.ReadInt32();
        }
        public int s_ServiceWorkerRegistration_DeletePushSubscription(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, System.Guid p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteGuid(p1);
            _Unmarshal_Helper u = SendReceive(27, m);
            return u.ReadInt32();
        }
    }
    #endregion
}

