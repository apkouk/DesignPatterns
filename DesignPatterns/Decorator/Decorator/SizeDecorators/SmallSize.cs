using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Decorator.SizeDecorators
{
    public class SmallSize : SizeDecorator
    {
        Beverage beverage;

        public SmallSize(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return beverage.Cost() + .10;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Small";
        }
    }
}
