using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade.Devices
{
    public class Projector
    {
        public Projector()
        {

        }

        internal void wideScreenMode()
        {
            Console.WriteLine("Setting projector in wide screen mode");
        }

        internal void on()
        {
            Console.WriteLine("Projector is on");
        }

        internal void off()
        {
            Console.WriteLine("Projector is off");
        }
    }
}
