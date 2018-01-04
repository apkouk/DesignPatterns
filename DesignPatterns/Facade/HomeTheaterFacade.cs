using DesignPatterns.Facade.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    public class HomeTheaterFacade
    {
        Amplifier amplifier;
        CdPlayer cdPlayer;
        DvdPlayer dvdPlayer;
        PopcornPopper popcornPopper;
        Projector projector;
        Screen screen;
        TheatherLights theatherLights;
        Tuner tuner;

        public HomeTheaterFacade(Amplifier amplifier, CdPlayer cdPlayer, DvdPlayer dvdPlayer, PopcornPopper popcornPopper, Projector projector, Screen screen, TheatherLights theatherLights, Tuner tuner)
        {
            this.amplifier = amplifier;
            this.cdPlayer = cdPlayer;
            this.dvdPlayer = dvdPlayer;
            this.popcornPopper = popcornPopper;
            this.projector = projector;
            this.screen = screen;
            this.theatherLights = theatherLights;
            this.tuner = tuner;
        }

        public void watchMovie(string movie)
        {
            Console.WriteLine("///////// STARTING MOVIE ////////////");
            popcornPopper.on();
            popcornPopper.pop();
            theatherLights.dim(10);
            screen.down();
            projector.on();
            projector.wideScreenMode();
            amplifier.on();
            amplifier.setDvd(dvdPlayer);
            amplifier.setSurroundSound();
            amplifier.setVolume(5);
            dvdPlayer.on();
            dvdPlayer.playMovie(movie);
        }

        public void endMovie()
        {
            Console.WriteLine("///////// ENDING MOVIE ////////////");
            popcornPopper.off();
            theatherLights.on();
            screen.up();
            projector.off();
            amplifier.off();
            dvdPlayer.stop();
            dvdPlayer.eject();
            dvdPlayer.off();
        }


    }
}
