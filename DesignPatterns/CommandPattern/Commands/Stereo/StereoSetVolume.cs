using DesignPatterns.CommandPattern.Devices;
using DesignPatterns.CommandPattern.Interfaces;

namespace DesignPatterns.CommandPattern.Commands.Stereo
{
    public class StereoSetVolume : Command
    {
        StereoDev stereo;

        public StereoSetVolume(StereoDev stereo)
        {
            this.stereo = stereo;
        }

        public void execute()
        {
          
        }
        public void execute(int volume)
        {
            stereo.setVolume(volume);
        }

        public void undo()
        {
           
        }
    }
}
