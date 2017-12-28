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
    public class NyPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public IClams CreateClams()
        {
            return new FreshClams();
        }

        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public IPeperoni CreatePeperoni()
        {
            return new SlicedPeperoni();
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public IVeggies[] CreateVeggies()
        {
            IVeggies[] veggies = {new Garlic(), new Onion(), new Mushrom(), new RedPepper()};
            return veggies;
        }
    }
}