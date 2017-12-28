using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.CommandPattern.Devices;
using DesignPatterns.CommandPattern.Interfaces;

namespace DesignPatterns.CommandPattern.Commands.Stereo
{
    public class StereoSetCD : Command
    {
        StereoDev stereo;

        public StereoSetCD()
        {
        }

        public StereoSetCD(StereoDev stereo)
        {
            this.stereo = stereo;
        }

        public void execute()
        {
            stereo.setCD();
        }

        public void undo()
        {
            
        }
    }
}
