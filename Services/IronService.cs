using Module2HW6.Models;
using Module2HW6.Providers.Abstractions;
using Module2HW6.Services.Abstractions;

namespace Module2HW6.Services
{
    public class IronService : IIronService
    {
        private readonly IElectricalApplianceProvider _electricalApplianceProvider;
        public IronService(IElectricalApplianceProvider electricalApplianceProvider)
        {
            _electricalApplianceProvider = electricalApplianceProvider;
        }

        public bool AddNewIron(string name, int power, bool isSteamer)
        {
            var iron = new Iron
            {
                Name = name,
                Power = power,
                IsSteamer = isSteamer
            };
            return _electricalApplianceProvider.AddNewElectricalAppliance(iron);
        }
    }
}
