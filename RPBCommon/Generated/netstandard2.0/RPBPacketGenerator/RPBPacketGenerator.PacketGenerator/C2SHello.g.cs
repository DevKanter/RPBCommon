
using System;
using System.Runtime.CompilerServices;
using RPBUtilities;
using RPBPacketBase;

namespace SMG1Common.Packet.Packets.Connection
{

public partial class C2SHello : RPBPacket
{
    private static readonly int _id = BitConverter.ToInt32(new byte[]{0,1,0,0},0);
    public override int PacketId => _id;
    public override int GetSize()
    {
        return ServerMessage.Length + 4;
    }

    public override void Serialize(ByteBuffer buffer)
    {
	    buffer.Write(ServerMessage);

    }
    public override T Deserialize<T>(ByteBuffer buffer)
    {
        return Unsafe.As<T>(new C2SHello()
        {
	    ServerMessage = buffer.ReadString()

        });
    }
}
}