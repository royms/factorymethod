using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Sagway : Vehicle
    {
        protected string townvisiting;

        public Sagway(string model, float cylinder, string color, int numberOfWheels, string townvisiting) : base(model, cylinder, color, numberOfWheels)
        {
            this.townvisiting = townvisiting;
        }

        public override string ToString()
        {
            return "sagway : " + base.ToString() + $" { townvisiting}";
        }
    }
}
