using Module2HW6.Models;
using Module2HW6.Providers.Abstractions;
using Module2HW6.Services.Abstractions;

namespace Module2HW6.Services
{
    public class FridgeService : IFridgeService
    {
        private readonly IElectricalApplianceProvider _electricalApplianceProvider;
        public FridgeService(IElectricalApplianceProvider electricalApplianceProvider)
        {
            _electricalApplianceProvider = electricalApplianceProvider;
        }

        public bool AddNewFridge(string name, int power, double width, double height, double depth, bool isFreezerfreezer, int numberOfShelves)
        {
            var fridge = new Fridge
            {
                Name = name,
                Power = power,
                Width = width,
                Height = height,
                Depth = depth,
                IsFreezerfreezer = isFreezerfreezer,
                NumberOfShelves = numberOfShelves
            };
            return _electricalApplianceProvider.AddNewElectricalAppliance(fridge);
        }
    }
}
