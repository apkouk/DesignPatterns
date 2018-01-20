using DesignPatterns.Composite.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class MenuPrinter
    {
        public static void Print(Interface.Iterator iterator, ArrayList menuComponents)
        {
            while (iterator.hasNext())
            {
                MenuItem menuItem = (MenuItem)iterator.next();
                menuItem.Print(1);
                //Console.WriteLine(menuItem.Name + ", " + menuItem.Price + " -- " + menuItem.Description);
            }
            if (menuComponents.Count > 0)
            {
                foreach (MenuComponent item in menuComponents)
                {
                    item.Print(1);
                }
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");
        }
    }
}

