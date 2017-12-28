using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern.Devices
{
    public class StereoDev
    {
        string location;

        public StereoDev(string location) {
            this.location = location;
        }

        public void on()
        {
            Console.WriteLine("Stereo is on");
        }
        public void off()
        {
            Console.WriteLine("Stereo is off");
        }
        public void setCD()
        {
            Console.WriteLine("CD is in");
        }

        internal void setRadio()
        {
            Console.WriteLine("Radio is on");
        }

        internal void setDVD()
        {
            Console.WriteLine("DVD inserted");
        }

        public void setVolume(int volume)
        {
            
            Console.WriteLine("Stereo volume is " + volume);
        }
    }
}
