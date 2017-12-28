using System;
using DesignPatterns.FactoryPattern.Classes.Ingredients.Interfaces;

namespace DesignPatterns.FactoryPattern.Classes.Ingredients.Sauce
{
    public class MarinaraSauce : ISauce
    {
        public MarinaraSauce()
        {
            Console.WriteLine("Adding marinara sauce");
        }
    }
}