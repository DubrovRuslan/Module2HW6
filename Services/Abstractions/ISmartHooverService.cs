using Module2HW6.Models.Abstractions;

namespace Module2HW6.Services.Abstractions
{
    public interface ISmartHooverService
    {
        bool AddNewSmartHoover(string name, int power, SmartConnectionType smartConnectionType, string operatingSystem, int containerVolume);
    }
}
