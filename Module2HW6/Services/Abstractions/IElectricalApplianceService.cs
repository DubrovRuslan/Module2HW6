using Module2HW6.Models;
using Module2HW6.Models.Abstractions;

namespace Module2HW6.Services.Abstractions
{
    public interface IElectricalApplianceService
    {
        public ElectricalAppliance[] GetAllElectricalAppliances();
        bool AddNewBuiltInFridge(string name, int power, double width, double height, double depth, bool presenceOfFacade, int shelvesCount);
        bool AddNewBuiltInHob(string name, int power, double width, double height, double depth, bool presenceOfFacade, int burnersCount);
        bool AddNewBuiltInOven(string name, int power, double width, double height, double depth, bool presenceOfFacade, bool isConvection);
        bool AddNewBuiltInWasher(string name, int power, double width, double height, double depth, bool presenceOfFacade, bool isConvection, int weightOfLaundry);
        bool AddNewFridge(string name, int power, double width, double height, double depth, bool isFreezerfreezer, int numberOfShelves);
        bool AddNewHoover(string name, int power, int containerVolume, bool isAqua);
        bool AddNewIron(string name, int power, bool isSteamer);
        bool AddNewKettle(string name, int power, int volum);
        bool AddNewSmartHoover(string name, int power, SmartConnectionType smartConnectionType, string operatingSystem, int containerVolume);
        bool AddNewSmartKettle(string name, int power, SmartConnectionType smartConnectionType, string operatingSystem, int volume);
        bool AddNewSmartMulticooker(string name, int power, SmartConnectionType smartConnectionType, string operatingSystem, int programsCount);
        bool AddNewStove(string name, int power, double width, double height, double depth, int burnersCount);
        bool AddNewWasher(string name, int power, double width, double height, double depth, int weightOfLaundry);
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
