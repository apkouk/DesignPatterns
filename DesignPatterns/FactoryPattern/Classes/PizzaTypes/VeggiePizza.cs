using System;
using DesignPatterns.FactoryPattern.Interfaces;

namespace DesignPatterns.FactoryPattern.Classes.PizzaTypes
{
    public class VeggiePizza : Pizza
    {
        private IPizzaIngredientFactory PizzaIngredientFactory;
        public VeggiePizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            PizzaIngredientFactory = pizzaIngredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Dough = PizzaIngredientFactory.CreateDough();
            Sauce = PizzaIngredientFactory.CreateSauce();
            Cheese = PizzaIngredientFactory.CreateCheese();
            Veggies = PizzaIngredientFactory.CreateVeggies();
        }
    }
}