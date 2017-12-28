using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Decorator
{
    public abstract class SizeDecorator : Beverage
    {
        public abstract override string GetDescription();
    }
}
