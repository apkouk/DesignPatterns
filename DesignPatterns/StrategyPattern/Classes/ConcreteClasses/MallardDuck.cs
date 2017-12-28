using DesignPatterns.StrategyPattern.Classes.ConcreteBehaviors;
using DesignPatterns.StrategyPattern.Classes.ConcreteQuaks;
using DesignPatterns.StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern.Classes.ConcreteClasses
{
    public class MallardDuck : Duck
    {     
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quakBehavior = new Quack();
        }

        public override void display()
        {
            Console.WriteLine("I'm a Mallard duck!");
        }
    }
}
