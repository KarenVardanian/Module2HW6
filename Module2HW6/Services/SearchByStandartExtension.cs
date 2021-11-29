using System;

namespace Module2HW6.Models
{
    public static class SearchByStandartExtension
    {
        public static TaxiAvto[] SearchByConsume(this TaxiAvto[] auto, double smallestConsume, double biggestConsume)
        {
            TaxiAvto[] tmpData = new TaxiAvto[auto.Length];
            int[] indexes = new int[auto.Length];
            var index = 0;
            for (var i = 0; i < auto.Length; i++)
            {
                if (auto[i].CarConsume > smallestConsume && auto[i].CarConsume < biggestConsume)
                {
                    indexes[index] = i;
                    tmpData[index] = auto[i];
                    index++;
                }
            }

            Array.Resize(ref tmpData, index);
            return tmpData;
        }
    }
}
