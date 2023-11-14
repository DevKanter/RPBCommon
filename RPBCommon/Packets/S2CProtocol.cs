// ReSharper disable InconsistentNaming

namespace SMG1Common.Packets
{
    public enum PCategory : byte
    {
        CONNECTION,
        CHARACTER
    }

    public enum CharacterProtocol : byte
    {
        CREATE,
        DELETE
    }

    public enum ConnectionProtocol : byte
    {
        S2C_HELLO,

        C2S_ASK_GAME_VERSION,
        S2C_ACK_GAME_VERSION,
        S2C_NAK_GAME_VERSION,

        C2S_ASK_LOGIN,
        S2C_ACK_LOGIN,
        S2C_NAK_LOGIN
    }
}