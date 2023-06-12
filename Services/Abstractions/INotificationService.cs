using Module2HW6.Models.Abstractions;

namespace Module2HW6.Services.Abstractions
{
    public interface INotificationService
    {
        void ShowAppliancesDetails(ElectricalAppliance[] electricalAppliances);
        void ShowString(string message);
    }
}
