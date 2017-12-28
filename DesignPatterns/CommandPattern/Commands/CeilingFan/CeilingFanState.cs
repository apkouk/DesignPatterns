using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern.Commands.CeilingFan
{
    public class CeilingFanState
    {
        public static int HIGH = 3;
        public static int MEDIUM = 2;
        public static int LOW = 1;
        public static int OFF = 0;

        public CeilingFanState() { }

        public static int GetPrevState(int prevState)
        {
            switch (prevState)
            {
                case 3:
                    return HIGH;
                case 2:
                    return MEDIUM;
                case 1:
                    return LOW;
                case 0:
                    return OFF;
                default:
                    break;                    
            }
            return 0;
        }

        internal static string GetSpeedState(int prevState)
        {
            switch (prevState)
            {
                case 3:
                    return "Ceiling fan HIGH";
                case 2:
                    return "Ceiling fan MEDIUM";
                case 1:
                    return "Ceiling fan LOW"; 
                case 0:
                    return "Ceiling fan OFF";
                default:
                    break;
            }
            return string.Empty;
        }
    }
}
