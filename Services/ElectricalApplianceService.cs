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

        public ElectricalAppliance[] GetAllElectricalAppliances()
        {
            return _electricalApplianceProvider.GetAllAppliances();
        }

        public ElectricalAppliance[] SearchApplianceByName(string name)
        {
            var allAppliances = _electricalApplianceProvider.GetAllAppliances();
            if (allAppliances == null)
            {
                return null;
            }

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
            if (allAppliances == null)
            {
                return null;
            }

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
            if (allAppliances == null)
            {
                return null;
            }

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
            if (allAppliances == null)
            {
                return null;
            }

            ElectricalAppliance[] result = null;
            foreach (var item in allAppliances)
            {
                ArrayHelper.AddElementToArray(ref result, item.GetElectricalApplianceByType(electricalApplianceType));
            }

            return result;
        }

        public ElectricalAppliance[] SearchApplianceBySmart()
        {
            var allAppliances = _electricalApplianceProvider.GetAllAppliances();
            if (allAppliances == null)
            {
                return null;
            }

            ElectricalAppliance[] result = null;
            foreach (var item in allAppliances)
            {
                ArrayHelper.AddElementToArray(ref result, item.GetElectricalApplianceBySmart());
            }

            return result;
        }

        public ElectricalAppliance[] SearchApplianceIsEnable()
        {
            var allAppliances = _electricalApplianceProvider.GetAllAppliances();
            if (allAppliances == null)
            {
                return null;
            }

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
            if (allAppliances == null)
            {
                return;
            }

            System.Array.Sort(allAppliances, new ElectricalApplianceNameComparer());
        }

        public void SortAppliancesByPower()
        {
            var allAppliances = _electricalApplianceProvider.GetAllAppliances();
            if (allAppliances == null)
            {
                return;
            }

            System.Array.Sort(allAppliances, new ElectricalAppliancePowerComparer());
        }

        public int? GetTotalPowerUsed()
        {
            var result = 0;
            var allAppliances = _electricalApplianceProvider.GetAllAppliances();
            if (allAppliances == null)
            {
                return null;
            }

            foreach (var item in allAppliances)
            {
                if (item.IsEnable)
                {
                    result += item.Power;
                }
            }

            return result;
        }

        public void PowerOn(ElectricalAppliance[] electricalAppliancesToOn)
        {
            foreach (var item in electricalAppliancesToOn)
            {
                item.IsEnable = true;
            }
        }

        public void PowerOf(ElectricalAppliance[] electricalAppliancesToOff)
        {
            foreach (var item in electricalAppliancesToOff)
            {
                item.IsEnable = false;
            }
        }
    }
}
