using DesignPatterns.ObserverPatternExc.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPatternExc.Classes
{
    public class DataObservers : ISubject
    {
        private List<IObserver> observersList = new List<IObserver>();
        private ISubject subject;
             

        public void notifyObservers()
        {
            foreach (IObserver observer in observersList)
            {
                observer.update();
            }
        }

        public void registerObserver(IObserver _observer)
        {
            observersList.Add(_observer);
        }

        public void removeObserver(IObserver _observer)
        {
            int observerIndex = observersList.IndexOf(_observer);
            observersList.RemoveAt(observerIndex);
        }
    }
}
