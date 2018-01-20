using System;
using System.Collections;
using DesignPatterns.Composite.Abstract;
using DesignPatterns.Composite.Interface;
using DesignPatterns.Composite.Iterators;

namespace DesignPatterns.Composite.Menus
{
    public class DinerMenu : MenuComponent
    {
        ArrayList menuComponents = new ArrayList();
        const int MAX_ITEMS = 6;
        int numberOfItems = 0;
        MenuItem[] menuItems;

        public DinerMenu()
        {
            menuItems = new MenuItem[MAX_ITEMS];
            addItem("Vegetarian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99);
            addItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99);
            addItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.29);
            addItem("Hotdog", "A hot dog, with saurkraut, relish, onions, topped with cheese", false, 3.05);
        }              

        public void addItem(string name, string descrition, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, descrition, vegetarian, price);
            if (numberOfItems >= MAX_ITEMS)
            { 
                Console.WriteLine("Sorry, menu is full. Can't add item to menu");
            }
            else
            {
                menuItems[numberOfItems] = menuItem;
                numberOfItems++;
            }
        }

        public override void Add(MenuComponent d)
        {
            menuComponents.Add(d);
        }

        public override void Remove(MenuComponent d)
        {
            menuComponents.Remove(d);
        }
        public Interface.Iterator createIterator()
        {
            return new DinerMenuIterator(menuItems);
        }

        public override void Print(int indent)
        {
           MenuPrinter.Print(createIterator(), menuComponents);          
        }
    }
}
