using DesignPatterns.Composite.Abstract;
using DesignPatterns.Composite.Interface;
using DesignPatterns.Composite.Iterators;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns.Composite.Menus
{
    public class CafeMenu : MenuComponent
    {
        Dictionary<string, MenuItem> menuItems = new Dictionary<string, MenuItem>();
        ArrayList menuComponents = new ArrayList();

        public CafeMenu()
        {
            addItem("Veggie Burger and Air Fries", "Veggie Burger on a wholw wheat bun, lettuce, tomato, adn fries", true, 3.99);            
            addItem("Soup of the day", "A cup of the soup of the day, with a side salad", false, 3.69);
            addItem("Burrito", "A large burrito, with whole pinto beans, salsa, guacamole", true, 4.29);
        }        

        private void addItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            menuItems.Add(menuItem.Name, menuItem);
        }

        public Interface.Iterator createIterator()
        {
            return new CafeMenuIterator(menuItems);
        }

        public override void Add(MenuComponent d)
        {
            menuComponents.Add(d);
        }

        public override void Remove(MenuComponent d)
        {
            menuComponents.Remove(d);
        }

        public override void Print(int indent)
        {
            MenuPrinter.Print(createIterator(), menuComponents);
        }
    }
}
