using Module2HW6.Models.Abstractions;

namespace Module2HW6.Models
{
    public class BuiltInHob : BuiltInLargeHomeAppliances
    {
        public int BurnersCount { get; set; }

        public override ElectricalApplianceType ElectricalApplianceType => ElectricalApplianceType.BuiltInHob;
    }
}