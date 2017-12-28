using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Decorator.CondimentDecorators
{
    public class Mocha : CondimentDecorator
    {
        readonly Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            if (beverage == null) throw new ArgumentNullException(nameof(beverage));
            _beverage = beverage;
        }

    
        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Mocha";
        }

        public override double Cost()
        {
            return _beverage.Cost() + .20;
        }
    }
}
