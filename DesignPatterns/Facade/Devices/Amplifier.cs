using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade.Devices
{
    public class Amplifier
    {
        public Amplifier()
        {

        }

        internal void on()
        {
            Console.WriteLine("Amplifier is on");
        }

        internal void setDvd(DvdPlayer dvdPlayer)
        {
            Console.WriteLine("Dvd set in dvd player");
        }

        internal void setSurroundSound()
        {
            Console.WriteLine("Surround sound is on");
        }

        internal void setVolume(int v)
        {
            Console.WriteLine("Setting amplifier volume to level " + v);
        }

        internal void off()
        {
            Console.WriteLine("Amplifier is off");
        }
    }
}
