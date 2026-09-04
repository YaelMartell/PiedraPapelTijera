using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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
            Form2.musica();
           
        }

        int op = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.PiedraAura;
            op = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.PapelAura;
            op = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.TijeraAura;
            op = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
