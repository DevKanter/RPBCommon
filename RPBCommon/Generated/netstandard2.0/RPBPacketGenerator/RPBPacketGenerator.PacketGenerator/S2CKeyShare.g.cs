
using System;
using System.Runtime.CompilerServices;
using RPBUtilities;

namespace RPBCommon.Packet.Packets.Crypt
{

public partial class S2CKeyShare : RPBPacket
{
    private static readonly int _id = BitConverter.ToInt32(new byte[]{2,0,0,0},0);
    public override int PacketId => _id;
    public override int GetSize()
    {
        return Key.Length + 4 + IV.Length + 4;
    }

    public override void Serialize(ByteBuffer buffer)
    {
	    buffer.Write(Key);
	    buffer.Write(IV);

    }
    public override T Deserialize<T>(ByteBuffer buffer)
    {
        return Unsafe.As<T>(new S2CKeyShare()
        {
	    Key = buffer.ReadBytes(),
	    IV = buffer.ReadBytes()

        });
    }
}
}