using DesignPatterns.ObserverPatternExc.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPatternExc.Classes.DataElementConfiguration
{
    class DataElementConfigurationDB : IDataElementConfiguration
    {
        public string getDataOrigin()
        {
            Console.WriteLine("Data from database");
            return "Data from file";
        }

        public void saveData(string data)
        {
            Console.WriteLine("Saving in database");
        }
    }
}
