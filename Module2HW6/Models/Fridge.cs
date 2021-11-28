using Module2HW6.Models.Abstractions;

namespace Module2HW6.Models
{
    public class Fridge : LargeHomeAppliances
    {
        public int NumberOfShelves { get; set; }
        public bool IsFreezerfreezer { get; set; }

        public override ElectricalApplianceType ElectricalApplianceType => ElectricalApplianceType.Fridge;
    }
}