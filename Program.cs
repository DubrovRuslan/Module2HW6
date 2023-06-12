using Microsoft.Extensions.DependencyInjection;
using Module2HW6;
using Module2HW6.Providers;
using Module2HW6.Providers.Abstractions;
using Module2HW6.Services;
using Module2HW6.Services.Abstractions;

var serviceProvider = new ServiceCollection()
                .AddSingleton<IElectricalApplianceProvider, ElectricalApplianceProvider>()
                .AddSingleton<IBuiltInFridgeService,  BuiltInFridgeService>()
                .AddSingleton<IBuiltInHobService,  BuiltInHobService>()
                .AddSingleton<IBuiltInOvenService,  BuiltInOvenService>()
                .AddSingleton<IBuiltInWasherService,  BuiltInWasherService>()
                .AddSingleton<IFridgeService,  FridgeService>()
                .AddSingleton<IHooverService,  HooverService>()
                .AddSingleton<IIronService, IronService>()
                .AddSingleton<IKettleService,  KettleService>()
                .AddSingleton<ISmartHooverService,  SmartHooverService>()
                .AddSingleton<ISmartKettleService,  SmartKettleService>()
                .AddSingleton<ISmartMulticookerService,  SmartMulticookerService>()
                .AddSingleton<IStoveService,  StoveService>()
                .AddSingleton<IWasherService,  WasherService>()
                .AddSingleton<IElectricalApplianceService, ElectricalApplianceService>()
                .AddSingleton<IConsoleNotificator, ConsoleNotificator>()
                .AddSingleton<INotificationService, NotificationService>()
                .AddTransient<Starter>()
                .BuildServiceProvider();
var start = serviceProvider.GetService<Starter>();
start.Run();
