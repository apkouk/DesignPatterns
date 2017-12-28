using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DesignPatterns.CommandPattern.Interfaces;
using DesignPatterns.CommandPattern.Devices;

namespace DesignPatterns.CommandPattern.Commands.Stereo
{
    public class StereoOff : Command
    {
        StereoDev stereo;

        public StereoOff()
        {
        }

        public StereoOff(StereoDev stereo)
        {
            this.stereo = stereo;
        }

        public void execute()
        {
            stereo.off();
        }

        public void undo()
        {
            stereo.on();
        }
    }
}
