using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern.Interfaces
{
    public interface IWeatherDataMeasurement
    {
        int GetNum1();
        int GetNum2();
        int GetNum3();
        void displayMeasurements();
    }
}
