using DesignPatterns.CommandPattern.Devices;
using DesignPatterns.CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern.Commands.Light
{
    public class LightOn : Command
    {
        LightDev light;

        public LightOn()
        {
        }

        public LightOn(LightDev light)
        {
            this.light = light;
        }

        public void execute()
        {
            light.on();
        }

        public void undo()
        {
            light.off();
        }
    }
}
