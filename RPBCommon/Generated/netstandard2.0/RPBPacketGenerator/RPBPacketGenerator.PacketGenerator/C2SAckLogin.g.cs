
using System;
using System.Runtime.CompilerServices;
using RPBUtilities;
using RPBPacketBase;

namespace SMG1Common.Packets.Connection
{

public partial class C2SAckLogin
{
    private static readonly int _id = BitConverter.ToInt32(new byte[]{(byte)PCategory.CONNECTION,4,0,0},0);
    public override int PacketId => _id;
    public override int GetSize()
    {
        return 
    }

    public override void Serialize(ByteBuffer buffer)
    {

    }
    public override T Deserialize<T>(ByteBuffer buffer)
    {
        return Unsafe.As<T>(new C2SAckLogin()
        {

        });
    }
}
}