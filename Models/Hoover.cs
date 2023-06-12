using Module2HW6.Models.Abstractions;

namespace Module2HW6.Models
{
    public class Hoover : ElectricalAppliance
    {
        public bool IsAqua { get; set; }

        public int ContainerVolume { get; set; }

        public override ElectricalApplianceType ElectricalApplianceType => ElectricalApplianceType.Hoover;
    }
}