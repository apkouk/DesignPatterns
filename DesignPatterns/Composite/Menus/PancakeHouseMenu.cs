using DesignPatterns.Composite.Abstract;
using DesignPatterns.Composite.Interface;
using DesignPatterns.Composite.Iterators;
using System;
using System.Collections;


namespace DesignPatterns.Composite.Menus
{
    public class PancakeHouseMenu : MenuComponent
    {
        ArrayList menuComponents = new ArrayList();
        ArrayList menuItems;

        public PancakeHouseMenu()
        {
            menuItems = new ArrayList();
            addItem("K&G's Pancake Breakfast", "Pancake with scrambled eggs, and toast", true, 2.99);
            addItem("Regular Pancake Breakfast", "Pancakes with fried eggs", false, 2.99);
            addItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49);
            addItem("Waffles", "Waffles, with your choice of blueberries or strawberries", true, 3.59);
        }

        public void addItem(string name, string descrition, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, descrition, vegetarian, price);
            menuItems.Add(menuItem);
        }

        public Interface.Iterator createIterator()
        {
            return new PancakeHouseMenuIterator(menuItems);
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
