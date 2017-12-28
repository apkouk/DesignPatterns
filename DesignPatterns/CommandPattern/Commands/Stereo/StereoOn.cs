using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.CommandPattern.Devices;
using DesignPatterns.CommandPattern.Interfaces;

namespace DesignPatterns.CommandPattern.Commands.Stereo
{
    public class StereoOn : Command
    {
        StereoDev stereo;

        public StereoOn()
        {
        }

        public StereoOn(StereoDev stereo)
        {
            this.stereo = stereo;
        }

        public void execute()
        {
            stereo.on();
            stereo.setCD();
            stereo.setVolume(11);
        }

        public void undo()
        {
            stereo.off();
        }
    }
}
