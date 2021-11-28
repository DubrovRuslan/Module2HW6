namespace Module2HW6.Models.Abstractions
{
    public abstract class ElectricalAppliance
    {
        public string Name { get; set; }

        public int Power { get; set; }

        public bool IsEnable { get; set; }
        public abstract ElectricalApplianceType ElectricalApplianceType { get; }
    }
}