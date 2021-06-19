using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp
{
    class RealEstate
    {
        public RealEstate(string type, double price, double area, string city)
        {
            this.Type = type;
            this.Price = price;
            this.Area = area;
            this.City = city;
        }

        public string Type { get; set; }
        public double Price { get; set; }
        public double Area { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            string realEstateObject = "type: " + this.Type + "; price: " + this.Price + " Eur; area: " + this.Area + " m²; city: " + this.City 
                + "; price per m²: " + this.sqmPrice() + " Eur";
            return realEstateObject;
        }

        public double sqmPrice()
        {
            double sqmPrice = (this.Price / this.Area);
            sqmPrice = Math.Round(sqmPrice, 2);
            return sqmPrice;
        }
    }
}
