using System;
using DesignPatterns.FactoryPattern.Classes.Ingredients.Interfaces;

namespace DesignPatterns.FactoryPattern.Classes.Ingredients.Dough
{
    public class ThinCrustDough : IDough
    {
        public ThinCrustDough()
        {
            Console.WriteLine("Adding thin crust dough");
        }
    }
}