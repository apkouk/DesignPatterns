using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Iterator.Interface;


namespace DesignPatterns.Iterator.Iterators
{
    public class DinerMenuIterator : Interface.Iterator
    {
        MenuItem[] items;
        int position = 0;

        public DinerMenuIterator(MenuItem[] items)
        {
            this.items = items;
        }

        public bool hasNext()
        {
            if (position >= items.Length || items[position] == null)
                return false;
            return true;
        }

        public object next()
        {
            MenuItem menuItem = items[position];
            position++;
            return menuItem;
        }
    }
}
