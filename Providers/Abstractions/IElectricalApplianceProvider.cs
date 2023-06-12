using Module2HW6.Models.Abstractions;

namespace Module2HW6.Providers.Abstractions
{
    public interface IElectricalApplianceProvider
    {
        ElectricalAppliance[] GetAllAppliances();
        bool AddNewElectricalAppliance(ElectricalAppliance electricalAppliance);
    }
}
