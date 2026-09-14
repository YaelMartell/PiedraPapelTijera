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
using System.IO;

namespace PiedraPapelTijera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Form2.musica();
           
        }
        // Configuramos los puntos iniciales para cada opción
        // Todos empiezan con 10 puntos (33.3% de probabilidad para cada uno)
public static string rutaArchivo = "datos.txt";
double puntosPiedra = 10.0;
double puntosPapel = 10.0;
double puntosTijera = 10.0;

        private Random r= new Random();
int victoriasUsuario = 0;
int victoriasMaquina = 0;
int empates = 0;

string op= string.Empty;

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.PiedraAura;
            op = "piedra";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.PapelAura;
            op = "papel";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.TijeraAura;
            op = "tijera";
        }
        double numrand()
        {
            return r.Next(0, 100);
        }
        private void button4_Click(object sender, EventArgs e)
        {

        double totalPuntos = puntosPiedra + puntosPapel + puntosTijera;

            // Generamos un decimal al azar entre 0.0 y 1.0
            //double probabilidadAleatoria = Random.Shared.NextDouble();
            double probabilidadAleatoria = numrand();
            Console.WriteLine("Numero escojido: "+ probabilidadAleatoria);
            double limitePiedra = (puntosPiedra / totalPuntos)*100;
        double limitePapel = limitePiedra + (puntosPapel / totalPuntos)*100;

            // La máquina decide según dónde caiga el número al azar
        string opcionMaquina;
        if (probabilidadAleatoria < limitePiedra)
        {
            opcionMaquina = "piedra";
                pictureBox2.Image = Properties.Resources.PiedraAura;
            }
        else if (probabilidadAleatoria < limitePapel)
        {
           opcionMaquina = "papel";
                pictureBox2.Image = Properties.Resources.PapelAura;
            }
        else
        {
            opcionMaquina = "tijera";
                pictureBox2.Image = Properties.Resources.TijeraAura;
            }
            Console.WriteLine("Elecion maquina: "+opcionMaquina);
            if (op == opcionMaquina)
    {
        Console.WriteLine("¡Es un empate!");
        empates++;
        pictureBox3.Image = Properties.Resources.EMPATE;
    }
    else if ((opcionMaquina == "piedra" && op == "tijera") ||
             (opcionMaquina == "papel" && op == "piedra") ||
             (opcionMaquina == "tijera" && op == "papel"))
    {
        Console.WriteLine("¡Ganó la máquina!");
        victoriasMaquina++;
                pictureBox3.Image = Properties.Resources.PERDISTE;

        // Le damos más puntos a la opción que hizo ganar
        if (opcionMaquina == "piedra" && puntosPiedra<(puntosTijera+puntosPapel)) puntosPiedra += 5.0;
        if (opcionMaquina == "papel" && puntosPapel < (puntosTijera + puntosPiedra)) puntosPapel += 5.0;
        if (opcionMaquina == "tijera" && puntosTijera < (puntosPiedra + puntosPapel)) puntosTijera += 5.0;

        Console.WriteLine($"La máquina mejoró su preferencia por: {opcionMaquina}");
    }
            else
            {
                Console.WriteLine("¡Ganaste tú!");
                victoriasUsuario++;
                pictureBox3.Image= Properties.Resources.GANASTE;

                // Si la máquina pierde, le restamos un poco de puntos a esa opción 
                // para que no la use tanto (sin dejar que baje de 1 punto)
                if (opcionMaquina == "piedra" && puntosPiedra > 1) puntosPiedra -= 2.0;
                if (opcionMaquina == "papel" && puntosPapel > 1) puntosPapel -= 2.0;
                if (opcionMaquina == "tijera" && puntosTijera > 1) puntosTijera -= 2.0;
            }
            totalPuntos = puntosPiedra + puntosPapel + puntosTijera;
            Console.WriteLine("\n--- MARCADOR ---");
            Console.WriteLine($"Tú: {victoriasUsuario} | Máquina: {victoriasMaquina} | Empates: {empates}");
            Console.WriteLine("Probabilidades actuales de la máquina:");
            Console.WriteLine($"- Piedra: {(puntosPiedra / totalPuntos*100):F1}%");
            Console.WriteLine($"- Papel: {(puntosPapel / totalPuntos*100):F1}%");
            Console.WriteLine($"- Tijera: {(puntosTijera / totalPuntos*100):F1}%");
            Console.WriteLine("----------------\n");
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
