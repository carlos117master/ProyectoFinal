using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        public static string nombreJugador;
        public Form1()
        {
            InitializeComponent();
            ReproducirMusica.Reproducir();
        }

        private void Jugar_Click(object sender, EventArgs e)
        {
            if (cuadroTexto.Text != "")
            {
                nombreJugador = cuadroTexto.Text;
                Form2 frm2 = new Form2();

                frm2.Show();
                this.Hide();
            }
            else MessageBox.Show("Elija un nombre");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
