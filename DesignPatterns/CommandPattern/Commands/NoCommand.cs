using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.CommandPattern.Interfaces;

namespace DesignPatterns.CommandPattern.Commands
{
    public class NoCommand : Command
    {
        public NoCommand() { }

        public void execute()
        {
            Console.WriteLine("Command not defined");
        }

        public void undo()
        {
           
        }
    }
}
