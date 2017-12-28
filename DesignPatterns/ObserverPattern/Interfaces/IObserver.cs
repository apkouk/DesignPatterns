using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern.Interfaces
{
    public interface IObserver
    {
        void Update(IWeatherDataMeasurement _weatherDataMeasurement);
        void ExitObserver();
    }
}
