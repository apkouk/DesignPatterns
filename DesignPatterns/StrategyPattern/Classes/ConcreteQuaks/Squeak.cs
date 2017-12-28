using DesignPatterns.StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern.Classes.ConcreteQuaks
{
    public class Squeak : QuakBehavior
    {
        public void quak()
        {
            Console.WriteLine("Squeak");
        }
    }
}
