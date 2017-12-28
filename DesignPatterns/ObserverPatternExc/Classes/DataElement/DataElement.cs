using DesignPatterns.ObserverPatternExc.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPatternExc.Classes.DataElement
{
    public abstract class DataElement : IDataElement
    {
        public abstract void save();
        public abstract string getData();
    }
}
