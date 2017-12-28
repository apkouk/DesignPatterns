using System;
using DesignPatterns.FactoryPattern.Classes.Ingredients.Interfaces;

namespace DesignPatterns.FactoryPattern.Classes.Ingredients.Meat
{
    public class SlicedPeperoni : IPeperoni
    {
        public SlicedPeperoni()
        {
            Console.WriteLine("Adding sliced peperoni");
        }
    }
}