using Microsoft.Extensions.DependencyInjection;
using Module2HW6.Providers;
using Module2HW6.Providers.Abstractions;
using Module2HW6.Services;
using Module2HW6.Services.Abstractions;

namespace Module2HW6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IElectricalApplianceProvider, ElectricalApplianceProvider>()
                .AddSingleton<IElectricalApplianceService, ElectricalApplianceService>()
                .AddSingleton<IConsoleNotificator, ConsoleNotificator>()
                .AddSingleton<INotificationService, NotificationService>()
                .AddTransient<Starter>()
                .BuildServiceProvider();
            var start = serviceProvider.GetService<Starter>();
            start.Run();
        }
    }
}
