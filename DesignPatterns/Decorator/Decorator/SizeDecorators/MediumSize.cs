using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Decorator.SizeDecorators
{
    public class MediumSize : SizeDecorator
    {
        Beverage beverage;

        public MediumSize(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return beverage.Cost() + .15;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Medium";
        }
    }
}
