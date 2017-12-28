using DesignPatterns.ObserverPatternExc.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPatternExc.Classes.DataElement
{
    public class DataElementFile : DataElement
    {        
        public string data;
        IDataElementConfiguration dataElementConfiguration;

        public DataElementFile(IDataElementConfiguration _dataElementConfiguration)
        {
            dataElementConfiguration = _dataElementConfiguration;
            data = dataElementConfiguration.getDataOrigin();
        }     

        public override void save()
        {
            dataElementConfiguration.saveData(data);
        }     

        public override string getData()
        {
            Console.WriteLine(data);
            return data;
        }
    }
}
