using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Iterator.Menus;
using DesignPatterns.Composite.Interface;
using DesignPatterns.Composite.Abstract;

namespace DesignPatterns.Composite
{
    public class Waitress
    {
        MenuComponent allMenus;

        public Waitress(MenuComponent allMenus)
        {
            this.allMenus = allMenus;
        }

        public void printMenu()
        {
            Console.WriteLine("ALL MENUS");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");

            allMenus.Print(1);
        }
    }
}
