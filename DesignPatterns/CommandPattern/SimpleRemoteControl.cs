using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.CommandPattern.Commands;
using DesignPatterns.CommandPattern.Interfaces;

namespace DesignPatterns.CommandPattern
{
    public class SimpleRemoteControl
    {
        Command[] onCommands;
        Command[] offCommands;
        Command undoCommand;

        public SimpleRemoteControl() {

            onCommands = new Command[7];
            offCommands = new Command[7];

            NoCommand noCommand = new NoCommand();

            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
        }

        public void setCommand(int slot, Command onCommand, Command offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void onButtonWasPressed(int slot)
        {
            onCommands[slot].execute();
            undoCommand = onCommands[slot];
        }
        public void offButtonWasPressed(int slot)
        {
            offCommands[slot].execute();
            undoCommand = offCommands[slot];
        }

        public void undoButtonWasPressed()
        {
            undoCommand.undo();
        }

        public void slotsBrief()
        {
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("SLOTS ON: " + onCommands[i].GetType() + "    SLOT OFF: " + offCommands[i].GetType());                   
            }
        }


    }
}
