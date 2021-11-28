using Module2HW6.Models;
using Module2HW6.Models.Abstractions;
using Module2HW6.Providers.Abstractions;

namespace Module2HW6.Services.Abstractions
{
    public interface IElectricalApplianceService
    {
        bool AddNewBuiltInFridge(BuiltInFridge builtInFridge);
        bool AddNewBuiltInHob(BuiltInHob builtInHob);
        bool AddNewBuiltInOven(BuiltInOven builtInOven);
        bool AddNewBuiltInWasher(BuiltInWasher builtInWasher);
        bool AddNewFridge(Fridge fridge);
        bool AddNewHoover(Hoover hoover);
        bool AddNewIron(Iron iron);
        bool AddNewKettle(Kettle kettle);
        bool AddNewSmartHoover(SmartHoover smartHoover);
        bool AddNewSmartKettle(SmartKettle smartKettle);
        bool AddNewSmartMulticooker(SmartMulticooker smartMulticooker);
        bool AddNewStove(Stove stove);
        bool AddNewWasher(Washer washer);
        ElectricalAppliance[] SearchApplianceByName(string name);
        ElectricalAppliance[] SearchApplianceByPower(int maxPower, int minPower);
        ElectricalAppliance[] SearchApplianceByPower(int maxPower);
        ElectricalAppliance[] SearchApplianceByWeight(int maxWeight, int minWeight);
        ElectricalAppliance[] SearchApplianceByWeight(int maxWeight);
        ElectricalAppliance[] SearchApplianceByType(ElectricalApplianceType electricalApplianceType);
        ElectricalAppliance[] SearchApplianceIsEnable();
        void SortAppliancesByName();
        void SortAppliancesByPower();
    }
}
