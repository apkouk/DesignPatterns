using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.ConcreteBeverages
{
    public class HouseBlend : Beverage
    {
        public override string GetDescription()
        {
            return "HouseBlend";
        }

        public override double Cost()
        {
            return .89;
        }
    }
}
