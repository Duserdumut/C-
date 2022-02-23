using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppdrag2csharp
{
    // car making
    public class Car
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int Vintage { get; set; }
        public int Mileage { get; set; }
        public int Price { get; set; }
        public Car(string name, string model, int vintage, int mileage, int price)
        {
            Name = name;
            Model = model;
            Vintage = vintage;
            Mileage = mileage;
            Price = price;
        }
    }
 
}

