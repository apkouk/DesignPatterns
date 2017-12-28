using System;
using DesignPatterns.FactoryPattern.Classes.Ingredients.Interfaces;

namespace DesignPatterns.FactoryPattern.Classes.Ingredients.Clams
{
    public class FrozenClams : IClams
    {
        public FrozenClams()
        {
            Console.WriteLine("Adding frozen clams");
        }
    }
}