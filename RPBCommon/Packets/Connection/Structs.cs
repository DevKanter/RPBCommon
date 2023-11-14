using RPBPacketBase;
using static SMG1Common.Packets.ConnectionProtocol;

namespace SMG1Common.Packets.Connection
{
    [ConnectionPacket(S2C_HELLO)]
    public partial class S2CHello : RPBPacket
    {
        public string ServerMessage;
    }


    [ConnectionPacket(C2S_ASK_GAME_VERSION)]
    public partial class C2SAskGameVersionCheck : RPBPacket
    {
        public string ClientIdentifier;
        public int GameVersion;
    }

    [ConnectionPacket(S2C_ACK_GAME_VERSION)]
    public partial class S2CAckGameVersionCheck : RPBPacket
    {
        public string LoadSceneName;
    }

    [ConnectionPacket(S2C_NAK_GAME_VERSION)]
    public partial class S2CNakGameVersionCheck : ErrorPacket { }


    [ConnectionPacket(C2S_ASK_LOGIN)]
    public partial class C2SAskLogin : RPBPacket
    {
        public string Username;
        public string PasswordHash;
    }

    [ConnectionPacket(S2C_ACK_LOGIN)]
    public partial class C2SAckLogin : RPBPacket
    {
        
    }

    [ConnectionPacket(S2C_NAK_LOGIN)]
    public partial class C2SNakLogin : ErrorPacket { }
}