using Module2HW6.Models;
using Module2HW6.Providers.Abstractions;
using Module2HW6.Services.Abstractions;

namespace Module2HW6.Services
{
    public class BuiltInOvenService : IBuiltInOvenService
    {
        private readonly IElectricalApplianceProvider _electricalApplianceProvider;
        public BuiltInOvenService(IElectricalApplianceProvider electricalApplianceProvider)
        {
            _electricalApplianceProvider = electricalApplianceProvider;
        }

        public bool AddNewBuiltInOven(string name, int power, double width, double height, double depth, bool presenceOfFacade, bool isConvection)
        {
            var builtInOven = new BuiltInOven
            {
                Name = name,
                Power = power,
                Width = width,
                Height = height,
                Depth = depth,
                PresenceOfFacade = presenceOfFacade,
                IsConvection = isConvection
            };
            return _electricalApplianceProvider.AddNewElectricalAppliance(builtInOven);
        }
    }
}
