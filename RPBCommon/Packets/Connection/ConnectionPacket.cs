using RPBUtilities;

namespace SMG1Common.Packets.Connection
{
    internal class ConnectionPacket : BaseCategoryPacketAttribute
    {
        public ConnectionPacket(ConnectionProtocol protocol) : base(PCategory.CONNECTION, UConverter.ToByte(protocol))
        {
        }
    }
}