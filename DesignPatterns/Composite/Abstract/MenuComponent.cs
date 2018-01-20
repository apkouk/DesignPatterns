using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Iterator.Menus;

namespace DesignPatterns.Composite.Abstract
{
    public abstract class MenuComponent
    {
        public MenuComponent()
        {

        }

        public abstract void Add(MenuComponent d);
        public abstract void Remove(MenuComponent d);
        public abstract void Print(int indent);      
    }
}
