namespace Module2HW6.Services.Abstractions
{
    public interface IFridgeService
    {
        bool AddNewFridge(string name, int power, double width, double height, double depth, bool isFreezerfreezer, int numberOfShelves);
    }
}
