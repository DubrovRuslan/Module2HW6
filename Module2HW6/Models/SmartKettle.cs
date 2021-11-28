using Module2HW6.Models.Abstractions;

namespace Module2HW6.Models
{
    public class SmartKettle : SmartElectricalAppliance
    {
        public int Volume { get; set; }

        public override ElectricalApplianceType ElectricalApplianceType => ElectricalApplianceType.SmartKettle;
    }
}