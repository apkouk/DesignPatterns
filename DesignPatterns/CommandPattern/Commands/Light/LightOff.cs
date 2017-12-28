using DesignPatterns.CommandPattern.Devices;
using DesignPatterns.CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesignPatterns.CommandPattern.Commands.Light
{
    public class LightOff : Command
    {
        LightDev light;

        public LightOff()
        {
        }

        public LightOff(LightDev light)
        {
            this.light = light;
        }

        public void execute()
        {
            light.off();
        }

        public void undo()
        {
            light.on();
        }
    }
}
