namespace Module2HW6.Services.Abstractions
{
    public interface IBuiltInHobService
    {
        bool AddNewBuiltInHob(string name, int power, double width, double height, double depth, bool presenceOfFacade, int burnersCount);
    }
}
