using DesignPatterns.CommandPattern.Devices;
using DesignPatterns.CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern.Commands.CeilingFan
{
    public class CeilingFanOn : Command
    {
        CeilingFanDev ceilingFan;
        int prevSpeed;

        public CeilingFanOn()
        {
        }

        public CeilingFanOn(CeilingFanDev ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }        

        public void execute()
        {
            prevSpeed = ceilingFan.getSpeed();
            ceilingFan.on();
        }

        public void undo()
        {
            ceilingFan.off();
        }
    }
}
