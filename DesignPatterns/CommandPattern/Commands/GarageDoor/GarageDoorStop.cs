using DesignPatterns.CommandPattern.Devices;
using DesignPatterns.CommandPattern.Interfaces;

namespace DesignPatterns.CommandPattern.Commands.GarageDoor
{
    public class GarageDoorStop : Command
    {
        GarageDoorDev garageDoor;

        public GarageDoorStop()
        {
        }

        public GarageDoorStop(GarageDoorDev garageDoor)
        {
            this.garageDoor = garageDoor;
        }     

        public void execute()
        {
            garageDoor.stop();
        }

        public void undo()
        {
           
        }
    }
}
