﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.ConcreteBeverages
{
    public class DarkRoast : Beverage
    {
        public override string GetDescription()
        {
            return "Dark Roast";
        }

        public override double Cost()
        {
            return .99;
        }
    }
}
