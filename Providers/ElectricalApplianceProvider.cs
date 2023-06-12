using Module2HW6.Helpers;
using Module2HW6.Models.Abstractions;
using Module2HW6.Providers.Abstractions;

namespace Module2HW6.Providers
{
    public class ElectricalApplianceProvider : IElectricalApplianceProvider
    {
        private ElectricalAppliance[] _electricalAppliances;

        public ElectricalAppliance[] GetAllAppliances()
        {
            return _electricalAppliances;
        }

        public bool AddNewElectricalAppliance(ElectricalAppliance electricalAppliance)
        {
            if (electricalAppliance == null)
            {
                return false;
            }

            return ArrayHelper.AddElementToArray(ref _electricalAppliances, electricalAppliance);
        }
    }
}
