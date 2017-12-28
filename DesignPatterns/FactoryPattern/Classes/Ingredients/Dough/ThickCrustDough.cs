using System;
using DesignPatterns.FactoryPattern.Classes.Ingredients.Interfaces;

namespace DesignPatterns.FactoryPattern.Classes.Ingredients.Dough
{
    public class ThickCrustDough : IDough
    {
        public ThickCrustDough()
        {
            Console.WriteLine("Adding thick crust dough");
        }
    }
}