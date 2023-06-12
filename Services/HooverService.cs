using Module2HW6.Models;
using Module2HW6.Providers.Abstractions;
using Module2HW6.Services.Abstractions;

namespace Module2HW6.Services
{
    public class HooverService : IHooverService
    {
        private readonly IElectricalApplianceProvider _electricalApplianceProvider;
        public HooverService(IElectricalApplianceProvider electricalApplianceProvider)
        {
            _electricalApplianceProvider = electricalApplianceProvider;
        }

        public bool AddNewHoover(string name, int power, int containerVolume, bool isAqua)
        {
            var hoover = new Hoover
            {
                Name = name,
                Power = power,
                ContainerVolume = containerVolume,
                IsAqua = isAqua
            };
            return _electricalApplianceProvider.AddNewElectricalAppliance(hoover);
        }
    }
}
