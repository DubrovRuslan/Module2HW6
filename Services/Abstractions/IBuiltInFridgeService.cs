namespace Module2HW6.Services.Abstractions
{
    public interface IBuiltInFridgeService
    {
        bool AddNewBuiltInFridge(string name, int power, double width, double height, double depth, bool presenceOfFacade, int shelvesCount);
    }
}
