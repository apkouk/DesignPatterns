using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.StrategyPattern.Interfaces;

namespace DesignPatterns.StrategyPattern.Classes.ConcreteBehaviors
{
    public class FlyWithWings : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I'm flying with wings!!");    
        }
    }
}
