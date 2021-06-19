using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


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
            realEstateObjects.Add(new RealEstate("house", 11500, 18, "Gargždai"));
            realEstateObjects.Add(new RealEstate("house", 58000, 35, "Klemiškės"));
            realEstateObjects.Add(new RealEstate("house", 189000, 57.96, "Svencelė"));
            realEstateObjects.Add(new RealEstate("house", 70400, 38.02, "Svencelė"));
            realEstateObjects.Add(new RealEstate("flat", 84130, 52.91, "Klaipėda"));
            realEstateObjects.Add(new RealEstate("flat", 91245, 53.61, "Klaipėda"));
            realEstateObjects.Add(new RealEstate("flat", 239000, 94.99, "Klaipėda"));
            realEstateObjects.Add(new RealEstate("house", 85000, 60, "Gargždai"));
            realEstateObjects.Add(new RealEstate("house", 50000, 57, "Svencelė"));

            // order by city
            var orderedList = realEstateObjects.OrderBy(RealEstate => RealEstate.City).ToList();
            Console.WriteLine("---- list ordered by city ----");
            foreach (var item in orderedList)
            {
            Console.WriteLine(item);
            } 
            Console.WriteLine();

            // order by city and then price
            var orderedList2 = realEstateObjects.OrderBy(RealEstate => RealEstate.City).ThenByDescending(RealEstate => RealEstate.Price).ToList();
            Console.WriteLine("---- list ordered by city and then price");
            foreach (var item in orderedList2)
            {
                Console.WriteLine(item);
            } 

            Console.WriteLine();

            // order by sqm price
            for (int i = 0; i < realEstateObjects.Count; i++)
                {
                    for (int a = 0; a < realEstateObjects.Count; a++)
                    {
                        if (realEstateObjects[i].sqmPrice() > realEstateObjects[a].sqmPrice())
                        {
                            RealEstate tempVar = realEstateObjects[a];
                            realEstateObjects[a] = realEstateObjects[i];
                            realEstateObjects[i] = tempVar;
                        }
                    }
                }

                Console.WriteLine("---- list ordered by price per m² ----");
                for (int i = 0; i < realEstateObjects.Count; i++)
                {
                    Console.WriteLine(realEstateObjects[i]);
                }
            Console.WriteLine();

            // order by city name
            for (int i = 0; i < realEstateObjects.Count; i++)
            {
                for (int a = 0; a < realEstateObjects.Count; a++)
                {
                    if (String.Compare(realEstateObjects[i].City, realEstateObjects[a].City, true) < 0)
                    {
                        RealEstate tempVar = realEstateObjects[a];
                        realEstateObjects[a] = realEstateObjects[i];
                        realEstateObjects[i] = tempVar; 
                    }
                }
            }

            for (int i = 0; i < realEstateObjects.Count; i++)
            {
                for (int a = i+1; a < realEstateObjects.Count; a++)
                {
                    if (String.Compare(realEstateObjects[i].City, realEstateObjects[a].City, true) == 0)
                    {
                        if (realEstateObjects[i].sqmPrice() < realEstateObjects[a].sqmPrice())
                        {
                            RealEstate tempVar = realEstateObjects[a];
                            realEstateObjects[a] = realEstateObjects[i];
                            realEstateObjects[i] = tempVar;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            Console.WriteLine("----- list ordered by city name and then price per m² -----");
            for (int i = 0; i < realEstateObjects.Count; i++)
            {
                Console.WriteLine(realEstateObjects[i]);
                Thread.Sleep(500);
            }
        }
    }
}
