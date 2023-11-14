using RPBPacketBase;

namespace SMG1Common.Packets.Character
{
    [CharacterPacket(CharacterProtocol.CREATE)]
    public partial class C2SCharacterCreate : RPBPacket
    {
        public int CharID;
        public string CharName;
    }
}