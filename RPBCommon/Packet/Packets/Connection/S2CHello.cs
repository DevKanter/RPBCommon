using RPBPacketBase;
using static SMG1Common.Packet.ConnectionProtocol;
using static SMG1Common.Packet.PCategory;

namespace SMG1Common.Packet.Packets.Connection
{
    [RPBPacketBase.Packet((byte)CONNECTION,(byte)S2C_HELLO)]
    public partial class S2CHello : RPBPacket
    {
        public string ServerMessage;
    }

    [RPBPacketBase.Packet((byte)CONNECTION, (byte)C2S_HELLO)]
    public partial class C2SHello :RPBPacket
    {
        public string ServerMessage;
    }

}
