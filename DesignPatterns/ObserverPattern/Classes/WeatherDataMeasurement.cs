using DesignPatterns.ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern.Classes
{
    public class WeatherDataMeasurement : IWeatherDataMeasurement
    {
        public int Num1 { get; set; }        
        public int Num2 { get; set; }
        public int Num3 { get; set; }

        public WeatherDataMeasurement(int _num1, int _num2, int _num3)
        {
            Num1 = _num1;
            Num2 = _num2;
            Num3 = _num3;
        }

        public int GetNum1()
        {
            return Num1;
        }

        public int GetNum2()
        {
            return Num2;
        }

        public int GetNum3()
        {
            return Num3;
        }

        public void displayMeasurements()
        {
            Console.WriteLine("WeatherDataMeasurement => Num1 is " + Num1 + " // Num2 is " + Num2 + " // Num3 is " + Num3);
        }
    }
}
