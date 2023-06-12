using Module2HW6.Providers.Abstractions;
using Module2HW6.Models;
using Module2HW6.Services.Abstractions;

namespace Module2HW6.Services
{
    public class BuiltInHobService : IBuiltInHobService
    {
        private readonly IElectricalApplianceProvider _electricalApplianceProvider;
        public BuiltInHobService(IElectricalApplianceProvider electricalApplianceProvider)
        {
            _electricalApplianceProvider = electricalApplianceProvider;
        }

        public bool AddNewBuiltInHob(string name, int power, double width, double height, double depth, bool presenceOfFacade, int burnersCount)
        {
            var builtInHob = new BuiltInHob
            {
                Name = name,
                Power = power,
                Width = width,
                Height = height,
                Depth = depth,
                PresenceOfFacade = presenceOfFacade,
                BurnersCount = burnersCount
            };
            return _electricalApplianceProvider.AddNewElectricalAppliance(builtInHob);
        }
    }
}
