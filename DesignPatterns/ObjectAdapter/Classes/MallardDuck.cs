using DesignPatterns.ObjectAdapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObjectAdapter.Classes
{
    public class MallardDuck : Duck
    {
        public void fly()
        {
            Console.WriteLine("Mallard Duck is flying");
        }

        public void quack()
        {
            Console.WriteLine("Mallard Duck is quacking");
        }
    }
}
