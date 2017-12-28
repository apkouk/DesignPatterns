using System;
using DesignPatterns.FactoryPattern.Classes.Ingredients.Interfaces;

namespace DesignPatterns.FactoryPattern.Classes.Ingredients.Sauce
{
    public class PlumTomatoSauce : ISauce
    {
        public PlumTomatoSauce()
        {
            Console.WriteLine("Adding plum tomato sauce");
        }
    }
}