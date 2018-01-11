using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template.NoHook
{
    public class Tea : CaffeineBeverage
    {
        public Tea()
        {
        }

        internal override void addCondiments()
        {
            Console.WriteLine("Adding condiments in tea.");
        }

        internal override void brew()
        {
            Console.WriteLine("Brewing tea.");
        }
    }
}
