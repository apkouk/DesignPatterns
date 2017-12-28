using System;
using DesignPatterns.FactoryPattern.Classes.Ingredients.Interfaces;

namespace DesignPatterns.FactoryPattern.Classes.Ingredients.Cheese
{
    public class ReggianoCheese : ICheese
    {
        public ReggianoCheese()
        {
            Console.WriteLine("Adding reggiano cheese");
        }
    }
}