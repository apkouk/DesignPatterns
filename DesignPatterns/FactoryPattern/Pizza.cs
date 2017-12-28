using System;
using DesignPatterns.FactoryPattern.Classes.Ingredients.Interfaces;

namespace DesignPatterns.FactoryPattern
{
    public abstract class Pizza
    {
        public string Name;

        public IDough Dough;
        public ISauce Sauce;
        public IVeggies[] Veggies;
        public ICheese Cheese;
        public IPeperoni Peperoni;
        public IClams Clams;

        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public void SetName(string name)
        {
            this.Name = name;
        }

        public string GetName()
        {
            return this.Name;
        }

        //string ToString()
        //{

        //}


    }
}
