using DesignPatterns.ObserverPatternExc.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPatternExc.Classes.DataElementConfiguration
{
    class DataElementConfigurationFile : IDataElementConfiguration
    {
        string IDataElementConfiguration.getDataOrigin()
        {
            Console.WriteLine("Data from file");
            return "Data from file";
        }

        public void saveData(string data)
        {
            Console.WriteLine("Saving in file");
        }

    }
}
