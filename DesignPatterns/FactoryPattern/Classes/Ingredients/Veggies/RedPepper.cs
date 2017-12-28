using System;
using DesignPatterns.FactoryPattern.Classes.Ingredients.Interfaces;

namespace DesignPatterns.FactoryPattern.Classes.Ingredients.Veggies
{
    public class RedPepper : IVeggies
    {
        public RedPepper()
        {
            Console.WriteLine("Adding red pepper");
        }
    }
}