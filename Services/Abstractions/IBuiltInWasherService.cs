namespace Module2HW6.Services.Abstractions
{
    public interface IBuiltInWasherService
    {
        bool AddNewBuiltInWasher(string name, int power, double width, double height, double depth, bool presenceOfFacade, bool isConvection, int weightOfLaundry);
    }
}
