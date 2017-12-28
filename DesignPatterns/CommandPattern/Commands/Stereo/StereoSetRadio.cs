using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.CommandPattern.Devices;
using DesignPatterns.CommandPattern.Interfaces;

namespace DesignPatterns.CommandPattern.Commands.Stereo
{
    public class StereoSetRadio : Command
    {
        StereoDev stereo;

        public StereoSetRadio()
        {
        }

        public StereoSetRadio(StereoDev stereo)
        {
            this.stereo = stereo;
        }

        public void execute()
        {
            stereo.setRadio();
        }

        public void undo()
        {
           
        }
    }
}
