using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Truck : Vehicle
    {
        protected string driversongs;

        public Truck(string model, float cylinder, string color, int numberOfWheels, string driversongs) : base(model, cylinder, color, numberOfWheels)
        {
            this.driversongs = driversongs;
        }

        public override string ToString()
        {
            return "Truck : " + base.ToString() + $" { driversongs}";
        }
    }
}
