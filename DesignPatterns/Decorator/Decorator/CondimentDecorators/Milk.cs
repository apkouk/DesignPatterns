using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Decorator.CondimentDecorators
{
    public class Milk : CondimentDecorator
    {
        readonly Beverage beverage;

        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Milk";
        }

        public override double Cost()
        {
            return beverage.Cost() + .10;
        }      
    }
}
