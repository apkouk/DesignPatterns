using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPatternExc.Interfaces
{
    public interface ISubject
    {
        void registerObserver(IObserver _observer);
        void removeObserver(IObserver _observer);
        void notifyObservers();
    }
}
