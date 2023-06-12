using Module2HW6.Models.Abstractions;
using Module2HW6.Models;
using Module2HW6.Providers.Abstractions;
using Module2HW6.Services.Abstractions;

namespace Module2HW6.Services
{
    public class SmartKettleService : ISmartKettleService
    {
        private readonly IElectricalApplianceProvider _electricalApplianceProvider;
        public SmartKettleService(IElectricalApplianceProvider electricalApplianceProvider)
        {
            _electricalApplianceProvider = electricalApplianceProvider;
        }

        public bool AddNewSmartKettle(string name, int power, SmartConnectionType smartConnectionType, string operatingSystem, int volume)
        {
            var smartKettle = new SmartKettle
            {
                Name = name,
                Power = power,
                ConnectionType = smartConnectionType,
                OperatingSystem = operatingSystem,
                Volume = volume
            };
            return _electricalApplianceProvider.AddNewElectricalAppliance(smartKettle);
        }
    }
}
