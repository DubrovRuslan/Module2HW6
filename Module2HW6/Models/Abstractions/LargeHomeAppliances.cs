namespace Module2HW6.Models.Abstractions
{
    public abstract class LargeHomeAppliances : ElectricalAppliance
    {
        public double Width { get; set; }

        public double Height { get; set; }

        public double Depth { get; set; }
    }
}