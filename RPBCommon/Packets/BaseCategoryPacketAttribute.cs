using RPBPacketBase;
using RPBUtilities;

namespace SMG1Common.Packets
{
    internal class BaseCategoryPacketAttribute : BasePacketAttribute
    {
        public BaseCategoryPacketAttribute(PCategory category, byte protocol) : base(UConverter.ToByte(category),
            protocol)
        {
        }
    }
}