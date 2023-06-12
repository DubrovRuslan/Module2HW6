using Module2HW6.Models.Abstractions;

namespace Module2HW6.Models
{
    public class Stove : LargeHomeAppliances
    {
        public int BurnersCount { get; set; }

        public override ElectricalApplianceType ElectricalApplianceType => ElectricalApplianceType.Stove;
    }
}