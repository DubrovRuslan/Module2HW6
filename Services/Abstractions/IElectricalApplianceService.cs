using Module2HW6.Models;
using Module2HW6.Models.Abstractions;

namespace Module2HW6.Services.Abstractions
{
    public interface IElectricalApplianceService
    {
        public ElectricalAppliance[] GetAllElectricalAppliances();
        ElectricalAppliance[] SearchApplianceByName(string name);
        ElectricalAppliance[] SearchApplianceByPower(int maxPower, int minPower);
        ElectricalAppliance[] SearchApplianceByPower(int maxPower);
        ElectricalAppliance[] SearchApplianceByType(ElectricalApplianceType electricalApplianceType);
        ElectricalAppliance[] SearchApplianceIsEnable();
        ElectricalAppliance[] SearchApplianceBySmart();
        void SortAppliancesByName();
        void SortAppliancesByPower();
        public int? GetTotalPowerUsed();
        public void PowerOn(ElectricalAppliance[] electricalAppliancesToOn);
        public void PowerOf(ElectricalAppliance[] electricalAppliancesToOff);
    }
}
