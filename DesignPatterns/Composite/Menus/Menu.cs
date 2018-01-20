using DesignPatterns.Composite.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite.Menus
{
    public class Menu : MenuComponent
    {
        ArrayList menuComponents = new ArrayList();
        string name;
        string description;

        public Menu(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public override void Add(MenuComponent d)
        {
            menuComponents.Add(d);
        }

        public override void Print(int indent)
        {           
            foreach (MenuComponent item in menuComponents)
            {
                item.Print(1);
            }
        }

        public override void Remove(MenuComponent d)
        {
            menuComponents.Remove(d);
        }
    }
}
