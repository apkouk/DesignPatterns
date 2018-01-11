using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template.NoHook
{
    public class CoffeeHook : CaffeineBeverageHook
    {
        public CoffeeHook()
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

        public override bool CustomerWantsCondiment()
        {
            String answer = getUserInput();

            if (answer.Contains("y"))
                return true;
            return false;
        }

        private string getUserInput()
        {
            Console.WriteLine("Would yuo like to add a condiment?");
            string input = Console.ReadLine();
            return input;
        }
    }
}
