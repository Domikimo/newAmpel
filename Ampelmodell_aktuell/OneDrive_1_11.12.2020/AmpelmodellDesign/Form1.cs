using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmpelmodellDesign
{
    public partial class Form1 : Form
    {
        private Auto auto;
        public Form1()
        {
            InitializeComponent();
            auto = new Auto();
        }

        public void RotSetzen()
        {
            redLamp.BackColor = Color.Red;
        }


        private void programmStarten_Click(object sender, EventArgs e)
        {
            gruenLamp.BackColor = Color.Green;
            rotFußgaenger.BackColor = Color.Red;
        }

        private void lblPress_Click(object sender, EventArgs e)
        {
            Auto.Farbe farbe = Auto.Farbe.rot;
            Auto.FarbeFussgaenger farbeFussgaenger= Auto.FarbeFussgaenger.gruen;
            do
            {
                
                switch (farbe)
                {
                    case Auto.Farbe.rot:
                        Task.Delay(5000).Wait();
                        redLamp.BackColor = Color.Red;
                        gruenLamp.BackColor = Color.White;
                        yellowLamp.BackColor = Color.White;

                        /*gruenFussgaenger.BackColor = Color.Green;
                        rotFußgaenger.BackColor = Color.White;*/
                        break;
                        
                    case Auto.Farbe.rotgelb:
                        Task.Delay(5000).Wait();
                        redLamp.BackColor = Color.Red;
                        gruenLamp.BackColor = Color.White;
                        yellowLamp.BackColor = Color.Yellow;

                        /*gruenFussgaenger.BackColor = Color.White;
                        rotFußgaenger.BackColor = Color.Red;*/

                        break;
                    case Auto.Farbe.gruen:
                        Task.Delay(5000).Wait();
                        redLamp.BackColor = Color.White;
                        gruenLamp.BackColor = Color.Green;
                        yellowLamp.BackColor = Color.White;

                        /*gruenFussgaenger.BackColor = Color.White;
                        rotFußgaenger.BackColor = Color.Red;*/

                        break;
                    case Auto.Farbe.gelb:
                        Task.Delay(5000).Wait();
                        redLamp.BackColor = Color.White;
                        gruenLamp.BackColor = Color.White;
                        yellowLamp.BackColor = Color.Yellow;

                        /*gruenFussgaenger.BackColor = Color.White;
                        rotFußgaenger.BackColor = Color.Red;*/

                        break;
                }

                switch(farbeFussgaenger)
                {
                    case Auto.FarbeFussgaenger.gruen:

                        gruenFussgaenger.BackColor = Color.Green;
                        rotFußgaenger.BackColor = Color.White;
                        break;
                    case Auto.FarbeFussgaenger.rot:
                        gruenFussgaenger.BackColor = Color.Red;
                        rotFußgaenger.BackColor = Color.White;
                        break;
                }

                farbe = auto.Autoschalten(farbe);
                farbeFussgaenger = auto.FussgaengerSchalten(farbeFussgaenger);

            } while (farbe != Auto.Farbe.rot && farbeFussgaenger != Auto.FarbeFussgaenger.gruen);

            redLamp.BackColor = Color.Red;
            gruenFussgaenger.BackColor = Color.Green;
        }

        //Reset Button
        private void button1_Click(object sender, EventArgs e)
        {
            redLamp.BackColor = Color.White;
            gruenLamp.BackColor = Color.White;
            yellowLamp.BackColor = Color.White;
            gruenFussgaenger.BackColor = Color.White;
            rotFußgaenger.BackColor = Color.White;
        }

        /*//Ampelauto Farben
            if (zustand == "rot")
            {
                redLamp.BackColor = Color.Red;
            }

            if (zustand == "gelb")
            {
                yellowLamp.BackColor = Color.Yellow;
            }

            if (zustand == "rotgelb")
            {
                yellowLamp.BackColor = Color.Yellow;
                redLamp.BackColor = Color.Red;
            }

            if (zustand == "gruen")
            {
                gruenLamp.BackColor = Color.Green;
            }

            //Ampelfussgaenger Farben
            if (zustandFußgaenger == "rot")
            {
                rotFußgaenger.BackColor = Color.Red;
            }

            if (zustandFußgaenger == "gruen")
            {
                gruenFussgaenger.BackColor = Color.Green;
            }*/


        private void gruenLamp_TextChanged(object sender, EventArgs e)
        {
        }

        private void yellowLamp_TextChanged(object sender, EventArgs e)
        {
        }

        private void redLamp_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }

}

