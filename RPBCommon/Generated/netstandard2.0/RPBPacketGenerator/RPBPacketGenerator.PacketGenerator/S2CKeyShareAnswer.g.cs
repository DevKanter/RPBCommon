
using System;
using System.Runtime.CompilerServices;
using RPBUtilities;

namespace RPBCommon.Packet.Packets.Crypt
{

public partial class S2CKeyShareAnswer : RPBPacket
{
    private static readonly int _id = BitConverter.ToInt32(new byte[]{2,1,0,0},0);
    public override int PacketId => _id;
    public override int GetSize()
    {
        return sizeof(Boolean);
    }

    public override void Serialize(ByteBuffer buffer)
    {
	    buffer.Write(Success);

    }
    public override T Deserialize<T>(ByteBuffer buffer)
    {
        return Unsafe.As<T>(new S2CKeyShareAnswer()
        {
	    Success = buffer.Read<Boolean>()

        });
    }
}
}