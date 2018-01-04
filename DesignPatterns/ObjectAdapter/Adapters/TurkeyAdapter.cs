using DesignPatterns.ObjectAdapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObjectAdapter.Adapters
{
    public class TurkeyAdapter : Duck
    {
        Turkey turkey;

        public TurkeyAdapter(Turkey turkey)
        {
            this.turkey = turkey;
        }

        public void fly()
        {
            turkey.fly();
        }

        public void quack()
        {
            turkey.gobble();
        }
    }
}
