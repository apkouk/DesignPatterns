using DesignPatterns.CommandPattern.Devices;
using DesignPatterns.CommandPattern.Interfaces;

namespace DesignPatterns.CommandPattern.Commands.GarageDoor
{
    public class GarageDoorUp : Command
    {
        GarageDoorDev garageDoor;

        public GarageDoorUp()
        {
        }

        public GarageDoorUp(GarageDoorDev garageDoor)
        {
            this.garageDoor = garageDoor;
        }     

        public void execute()
        {
            garageDoor.up();
        }

        public void undo()
        {
            garageDoor.down();
        }
    }
}
