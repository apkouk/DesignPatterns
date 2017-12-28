using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern.Devices
{
    public class LightDev
    {
        string location;

        public LightDev(string location) {
            this.location = location;
        }

        internal void on()
        {
            Console.WriteLine("Light is ON");
        }
        internal void off()
        {
            Console.WriteLine("Light is OFF");
        }
    }
}
