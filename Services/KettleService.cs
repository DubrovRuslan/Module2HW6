using Module2HW6.Models;
using Module2HW6.Providers.Abstractions;
using Module2HW6.Services.Abstractions;

namespace Module2HW6.Services
{
    public class KettleService : IKettleService
    {
        private readonly IElectricalApplianceProvider _electricalApplianceProvider;
        public KettleService(IElectricalApplianceProvider electricalApplianceProvider)
        {
            _electricalApplianceProvider = electricalApplianceProvider;
        }

        public bool AddNewKettle(string name, int power, int volume)
        {
            var kettle = new Kettle
            {
                Name = name,
                Power = power,
                Volume = volume
            };
            return _electricalApplianceProvider.AddNewElectricalAppliance(kettle);
        }
    }
}
