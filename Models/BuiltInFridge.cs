using Module2HW6.Models.Abstractions;

namespace Module2HW6.Models
{
    public class BuiltInFridge : BuiltInLargeHomeAppliances
    {
        public int ShelvesCount { get; set; }

        public override ElectricalApplianceType ElectricalApplianceType => ElectricalApplianceType.BuiltInFridge;
    }
}