using Module2HW6.Providers.Abstractions;
using Module2HW6.Services.Abstractions;
using Module2HW6.Models;

namespace Module2HW6.Services
{
    public class BuiltInFridgeService : IBuiltInFridgeService
    {
        private readonly IElectricalApplianceProvider _electricalApplianceProvider;
        public BuiltInFridgeService(IElectricalApplianceProvider electricalApplianceProvider)
        {
            _electricalApplianceProvider = electricalApplianceProvider;
        }

        public bool AddNewBuiltInFridge(string name, int power, double width, double height, double depth, bool presenceOfFacade, int shelvesCount)
        {
            var builtInFridge = new BuiltInFridge
            {
                Name = name,
                Power = power,
                IsEnable = false,
                Width = width,
                Height = height,
                Depth = depth,
                PresenceOfFacade = presenceOfFacade,
                ShelvesCount = shelvesCount
            };
            return _electricalApplianceProvider.AddNewElectricalAppliance(builtInFridge);
        }
    }
}
