using DesignPatterns.CommandPattern.Devices;
using DesignPatterns.CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern.Commands.CeilingFan
{
    public class CeilingGetSpeed : Command
    {
        CeilingFanDev ceilingFan;
    

        public CeilingGetSpeed(CeilingFanDev ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }        

        public void execute()
        {
            ceilingFan.getSpeed();
        }

        public void undo()
        {
          
        }
    }
}
