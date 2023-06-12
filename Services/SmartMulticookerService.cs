using Module2HW6.Models;
using Module2HW6.Models.Abstractions;
using Module2HW6.Providers.Abstractions;
using Module2HW6.Services.Abstractions;

namespace Module2HW6.Services
{
    public class SmartMulticookerService : ISmartMulticookerService
    {
        private readonly IElectricalApplianceProvider _electricalApplianceProvider;
        public SmartMulticookerService(IElectricalApplianceProvider electricalApplianceProvider)
        {
            _electricalApplianceProvider = electricalApplianceProvider;
        }

        public bool AddNewSmartMulticooker(string name, int power, SmartConnectionType smartConnectionType, string operatingSystem, int programsCount)
        {
            var smartMulticooker = new SmartMulticooker
            {
                Name = name,
                Power = power,
                ConnectionType = smartConnectionType,
                OperatingSystem = operatingSystem,
                ProgramsCount = programsCount
            };
            return _electricalApplianceProvider.AddNewElectricalAppliance(smartMulticooker);
        }
    }
}
