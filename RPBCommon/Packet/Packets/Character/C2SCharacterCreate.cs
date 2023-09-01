

using SMG1Common.Packet;

namespace RPBCommon.Packet.Packets.Character
{
    using RPBPacketBase;

    [Packet((byte)PCategory.CHARACTER, (byte)CharacterProtocol.CREATE)]
    public partial class C2SCharacterCreate : RPBPacket
    {
        public int CharID;
        public string CharName;
    }
}