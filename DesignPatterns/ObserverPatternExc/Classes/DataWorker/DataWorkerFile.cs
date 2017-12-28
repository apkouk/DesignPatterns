
using DesignPatterns.ObserverPatternExc.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPatternExc.Classes.DataWorker
{
    public class DataWorkerFile : IDataWorker, IObserver
    {
        IDataElement dataElement;
        ISubject subject;

        public DataWorkerFile(IDataElement _dataElement, ISubject _subject)
        {
            subject = _subject;
            subject.registerObserver(this);
            dataElement = _dataElement;
        }     

        public string readData()
        {
            return dataElement.getData();
        }

        public void saveData()
        {
            dataElement.save();
        }

        public void update()
        {
            dataElement.save();
        }
    }
}
