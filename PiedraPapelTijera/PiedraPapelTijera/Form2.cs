using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace PiedraPapelTijera
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            try {
                SoundPlayer sonido= new SoundPlayer(Properties.Resources.Ogryzek___AURA__Official_Music_Video__mp3);
                sonido.PlayLooping(); 
            } catch { }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1=new Form1();
            this.SetVisibleCore(false);
            f1.ShowDialog();
            this.SetVisibleCore(true);
        }
    }
}
