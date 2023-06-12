namespace Module2HW6.Services.Abstractions
{
    public interface IStoveService
    {
        bool AddNewStove(string name, int power, double width, double height, double depth, int burnersCount);
    }
}
