using DesignPatterns.StrategyPattern.Classes.ConcreteBehaviors;
using DesignPatterns.StrategyPattern.Classes.ConcreteQuaks;
using DesignPatterns.StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern.Classes
{
    public abstract class Duck
    {
        public FlyBehavior flyBehavior;
        public QuakBehavior quakBehavior;

        public Duck()
        {
        }

        public abstract void display();
        
       
        public void PerformFly()
        {
            flyBehavior.fly();
        }    

        public void PerformQuak()
        {
            quakBehavior.quak();
        }

        internal void SetFlyBehavior(FlyBehavior fb)
        {
            flyBehavior = fb;
        }

        internal void SetQuakBehavior(QuakBehavior qb)
        {
            quakBehavior = qb;
        }             

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys");
        }

    }
}
