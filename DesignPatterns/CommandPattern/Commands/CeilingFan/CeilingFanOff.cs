using DesignPatterns.CommandPattern.Devices;
using DesignPatterns.CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern.Commands.CeilingFan
{
    public class CeilingFanOff : Command
    {
        CeilingFanDev ceilingFan;
        int prevSpeed;

        public CeilingFanOff()
        {
        }

        public CeilingFanOff(CeilingFanDev ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }        

        public void execute()
        {
            prevSpeed = ceilingFan.getSpeed();
            ceilingFan.off();
        }

        public void undo()
        {           
            ceilingFan.on();
        }
    }
}
