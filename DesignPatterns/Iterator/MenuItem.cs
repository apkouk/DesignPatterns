using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    public class MenuItem
    {
        string name;
        string description;
        bool vegetarian;
        double price;

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            this.name = name;
            this.description = description;
            this.vegetarian = vegetarian;
            this.price = price;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public bool Vegetarian
        {
            get { return vegetarian; }
            set { vegetarian = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public bool IsVegetarian()
        {
            return vegetarian;
        }
    }
}
