namespace Module2HW6.Services.Abstractions
{
    public interface IHooverService
    {
        bool AddNewHoover(string name, int power, int containerVolume, bool isAqua);
    }
}
