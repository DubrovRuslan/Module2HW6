using Module2HW6.Services.Abstractions;

namespace Module2HW6.Services
{
    public class ConsoleNotificator : IConsoleNotificator
    {
        public void WriteToConsole(string message)
        {
            System.Console.WriteLine(message);
        }
    }
}
