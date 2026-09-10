using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;

namespace PiedraPapelTijera
{

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            musica();
        }
        public static SoundPlayer sonido = new SoundPlayer(Properties.Resources.Ogryzek___AURA__Official_Music_Video__mp3);
        public static void musica()
        {
            try
            {
                sonido.PlayLooping();
            }
            catch
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            //sonido.Stop();
            this.SetVisibleCore(false);
            f1.ShowDialog();
            this.SetVisibleCore(true);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
    public static class Globals
    {
       
    }
}
