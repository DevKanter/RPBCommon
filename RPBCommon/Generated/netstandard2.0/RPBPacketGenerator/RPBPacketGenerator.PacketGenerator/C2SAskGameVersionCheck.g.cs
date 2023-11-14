
using System;
using System.Runtime.CompilerServices;
using RPBUtilities;
using RPBPacketBase;

namespace SMG1Common.Packets.Connection
{

public partial class C2SAskGameVersionCheck
{
    private static readonly int _id = BitConverter.ToInt32(new byte[]{(byte)PCategory.CONNECTION,4,0,0},0);
    public override int PacketId => _id;
    public override int GetSize()
    {
        return  + sizeof(Int32);
    }

    public override void Serialize(ByteBuffer buffer)
    {
	    buffer.Write(GameVersion);

    }
    public override T Deserialize<T>(ByteBuffer buffer)
    {
        return Unsafe.As<T>(new C2SAskGameVersionCheck()
        {
,
	    GameVersion = buffer.Read<Int32>()

        });
    }
}
}