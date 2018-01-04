using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade.Devices
{
    public class TheatherLights
    {
        public TheatherLights()
        {

        }

        internal void dim(int v)
        {
            Console.WriteLine("Dimnishing ligths to level " + v);
        }

        internal void on()
        {
            Console.WriteLine("Lights are on");
        }
    }
}
