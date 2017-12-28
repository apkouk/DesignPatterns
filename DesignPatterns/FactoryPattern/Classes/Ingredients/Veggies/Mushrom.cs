using System;
using DesignPatterns.FactoryPattern.Classes.Ingredients.Interfaces;

namespace DesignPatterns.FactoryPattern.Classes.Ingredients.Veggies
{
    public class Mushrom : IVeggies
    {
        public Mushrom()
        {
            Console.WriteLine("Adding mushroms");
        }
    }
}