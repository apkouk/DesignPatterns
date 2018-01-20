using DesignPatterns.Composite.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class MenuItem : MenuComponent
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

        public override void Print(int indent)
        {
            string veg = string.Empty;
            if (IsVegetarian())
                veg = "(V)";

            string menuOut = Name + ", " + Price + " -- " + description + " -- " + veg;
            Console.WriteLine(menuOut);

        }
        public override void Add(MenuComponent d)
        {
            Console.WriteLine("Not applicable in Menu Item");
        }
        public override void Remove(MenuComponent d)
        {
            Console.WriteLine("Not applicable in Menu Item");
        }


    }
}
