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

        public static ElectricalAppliance GetElectricalApplianceByCompany(this ElectricalAppliance electricalAppliance, string company)
        {
            ElectricalAppliance result = null;
            if (electricalAppliance.Company.Contains(company))
            {
                result = electricalAppliance;
            }

            return result;
        }

        public static ElectricalAppliance GetElectricalApplianceByWeight(this ElectricalAppliance electricalAppliance, int maxWeight, int minWeight)
        {
            ElectricalAppliance result = null;
            if (electricalAppliance.Weight >= minWeight && electricalAppliance.Weight <= maxWeight)
            {
                result = electricalAppliance;
            }

            return result;
        }

        public static ElectricalAppliance GetElectricalApplianceByWeight(this ElectricalAppliance electricalAppliance, int maxWeight)
        {
            ElectricalAppliance result = null;
            if (electricalAppliance.Weight <= maxWeight)
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
    }
}
