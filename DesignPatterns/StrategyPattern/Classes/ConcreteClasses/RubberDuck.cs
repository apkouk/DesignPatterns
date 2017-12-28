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
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehavior = new FlyWithWings();
            quakBehavior = new MuteQuack();
        }

        public override void display()
        {
            Console.WriteLine("I'm a Rubber duck!");
        }    
    }
}
