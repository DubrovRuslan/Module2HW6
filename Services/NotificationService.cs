using System.Text;
using Module2HW6.Models.Abstractions;
using Module2HW6.Services.Abstractions;

namespace Module2HW6.Services
{
    public class NotificationService : INotificationService
    {
        private readonly IConsoleNotificator _consoleNotificator;
        public NotificationService(IConsoleNotificator consoleNotificator)
        {
            _consoleNotificator = consoleNotificator;
        }

        public void ShowAppliancesDetails(ElectricalAppliance[] electricalAppliances)
        {
            if (electricalAppliances == null)
            {
                return;
            }

            foreach (var item in electricalAppliances)
            {
                var toMessage = new StringBuilder();
                toMessage.Append($"Name: {item.Name}, ");
                toMessage.Append($"Type: {item.ElectricalApplianceType}, ");
                toMessage.Append("IsEnable: ");
                if (item.IsEnable)
                {
                    toMessage.Append("Yes, ");
                }
                else
                {
                    toMessage.Append("No, ");
                }

                toMessage.Append($"Power: {item.Power} Watt");
                _consoleNotificator.WriteToConsole(toMessage.ToString());
            }
        }

        public void ShowString(string message)
        {
            _consoleNotificator.WriteToConsole(message);
        }
    }
}
