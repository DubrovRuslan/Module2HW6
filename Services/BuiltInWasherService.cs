using Module2HW6.Models;
using Module2HW6.Providers.Abstractions;
using Module2HW6.Services.Abstractions;

namespace Module2HW6.Services
{
    internal class BuiltInWasherService : IBuiltInWasherService
    {
        private readonly IElectricalApplianceProvider _electricalApplianceProvider;
        public BuiltInWasherService(IElectricalApplianceProvider electricalApplianceProvider)
        {
            _electricalApplianceProvider = electricalApplianceProvider;
        }

        public bool AddNewBuiltInWasher(string name, int power, double width, double height, double depth, bool presenceOfFacade, bool isConvection, int weightOfLaundry)
        {
            var builtInWasher = new BuiltInWasher
            {
                Name = name,
                Power = power,
                Width = width,
                Height = height,
                Depth = depth,
                PresenceOfFacade = presenceOfFacade,
                WeightOfLaundry = weightOfLaundry
            };
            return _electricalApplianceProvider.AddNewElectricalAppliance(builtInWasher);
        }
    }
}
