using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPatternExc.Interfaces
{
    public interface IDataElementConfiguration
    {
        string getDataOrigin();        
        void saveData(string data);
    }
}
