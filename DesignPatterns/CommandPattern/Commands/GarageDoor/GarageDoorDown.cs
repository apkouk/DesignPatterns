using DesignPatterns.CommandPattern.Devices;
using DesignPatterns.CommandPattern.Interfaces;




namespace DesignPatterns.CommandPattern.Commands.GarageDoor
{
    public class GarageDoorDown : Command
    {
        GarageDoorDev garageDoor;

        public GarageDoorDown(GarageDoorDev garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void execute()
        {
            garageDoor.down();
        }

        public void undo()
        {
            garageDoor.up();
        }
    }
}
