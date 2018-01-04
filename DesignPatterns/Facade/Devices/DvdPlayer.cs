using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade.Devices
{
    public class DvdPlayer
    {
        public DvdPlayer()
        {

        }

        internal void on()
        {
            Console.WriteLine("DVD Player is on");
        }

        internal void playMovie(string movie)
        {
            Console.WriteLine("Playing movie on DVD Player: " + movie);
        }

        internal void stop()
        {
            Console.WriteLine("Stopping DVD Player");
        }

        internal void eject()
        {
            Console.WriteLine("Ejecting DVD from DVD Player");
        }

        internal void off()
        {
            Console.WriteLine("DVD PLayer is off");
        }
    }
}
