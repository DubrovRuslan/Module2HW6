using Module2HW6.Models.Abstractions;
using Module2HW6.Services.Abstractions;

namespace Module2HW6
{
    public class Starter
    {
        private readonly INotificationService _notificationService;
        private readonly IElectricalApplianceService _electricalApplianceService;
        private readonly IBuiltInFridgeService _builtInFridgeService;
        private readonly IBuiltInHobService _builtInHobService;
        private readonly IBuiltInOvenService _builtInOvenService;
        private readonly IBuiltInWasherService _builtInWasherService;
        private readonly IFridgeService _fridgeService;
        private readonly IHooverService _hooverService;
        private readonly IIronService _ironService;
        private readonly IKettleService _kettleService;
        private readonly ISmartHooverService _smartHooverService;
        private readonly ISmartKettleService _smartKettleService;
        private readonly ISmartMulticookerService _smartMulticookerService;
        private readonly IStoveService _stoveService;
        private readonly IWasherService _washerService;

        public Starter(INotificationService notificationService, IElectricalApplianceService electricalApplianceService, IBuiltInFridgeService builtInFridgeService, IBuiltInHobService builtInHobService, IBuiltInOvenService builtInOvenService, IBuiltInWasherService builtInWasherService, IFridgeService fridgeService, IHooverService hooverService, IIronService ironService, IKettleService kettleService, ISmartHooverService smartHooverService, ISmartKettleService smartKettleService, ISmartMulticookerService smartMulticookerService, IStoveService stoveService, IWasherService washerService)
        {
            _notificationService = notificationService;
            _electricalApplianceService = electricalApplianceService;
            _builtInFridgeService = builtInFridgeService;
            _builtInHobService = builtInHobService;
            _builtInOvenService = builtInOvenService;
            _builtInWasherService = builtInWasherService;
            _fridgeService = fridgeService;
            _hooverService = hooverService;
            _ironService = ironService;
            _kettleService = kettleService;
            _smartHooverService = smartHooverService;
            _smartKettleService = smartKettleService;
            _smartMulticookerService = smartMulticookerService;
            _stoveService = stoveService;
            _washerService = washerService;
        }

        public void Run()
        {
            _hooverService.AddNewHoover("Samsung", 1700, 2, true);
            _builtInFridgeService.AddNewBuiltInFridge("Bosch", 600, 60, 1800, 60, false, 60);
            _washerService.AddNewWasher("Lg", 2500, 65, 60, 70, 8);
            _smartMulticookerService.AddNewSmartMulticooker("Redmond", 900, SmartConnectionType.Bluetooth, "Java", 19);
            _smartKettleService.AddNewSmartKettle("Xiaomi", 2000, SmartConnectionType.WiFi, "android", 2);
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
