namespace Module2HW6.Models.Abstractions
{
    public abstract class SmartElectricalAppliance : ElectricalAppliance
    {
        public SmartConnectionType ConnectionType { get; set; }

        public string OperatingSystem { get; set; }
    }
}