using System;
using DesignPatterns.FactoryPattern.Interfaces;

namespace DesignPatterns.FactoryPattern.Classes.PizzaTypes
{
    public class Peperoni : Pizza
    {
        private readonly IPizzaIngredientFactory _pizzaIngredientFactory;
        public Peperoni(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            _pizzaIngredientFactory = pizzaIngredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Dough = _pizzaIngredientFactory.CreateDough();
            Sauce = _pizzaIngredientFactory.CreateSauce();
            Cheese = _pizzaIngredientFactory.CreateCheese();
            Peperoni = _pizzaIngredientFactory.CreatePeperoni();
        }
    }
}