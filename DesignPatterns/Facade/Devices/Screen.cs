using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade.Devices
{
    public class Screen
    {
        public Screen()
        {

        }

        internal void down()
        {
            Console.WriteLine("Screen is down");
        }

        internal void up()
        {
            Console.WriteLine("Screen is up");
        }
    }
}
