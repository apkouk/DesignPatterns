using System;
using DesignPatterns.FactoryPattern.Classes.Ingredients.Interfaces;

namespace DesignPatterns.FactoryPattern.Classes.Ingredients.Veggies
{
    public class Onion : IVeggies
    {
        public Onion()
        {
            Console.WriteLine("Adding onion");
        }

    }
}