using Module2HW6.Models;
using Module2HW6.Models.Abstractions;
using Module2HW6.Services.Abstractions;

namespace Module2HW6
{
    public class Starter
    {
        private readonly INotificationService _notificationService;
        private readonly IElectricalApplianceService _electricalApplianceService;

        public Starter(INotificationService notificationService, IElectricalApplianceService electricalApplianceService)
        {
            _notificationService = notificationService;
            _electricalApplianceService = electricalApplianceService;
        }

        public void Run()
        {
            _electricalApplianceService.AddNewHoover("Samsung", 1700, 2, true);
            _electricalApplianceService.AddNewBuiltInFridge("Bosch", 600, 60, 1800, 60, false, 60);
            _electricalApplianceService.AddNewWasher("Lg", 2500, 65, 60, 70, 8);
            _electricalApplianceService.AddNewSmartMulticooker("Redmond", 900, SmartConnectionType.Bluetooth, "Java", 19);
            _electricalApplianceService.AddNewSmartKettle("Xiaomi", 2000, SmartConnectionType.WiFi, "android", 2);
            _electricalApplianceService.SortAppliancesByPower();
            _notificationService.ShowString("All devices after sort by power");
            _notificationService.ShowAppliancesDetails(_electricalApplianceService.GetAllElectricalAppliances());
            var resultBySmart = _electricalApplianceService.SearchApplianceBySmart();
            _notificationService.ShowString("All devices smart");
            _notificationService.ShowAppliancesDetails(resultBySmart);

            var resultByPower = _electricalApplianceService.SearchApplianceByPower(2000);
            _notificationService.ShowString("All devices power <= 2000 W, they will be on");
            _electricalApplianceService.PowerOn(resultByPower);
            _notificationService.ShowAppliancesDetails(resultByPower);
            var totalPowerResult = _electricalApplianceService.GetTotalPowerUsed();
            _notificationService.ShowString($"Total power used: {totalPowerResult}");
        }
    }
}
