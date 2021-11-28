using Module2HW6.Models.Abstractions;

namespace Module2HW6.Models
{
    public class BuiltInOven : BuiltInLargeHomeAppliances
    {
        public bool IsConvection { get; set; }

        public override ElectricalApplianceType ElectricalApplianceType => ElectricalApplianceType.BuiltInOven;
    }
}