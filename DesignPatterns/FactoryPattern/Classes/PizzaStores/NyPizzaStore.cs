using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.FactoryPattern.Classes.IngredientFactories;
using DesignPatterns.FactoryPattern.Classes.PizzaTypes;
using DesignPatterns.FactoryPattern.Interfaces;

namespace DesignPatterns.FactoryPattern.Classes.PizzaStores
{
    public class NyPizzaStore : PizzaStore
    {
        Pizza _pizza = null;
        readonly IPizzaIngredientFactory _pizzaIngredientFactory = new NyPizzaIngredientFactory();

        public override void CreatePizza(string item)
        {
            if (item.Equals("cheese"))
            {
                _pizza = new CheesPizza(_pizzaIngredientFactory);
                _pizza.SetName("NY style cheese pizza");
            }
            else if (item.Equals("veggie"))
            {
                _pizza = new VeggiePizza(_pizzaIngredientFactory);
                _pizza.SetName("NY style veggie pizza");
            }
            else if (item.Equals("clam"))
            {
                _pizza = new ClamPizza(_pizzaIngredientFactory);
                _pizza.SetName("NY style clam pizza");
            }
            else if (item.Equals("peperoni"))
            {
                _pizza = new ClamPizza(_pizzaIngredientFactory);
                _pizza.SetName("NY style peperoni pizza");
            }
        }

        public override void OrderPizza(string item)
        {
            CreatePizza(item);
            _pizza.Prepare();
            _pizza.Bake();
            _pizza.Cut();
            _pizza.Box();
        }
    }
}
