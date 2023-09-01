
using System;
using System.Runtime.CompilerServices;
using RPBUtilities;
using RPBPacketBase;

namespace RPBCommon.Packet.Packets.Character
{

public partial class C2SCharacterCreate : RPBPacket
{
    private static readonly int _id = BitConverter.ToInt32(new byte[]{1,0,0,0},0);
    public override int PacketId => _id;
    public override int GetSize()
    {
        return sizeof(Int32) + CharName.Length + 4;
    }

    public override void Serialize(ByteBuffer buffer)
    {
	    buffer.Write(CharID);
	    buffer.Write(CharName);

    }
    public override T Deserialize<T>(ByteBuffer buffer)
    {
        return Unsafe.As<T>(new C2SCharacterCreate()
        {
	    CharID = buffer.Read<Int32>(),
	    CharName = buffer.ReadString()

        });
    }
}
}