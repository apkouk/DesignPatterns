using DesignPatterns.CommandPattern.Devices;
using DesignPatterns.CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern.Commands.CeilingFan
{
    public class CeilingFanMedium : Command
    {
        CeilingFanDev ceilingFan;
        int prevSpeed;

        public CeilingFanMedium(CeilingFanDev ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }        

        public void execute()
        {
            prevSpeed = ceilingFan.getSpeed();
            ceilingFan.medium();                    
        }

        public void undo()
        {
            ceilingFan.setSpeed(CeilingFanState.GetPrevState(prevSpeed));
            Console.WriteLine(CeilingFanState.GetSpeedState(ceilingFan.getSpeed()));
        }
    }
}
