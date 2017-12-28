using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.CommandPattern.Devices;
using DesignPatterns.CommandPattern.Interfaces;

namespace DesignPatterns.CommandPattern.Commands.GarageDoor
{
    public class GarageDoorLightOn : Command
    {
        GarageDoorDev garageDoor;

        public GarageDoorLightOn(GarageDoorDev garageDoor)
        {
            this.garageDoor = garageDoor;
        }     

        public void execute()
        {
            garageDoor.lightOn();
        }

        public void undo()
        {
            garageDoor.lightOff();
        }
    }
}
