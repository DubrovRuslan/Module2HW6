using Module2HW6.Models;
using Module2HW6.Providers.Abstractions;
using Module2HW6.Services.Abstractions;

namespace Module2HW6.Services
{
    public class WasherService : IWasherService
    {
        private readonly IElectricalApplianceProvider _electricalApplianceProvider;
        public WasherService(IElectricalApplianceProvider electricalApplianceProvider)
        {
            _electricalApplianceProvider = electricalApplianceProvider;
        }

        public bool AddNewWasher(string name, int power, double width, double height, double depth, int weightOfLaundry)
        {
            var washer = new Washer
            {
                Name = name,
                Power = power,
                Width = width,
                Height = height,
                Depth = depth,
                WeightOfLaundry = weightOfLaundry
            };
            return _electricalApplianceProvider.AddNewElectricalAppliance(washer);
        }
    }
}
