namespace Module2HW6.Services.Abstractions
{
    public interface IWasherService
    {
        bool AddNewWasher(string name, int power, double width, double height, double depth, int weightOfLaundry);
    }
}
