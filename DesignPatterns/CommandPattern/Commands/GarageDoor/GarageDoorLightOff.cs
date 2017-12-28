using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.CommandPattern.Devices;
using DesignPatterns.CommandPattern.Interfaces;

namespace DesignPatterns.CommandPattern.Commands.GarageDoor
{
    public class GarageDoorLightOff : Command
    {
        GarageDoorDev garageDoor;

        public GarageDoorLightOff()
        {
        }

        public GarageDoorLightOff(GarageDoorDev garageDoor)
        {
            this.garageDoor = garageDoor;
        }     

        public void execute()
        {
            garageDoor.lightOff();
        }

        public void undo()
        {
            garageDoor.lightOn();
        }
    }
}
