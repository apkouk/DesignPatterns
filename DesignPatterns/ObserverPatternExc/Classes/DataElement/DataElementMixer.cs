using DesignPatterns.ObserverPatternExc.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPatternExc.Classes.DataElement
{
    public class DataElementMixer : DataElement
    {
        public IDataElementConfiguration dataOrigin;
        public IDataElementConfiguration dataDestiny;
        private string data;


        public DataElementMixer(IDataElementConfiguration _dataOrigin, IDataElementConfiguration _dataDestiny)
        {
            dataOrigin = _dataOrigin;
            dataDestiny = _dataDestiny;
        }
        public override string getData()
        {
            data = dataOrigin.getDataOrigin();
            Console.WriteLine("MIXER: Getting data from origin");
            return data;
        }

        public override void save()
        {          
            dataDestiny.saveData(data);
            Console.WriteLine("MIXER: Saving data in destiny");
        }
    }
}
