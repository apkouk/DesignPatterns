using System;
using DesignPatterns.FactoryPattern.Classes.Ingredients.Interfaces;

namespace DesignPatterns.FactoryPattern.Classes.Ingredients.Clams
{
    public class FreshClams : IClams
    {
        public FreshClams()
        {
            Console.WriteLine("Adding fresh clams");
        }
    }
}