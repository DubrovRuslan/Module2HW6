using Module2HW6.Models.Abstractions;

namespace Module2HW6.Models
{
    public class SmartHoover : SmartElectricalAppliance
    {
        public int ContainerVolume { get; set; }

        public override ElectricalApplianceType ElectricalApplianceType => ElectricalApplianceType.SmartHoover;
    }
}