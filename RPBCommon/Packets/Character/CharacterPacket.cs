using RPBUtilities;

namespace SMG1Common.Packets.Character
{
    internal class CharacterPacket : BaseCategoryPacketAttribute
    {
        public CharacterPacket(CharacterProtocol protocol) : base(PCategory.CHARACTER, UConverter.ToByte(protocol))
        {
        }
    }
}