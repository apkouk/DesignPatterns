using DesignPatterns.ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern.Classes
{
    public class WeatherData : ISubject
    {
        public List<IObserver> observersList = new List<IObserver>();
        public IWeatherDataMeasurement weatherDataMeasurement;

        int num1;
        int num2;
        int num3;



        public void notifyObservers()
        {
            foreach (IObserver item in observersList)
            {
                weatherDataMeasurement = new WeatherDataMeasurement(num1, num2, num3);
                item.Update(weatherDataMeasurement);
            }
        }      

        public void registerObserver(IObserver _observer)
        {
            observersList.Add(_observer);
            notifyObservers();
        }

        public void setMeasurement(int _num1, int _num2, int _num3)
        {
            num1 = _num1;
            num2 = _num2;
            num3 = _num3;
            notifyObservers();
        }

        public void removeObserver(IObserver _observer)
        {
            int observerIndex = observersList.IndexOf(_observer);
            observersList.RemoveAt(observerIndex);
        }

        public IWeatherDataMeasurement getCurrentMeasurement()
        {
            return weatherDataMeasurement;
        }

        public void getMeasurements()
        {
            notifyObservers();   
        }
    }
}
