using DesignPatterns.ObserverPattern.Interfaces;
using System;

namespace DesignPatterns.ObserverPattern.Classes
{
    public class StatisticsDisplay : IDisplayElement, IObserver
    {
        private int num1;
        private int num2;
        private int num3;
        private ISubject subject;

        public StatisticsDisplay(ISubject _subject)
        {
            subject = _subject;
            subject.registerObserver(this);
        }

        public void display()
        {
            Console.WriteLine("StatisticsDisplay => Num1 is " + num1 + " // Num2 is " + num2 + " // Num3 is " + num3);
        }

        public void Update(IWeatherDataMeasurement _weatherDataMeasurement)
        {
            num1 = _weatherDataMeasurement.GetNum1();
            num2 = _weatherDataMeasurement.GetNum2();
            num3 = _weatherDataMeasurement.GetNum3();
            display();
        }

        public void ExitObserver()
        {
            subject.removeObserver(this);
        }
    }
}
