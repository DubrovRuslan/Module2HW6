using Module2HW6.Models.Abstractions;

namespace Module2HW6.Helpers
{
    public static class ArrayHelper
    {
        public static bool AddElementToArray(ref ElectricalAppliance[] array, in ElectricalAppliance newElement)
        {
            if (newElement == null)
            {
                return false;
            }

            var currentSize = (array == null) ? 0 : array.Length;
            var temp = new ElectricalAppliance[currentSize + 1];
            for (var i = 0; i < currentSize; i++)
            {
                temp[i] = array[i];
            }

            temp[currentSize] = newElement;
            array = temp;
            return true;
        }
    }
}
