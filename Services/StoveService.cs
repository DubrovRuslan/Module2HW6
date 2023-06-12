using Module2HW6.Models;
using Module2HW6.Providers.Abstractions;
using Module2HW6.Services.Abstractions;

namespace Module2HW6.Services
{
    public class StoveService : IStoveService
    {
        private readonly IElectricalApplianceProvider _electricalApplianceProvider;
        public StoveService(IElectricalApplianceProvider electricalApplianceProvider)
        {
            _electricalApplianceProvider = electricalApplianceProvider;
        }

        public bool AddNewStove(string name, int power, double width, double height, double depth, int burnersCount)
        {
            var stove = new Stove
            {
                Name = name,
                Power = power,
                Width = width,
                Height = height,
                Depth = depth,
                BurnersCount = burnersCount
            };
            return _electricalApplianceProvider.AddNewElectricalAppliance(stove);
        }
    }
}
