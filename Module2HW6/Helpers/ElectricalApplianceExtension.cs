using Module2HW6.Models.Abstractions;

namespace Module2HW6.Helpers
{
    public static class ElectricalApplianceExtension
    {
        public static ElectricalAppliance GetElectricalApplianceIsOn(this ElectricalAppliance electricalAppliance)
        {
            ElectricalAppliance result = null;
            if (electricalAppliance.IsEnable)
            {
                result = electricalAppliance;
            }

            return result;
        }

        public static ElectricalAppliance GetElectricalApplianceByPower(this ElectricalAppliance electricalAppliance, int maxPower)
        {
            ElectricalAppliance result = null;
            if (electricalAppliance.Power <= maxPower)
            {
                result = electricalAppliance;
            }

            return result;
        }

        public static ElectricalAppliance GetElectricalApplianceByPower(this ElectricalAppliance electricalAppliance, int maxPower, int minPower)
        {
            ElectricalAppliance result = null;
            if (electricalAppliance.Power >= minPower && electricalAppliance.Power <= maxPower)
            {
                result = electricalAppliance;
            }

            return result;
        }

        public static ElectricalAppliance GetElectricalApplianceByName(this ElectricalAppliance electricalAppliance, string name)
        {
            ElectricalAppliance result = null;
            if (electricalAppliance.Name.Contains(name))
            {
                result = electricalAppliance;
            }

            return result;
        }

        public static ElectricalAppliance GetElectricalApplianceByType(this ElectricalAppliance electricalAppliance, ElectricalApplianceType electricalApplianceType)
        {
            ElectricalAppliance result = null;
            if (electricalAppliance.ElectricalApplianceType == electricalApplianceType)
            {
                result = electricalAppliance;
            }

            return result;
        }

        public static ElectricalAppliance GetElectricalApplianceBySmart(this ElectricalAppliance electricalAppliance)
        {
            ElectricalAppliance result = null;
            if (electricalAppliance is SmartElectricalAppliance)
            {
                result = electricalAppliance;
            }

            return result;
        }
    }
}
