namespace DesignPatterns.FactoryPattern
{
    public abstract class PizzaStore
    {
        public abstract void CreatePizza(string item);
        public abstract void OrderPizza(string item);
    }
}
