using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template.NoHook
{
    public class Coffee : CaffeineBeverage
    {
        public Coffee()
        {
        }

        internal override void brew()
        {
            Console.WriteLine("Brewing some delicious coffee...");
        }

        internal override void addCondiments()
        {
            Console.WriteLine("Adding condiments in coffee.");
        }
    }
}
