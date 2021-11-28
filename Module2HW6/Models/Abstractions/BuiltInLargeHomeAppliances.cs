namespace Module2HW6.Models.Abstractions
{
    public abstract class BuiltInLargeHomeAppliances : LargeHomeAppliances
    {
        public bool PresenceOfFacade { get; set; }

        public double RecessedNicheWidth { get; set; }

        public double RecessedNicheHeight { get; set; }
    }
}