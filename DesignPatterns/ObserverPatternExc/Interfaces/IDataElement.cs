using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPatternExc.Interfaces
{
    public interface IDataElement
    {     
        void save();
        string getData();
    }
}
