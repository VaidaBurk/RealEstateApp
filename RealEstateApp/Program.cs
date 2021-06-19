using System;
using System.Collections.Generic;

namespace RealEstateApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<RealEstate> realEstateObjects = new List<RealEstate>();

            realEstateObjects.Add(new RealEstate("flat", 112000, 64.2, "Vilnius"));
            realEstateObjects.Add(new RealEstate("flat", 68000, 67.02, "Klaipėda"));
            realEstateObjects.Add(new RealEstate("flat", 92000, 38, "Svencelė"));
            realEstateObjects.Add(new RealEstate("house", 66600, 49, "Klaipėda"));
            realEstateObjects.Add(new RealEstate("house", 149000, 40, "Dreverna"));
            realEstateObjects.Add(new RealEstate("house", 460000, 150, "Karklė"));

            for (int i = 0; i < realEstateObjects.Count; i++)
            {
                Console.WriteLine(realEstateObjects[i]);
            }
        }
    }
}
