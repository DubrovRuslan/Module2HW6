using Module2HW6.Models.Abstractions;

namespace Module2HW6.Services.Abstractions
{
    public interface ISmartMulticookerService
    {
        bool AddNewSmartMulticooker(string name, int power, SmartConnectionType smartConnectionType, string operatingSystem, int programsCount);
    }
}
