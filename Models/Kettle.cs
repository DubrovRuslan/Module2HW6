using Module2HW6.Models.Abstractions;

namespace Module2HW6.Models
{
    public class Kettle : ElectricalAppliance
    {
        public int Volume { get; set; }

        public override ElectricalApplianceType ElectricalApplianceType => ElectricalApplianceType.Kettle;
    }
}