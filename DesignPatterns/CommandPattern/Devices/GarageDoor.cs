using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern.Devices
{
    public class GarageDoorDev
    {
        public GarageDoorDev() { }

        public void up()
        {
            Console.WriteLine("Garage Door is open");
        }
        public void down()
        {
            Console.WriteLine("Garage Door is down");
        }
        public void stop()
        {
            Console.WriteLine("Garage Door is stopped");
        }
        public void lightOn()
        {
            Console.WriteLine("Garage Door light is on");
        }
        public void lightOff()
        {
            Console.WriteLine("Garage Door light is off");
        }
    }
}
