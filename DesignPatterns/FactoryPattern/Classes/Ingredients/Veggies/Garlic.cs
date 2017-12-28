using System;
using DesignPatterns.FactoryPattern.Classes.Ingredients.Interfaces;

namespace DesignPatterns.FactoryPattern.Classes.Ingredients.Veggies
{
    public class Garlic : IVeggies
    {
        public Garlic()
        {
            Console.WriteLine("Adding garlic");
        }
    }
}