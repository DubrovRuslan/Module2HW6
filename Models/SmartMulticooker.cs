using Module2HW6.Models.Abstractions;

namespace Module2HW6.Models
{
    public class SmartMulticooker : SmartElectricalAppliance
    {
        public int ProgramsCount { get; set; }

        public override ElectricalApplianceType ElectricalApplianceType => ElectricalApplianceType.SmartMulticooker;
    }
}