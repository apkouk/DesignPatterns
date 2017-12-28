using DesignPatterns.FactoryPattern.Classes.Ingredients.Cheese;
using DesignPatterns.FactoryPattern.Classes.Ingredients.Clams;
using DesignPatterns.FactoryPattern.Classes.Ingredients.Dough;
using DesignPatterns.FactoryPattern.Classes.Ingredients.Interfaces;
using DesignPatterns.FactoryPattern.Classes.Ingredients.Meat;
using DesignPatterns.FactoryPattern.Classes.Ingredients.Sauce;
using DesignPatterns.FactoryPattern.Classes.Ingredients.Veggies;
using DesignPatterns.FactoryPattern.Interfaces;

namespace DesignPatterns.FactoryPattern.Classes.IngredientFactories
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public IClams CreateClams()
        {
            return new FrozenClams();
        }

        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }

        public IPeperoni CreatePeperoni()
        {
            return new SlicedPeperoni();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public IVeggies[] CreateVeggies()
        {
            IVeggies[] veggies = { new Garlic(), new Onion(), new Mushrom()};
            return veggies;
        }
    }
}