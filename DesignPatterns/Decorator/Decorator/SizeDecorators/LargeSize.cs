﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Decorator.SizeDecorators
{
    public class LargeSize : SizeDecorator
    {
        Beverage beverage;

        public LargeSize(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return beverage.Cost() + .20;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Large";
        }
    }
}
