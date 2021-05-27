using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; //ses kütüphanesini ekledik

namespace TrafikLambası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }

        int sayac=0;

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString();

            //şarkıları burada yükledim
            SoundPlayer kirmizi = new SoundPlayer();
            SoundPlayer sari = new SoundPlayer();
            SoundPlayer yesil = new SoundPlayer();
            string yol1 = Application.StartupPath + "\\kirmizi.wav";
            string yol2 = Application.StartupPath + "\\sari.wav";
            string yol3 = Application.StartupPath + "\\yesil.wav";
            kirmizi.SoundLocation = yol1;
            sari.SoundLocation = yol2;
            yesil.SoundLocation = yol3;       
           

            if ( sayac == 1 || sayac == 30 )
            {
                RedPic.Visible = true;
                kirmizi.Play();
                button4.Visible = false;
            }

            if (sayac == 61 || sayac == 90)
            {
                kirmizi.Stop();
                RedPic.Visible = false;
                sari.Play();
                YellowPic.Visible = true;
                button5.Visible = true;

            }
            if (sayac == 91 || sayac == 130)
            {               
                sari.Stop();
                YellowPic.Visible = false;
                yesil.Play();
                GreenPic.Visible = true;
                
            }
            if (sayac == 131 || sayac == 161)
            {
                yesil.Stop();
                GreenPic.Visible = false;
                sari.Play();
                YellowPic.Visible = true;
            }

            if (sayac > 161)
            {
                sayac = 0;
                sari.Stop();
                YellowPic.Visible = false;
                RedPic.Visible = true;
                timer1.Stop();
                button4.Visible = true;
                button5.Visible = false;
            }
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            sayac = 0;           
            YellowPic.Visible = false;
            GreenPic.Visible = false;
            RedPic.Visible = true;
            timer1.Stop();
            button4.Visible = true;
            button5.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
