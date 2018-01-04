using DesignPatterns.ObjectAdapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObjectAdapter.Classes
{
    public class WildTurkey : Turkey
    {
        public void fly()
        {
            Console.WriteLine("Wild Turkey is flying");
        }

        public void gobble()
        {
            Console.WriteLine("Wild Turkey is gobbling");
        }
    }
}
