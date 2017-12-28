using DesignPatterns.FactoryPattern.Classes.Ingredients.Interfaces;

namespace DesignPatterns.FactoryPattern.Interfaces
{
    public interface IPizzaIngredientFactory
    {
        IDough CreateDough();
        ISauce CreateSauce();
        ICheese CreateCheese();
        IVeggies[] CreateVeggies();
        IPeperoni CreatePeperoni();
        IClams CreateClams();
    }
}