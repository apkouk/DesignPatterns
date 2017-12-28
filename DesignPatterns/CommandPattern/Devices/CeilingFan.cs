using DesignPatterns.CommandPattern.Commands.CeilingFan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern.Devices
{
    public class CeilingFanDev
    {
        string location;
        int speed;
        int prevSpeed;

        public CeilingFanDev(string location)
        {
            this.location = location;          
        }


        public void setSpeed(int speed)
        {
            this.speed = speed;
        }
        public void high()
        {
            SetPrevSpeed();          
            speed = CeilingFanState.HIGH;
            Console.WriteLine("Ceiling fan HIGH");
        }
        public void medium()
        {
            SetPrevSpeed();
            speed = CeilingFanState.MEDIUM;
            Console.WriteLine("Ceiling fan MEDIUM");
        }
        public void low()
        {
            SetPrevSpeed();
            speed = CeilingFanState.LOW;
            Console.WriteLine("Ceiling fan LOW");
        }       
        public void off()
        {
              SetPrevSpeed();   
            speed = CeilingFanState.OFF;
            Console.WriteLine("Ceiling fan OFF");
        }
        internal void on()
        {
            speed = prevSpeed;
            Console.WriteLine("Ceiling fan ON");
        }
        public int getSpeed()
        {  
            return speed;
        }
        private void SetPrevSpeed()
        {
            prevSpeed = CeilingFanState.GetPrevState(speed);
        }
    }
}
