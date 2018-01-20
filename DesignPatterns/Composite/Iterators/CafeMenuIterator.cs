using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Iterator.Interface;


namespace DesignPatterns.Composite.Iterators
{
    public class CafeMenuIterator : Interface.Iterator
    {
        Dictionary<string, MenuItem> items = new Dictionary<string, MenuItem>();
        int position = 0;


        public CafeMenuIterator(Dictionary<string, MenuItem> items)
        {
            this.items = items;
        }

        public bool hasNext()
        {
            if (position >= items.Count || items.ElementAt(position).Key == null)
                return false;
            return true;
        }

        public object next()
        {
            MenuItem menuItem = items.ElementAt(position).Value;                
            position++;
            return menuItem;
        }
    }
}
