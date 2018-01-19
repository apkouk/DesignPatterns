using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Iterator.Menus;
using DesignPatterns.Iterator.Interface;

namespace DesignPatterns.Iterator
{
    public class Waitress
    {
        Menu pancakeHouseMenu;
        Menu dinerMenu;
        Menu cafeMenu;

        public Waitress(Menu pancakeHouseMenu, Menu dinerMenu, Menu cafeMenu)
        {
            this.pancakeHouseMenu = pancakeHouseMenu;
            this.dinerMenu = dinerMenu;
            this.cafeMenu = cafeMenu;
        }

        public void printMenu()
        {
            Interface.Iterator pancakeIterator = pancakeHouseMenu.createIterator();
            Interface.Iterator dinerIterator = dinerMenu.createIterator();
            Interface.Iterator cafeIterator = cafeMenu.createIterator();

            Console.WriteLine("MENU\n----\nBREAKFAST");
            printMenu(pancakeIterator);
            Console.WriteLine("\n----\nLUNCH");
            printMenu(dinerIterator);
            Console.WriteLine("\n----\nCAFE");
            printMenu(cafeIterator);
        }

        private void printMenu(Interface.Iterator iterator)
        {
            while(iterator.hasNext())
            {
                MenuItem menuItem = (MenuItem)iterator.next();
                Console.WriteLine(menuItem.Name + ", " + menuItem.Price + " -- " + menuItem.Description);                
            }
        }
    }
}
