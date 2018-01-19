using DesignPatterns.Iterator.Interface;
using DesignPatterns.Iterator.Iterators;
using System.Collections;


namespace DesignPatterns.Iterator.Menus
{
    public class PancakeHouseMenu : Menu
    {
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
    }
}
