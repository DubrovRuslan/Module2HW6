namespace Module2HW6.Services.Abstractions
{
    public interface IBuiltInOvenService
    {
        bool AddNewBuiltInOven(string name, int power, double width, double height, double depth, bool presenceOfFacade, bool isConvection);
    }
}
