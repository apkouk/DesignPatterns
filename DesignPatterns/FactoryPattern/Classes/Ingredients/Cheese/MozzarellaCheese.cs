using System;
using DesignPatterns.FactoryPattern.Classes.Ingredients.Interfaces;

namespace DesignPatterns.FactoryPattern.Classes.Ingredients.Cheese
{
    public class MozzarellaCheese : ICheese
    {
        public MozzarellaCheese()
        {
            Console.WriteLine("Adding mozzarella cheese");
        }
    }
}