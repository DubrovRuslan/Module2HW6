using Module2HW6.Models.Abstractions;
using Module2HW6.Models;
using Module2HW6.Providers.Abstractions;
using Module2HW6.Services.Abstractions;

namespace Module2HW6.Services
{
    public class SmartHooverService : ISmartHooverService
    {
        private readonly IElectricalApplianceProvider _electricalApplianceProvider;
        public SmartHooverService(IElectricalApplianceProvider electricalApplianceProvider)
        {
            _electricalApplianceProvider = electricalApplianceProvider;
        }

        public bool AddNewSmartHoover(string name, int power, SmartConnectionType smartConnectionType, string operatingSystem, int containerVolume)
        {
            var smartHoover = new SmartHoover
            {
                Name = name,
                Power = power,
                ConnectionType = smartConnectionType,
                OperatingSystem = operatingSystem,
                ContainerVolume = containerVolume,
            };
            return _electricalApplianceProvider.AddNewElectricalAppliance(smartHoover);
        }
    }
}
