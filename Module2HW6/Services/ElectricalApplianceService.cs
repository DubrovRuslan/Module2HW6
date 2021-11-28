using Module2HW6.Helpers;
using Module2HW6.Models;
using Module2HW6.Models.Abstractions;
using Module2HW6.Providers.Abstractions;
using Module2HW6.Services.Abstractions;

namespace Module2HW6.Services
{
    public class ElectricalApplianceService : IElectricalApplianceService
    {
        private readonly IElectricalApplianceProvider _electricalApplianceProvider;
        public ElectricalApplianceService(IElectricalApplianceProvider electricalApplianceProvider)
        {
            _electricalApplianceProvider = electricalApplianceProvider;
        }

        public bool AddNewBuiltInFridge(BuiltInFridge builtInFridge)
        {
            var allAppliances = _electricalApplianceProvider.GetAllAppliances();
            return ArrayHelper.AddElementToArray(ref allAppliances, builtInFridge);
        }

        public bool AddNewBuiltInHob(BuiltInHob builtInHob)
        {
            var allAppliances = _electricalApplianceProvider.GetAllAppliances();
            return ArrayHelper.AddElementToArray(ref allAppliances, builtInHob);
        }

        public bool AddNewBuiltInOven(BuiltInOven builtInOven)
        {
            var allAppliances = _electricalApplianceProvider.GetAllAppliances();
            return ArrayHelper.AddElementToArray(ref allAppliances, builtInOven);
        }

        public bool AddNewBuiltInWasher(BuiltInWasher builtInWasher)
        {
            var allAppliances = _electricalApplianceProvider.GetAllAppliances();
            return ArrayHelper.AddElementToArray(ref allAppliances, builtInWasher);
        }

        public bool AddNewFridge(Fridge fridge)
        {
            var allAppliances = _electricalApplianceProvider.GetAllAppliances();
            return ArrayHelper.AddElementToArray(ref allAppliances, fridge);
        }

        public bool AddNewHoover(Hoover hoover)
        {
            var allAppliances = _electricalApplianceProvider.GetAllAppliances();
            return ArrayHelper.AddElementToArray(ref allAppliances, hoover);
        }

        public bool AddNewIron(Iron iron)
        {
            var allAppliances = _electricalApplianceProvider.GetAllAppliances();
            return ArrayHelper.AddElementToArray(ref allAppliances, iron);
        }

        public bool AddNewKettle(Kettle kettle)
        {
            var allAppliances = _electricalApplianceProvider.GetAllAppliances();
            return ArrayHelper.AddElementToArray(ref allAppliances, kettle);
        }

        public bool AddNewSmartHoover(SmartHoover smartHoover)
        {
            var allAppliances = _electricalApplianceProvider.GetAllAppliances();
            return ArrayHelper.AddElementToArray(ref allAppliances, smartHoover);
        }

        public bool AddNewSmartKettle(SmartKettle smartKettle)
        {
            var allAppliances = _electricalApplianceProvider.GetAllAppliances();
            return ArrayHelper.AddElementToArray(ref allAppliances, smartKettle);
        }

        public bool AddNewSmartMulticooker(SmartMulticooker smartMulticooker)
        {
            var allAppliances = _electricalApplianceProvider.GetAllAppliances();
            return ArrayHelper.AddElementToArray(ref allAppliances, smartMulticooker);
        }

        public bool AddNewStove(Stove stove)
        {
            var allAppliances = _electricalApplianceProvider.GetAllAppliances();
            return ArrayHelper.AddElementToArray(ref allAppliances, stove);
        }

        public bool AddNewWasher(Washer washer)
        {
            var allAppliances = _electricalApplianceProvider.GetAllAppliances();
            return ArrayHelper.AddElementToArray(ref allAppliances, washer);
        }

        public ElectricalAppliance[] SearchApplianceByName(string name)
        {
            var allAppliances = _electricalApplianceProvider.GetAllAppliances();
            ElectricalAppliance[] result = null;
            foreach (var item in allAppliances)
            {
                ArrayHelper.AddElementToArray(ref result, item.GetElectricalApplianceByName(name));
            }

            return result;
        }

        public ElectricalAppliance[] SearchApplianceByPower(int maxPower, int minPower)
        {
            var allAppliances = _electricalApplianceProvider.GetAllAppliances();
            ElectricalAppliance[] result = null;
            foreach (var item in allAppliances)
            {
                ArrayHelper.AddElementToArray(ref result, item.GetElectricalApplianceByPower(maxPower, minPower));
            }

            return result;
        }

        public ElectricalAppliance[] SearchApplianceByPower(int maxPower)
        {
            var allAppliances = _electricalApplianceProvider.GetAllAppliances();
            ElectricalAppliance[] result = null;
            foreach (var item in allAppliances)
            {
                ArrayHelper.AddElementToArray(ref result, item.GetElectricalApplianceByPower(maxPower));
            }

            return result;
        }

        public ElectricalAppliance[] SearchApplianceByType(ElectricalApplianceType electricalApplianceType)
        {
            var allAppliances = _electricalApplianceProvider.GetAllAppliances();
            ElectricalAppliance[] result = null;
            foreach (var item in allAppliances)
            {
                ArrayHelper.AddElementToArray(ref result, item.GetElectricalApplianceByType(electricalApplianceType));
            }

            return result;
        }

        public ElectricalAppliance[] SearchApplianceByWeight(int maxWeight, int minWeight)
        {
            var allAppliances = _electricalApplianceProvider.GetAllAppliances();
            ElectricalAppliance[] result = null;
            foreach (var item in allAppliances)
            {
                ArrayHelper.AddElementToArray(ref result, item.GetElectricalApplianceByWeight(maxWeight, minWeight));
            }

            return result;
        }

        public ElectricalAppliance[] SearchApplianceByWeight(int maxWeight)
        {
            var allAppliances = _electricalApplianceProvider.GetAllAppliances();
            ElectricalAppliance[] result = null;
            foreach (var item in allAppliances)
            {
                ArrayHelper.AddElementToArray(ref result, item.GetElectricalApplianceByWeight(maxWeight));
            }

            return result;
        }

        public ElectricalAppliance[] SearchApplianceIsEnable()
        {
            var allAppliances = _electricalApplianceProvider.GetAllAppliances();
            ElectricalAppliance[] result = null;
            foreach (var item in allAppliances)
            {
                ArrayHelper.AddElementToArray(ref result, item.GetElectricalApplianceIsOn());
            }

            return result;
        }

        public void SortAppliancesByName()
        {
            var allAppliances = _electricalApplianceProvider.GetAllAppliances();
            System.Array.Sort(allAppliances, new ElectricalApplianceNameComparer());
        }

        public void SortAppliancesByPower()
        {
            var allAppliances = _electricalApplianceProvider.GetAllAppliances();
            System.Array.Sort(allAppliances, new ElectricalAppliancePowerComparer());
        }
    }
}
