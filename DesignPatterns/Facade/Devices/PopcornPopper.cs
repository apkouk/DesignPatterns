using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade.Devices
{
    public class PopcornPopper
    {
        public PopcornPopper()
        {

        }

        internal void on()
        {
            Console.WriteLine("Popcorn Popper is on");
        }

        internal void pop()
        {
            Console.WriteLine("Popcorn Popper is popping like hell!");
        }

        internal void off()
        {
            Console.WriteLine("Popcorn Popper is off :(");
        }
    }
}
