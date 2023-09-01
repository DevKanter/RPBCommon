// ReSharper disable InconsistentNaming
namespace SMG1Common.Packet
{
    public enum PCategory : byte
    {
        CONNECTION,
        CHARACTER,


        
    }
    public enum CharacterProtocol :byte
    {
        CREATE,
        DELETE
    }

    public enum ConnectionProtocol : byte
    {

        S2C_HELLO,
        C2S_HELLO,
        
        C2S_CHECK_VERSION,
        S2C_CHECK_VERSION_ACK
    }

}