using Module2HW6.Models.Abstractions;

namespace Module2HW6.Models
{
    public class Iron : ElectricalAppliance
    {
        public bool IsSteamer { get; set; }

        public override ElectricalApplianceType ElectricalApplianceType => ElectricalApplianceType.Iron;
    }
}