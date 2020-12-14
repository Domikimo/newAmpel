using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmpelmodellDesign
{
    public class Auto
    {
        public enum Farbe { rot = 0, rotgelb, gelb, gruen };
        public enum FarbeFussgaenger { rot = 0, gruen = 1 };
        public Auto()
        {
        }

        public Farbe Autoschalten(Farbe aktuelleFarbe)
        {
            switch (aktuelleFarbe)
            {
                case Farbe.rot:
                    aktuelleFarbe = Farbe.rotgelb;
                    break;
                case Farbe.rotgelb:
                    aktuelleFarbe = Farbe.gruen;
                    break;
                case Farbe.gruen:
                    aktuelleFarbe = Farbe.gelb;
                    break;
                case Farbe.gelb:
                    aktuelleFarbe = Farbe.rot;
                    break;

            }
            return aktuelleFarbe;
        }

        public FarbeFussgaenger FussgaengerSchalten(FarbeFussgaenger aktuelleFarbe)
        {

            switch (aktuelleFarbe)
            {
                case FarbeFussgaenger.rot:
                    aktuelleFarbe = FarbeFussgaenger.gruen;
                    break;
                case FarbeFussgaenger.gruen:
                    aktuelleFarbe = FarbeFussgaenger.rot;
                    break;
            }
            return aktuelleFarbe;
        }

        //CODE vorheriges Programm



    }
}