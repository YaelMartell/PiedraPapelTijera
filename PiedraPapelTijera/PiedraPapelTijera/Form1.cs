using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiedraPapelTijera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int op = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2026_08_31_083122;
            op = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2026_08_31_083103;
            op = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2026_08_31_083117;
            op = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (op == 1)
            {
                Properties.Settings.Default.contPi++;
                Properties.Settings.Default.Save();
            }
            else if (op == 2)
            {
                Properties.Settings.Default.contPa++;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.contTi++;
                Properties.Settings.Default.Save();
            }

            Properties.Settings.Default.totDat++;
            Properties.Settings.Default.Save();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
