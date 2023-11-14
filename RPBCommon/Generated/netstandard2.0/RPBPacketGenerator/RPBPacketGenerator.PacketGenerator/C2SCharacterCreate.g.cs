
using System;
using System.Runtime.CompilerServices;
using RPBUtilities;
using RPBPacketBase;

namespace SMG1Common.Packets.Character
{

public partial class C2SCharacterCreate
{
    private static readonly int _id = BitConverter.ToInt32(new byte[]{(byte)PCategory.CHARACTER,4,0,0},0);
    public override int PacketId => _id;
    public override int GetSize()
    {
        return sizeof(Int32) + ;
    }

    public override void Serialize(ByteBuffer buffer)
    {
	    buffer.Write(CharID);

    }
    public override T Deserialize<T>(ByteBuffer buffer)
    {
        return Unsafe.As<T>(new C2SCharacterCreate()
        {
	    CharID = buffer.Read<Int32>(),


        });
    }
}
}