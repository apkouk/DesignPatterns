using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.ConcreteBeverages
{
    public class Decaf : Beverage
    {
        public override string GetDescription()
        {
            return "Decaf";
        }

        public override double Cost()
        {
            return 1.05;
        }
    }
}
