using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace ProyectoFinal
{
    public partial class Form2 : Form
    {
        //pedir el nombre del usuario guardar el nombre y los puntajes en un fichero y al finalizar mostrar el nombre del usuario con sus puntos 
        public static DataTable table = ObtenerTablaUsuarios();
        public static string nombreJugador = Form1.nombreJugador;
        int velocidad = -5;
        public static int puntosPartida = 0;
        Form3 formulario3 = new Form3();
        bool juegoPausado;
        public static Label puntos;
        public Form2()
        {
            InitializeComponent();
            ReproducirMusica.Reproducir();
            Pausa.Hide();
            escape.Hide();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            CambioCoche.CambioCarril(pictureBox1, e);

            if (e.KeyChar == 'p' || e.KeyChar == 'P')
            {
                juegoPausado = !juegoPausado; //cambiar el estado de pausa

                if (juegoPausado)
                {
                    timerJuego.Stop();
                    Pausa.Show();
                    escape.Show();
                }
                else
                {
                    timerJuego.Start();
                    Pausa.Hide();
                    escape.Hide();
                }
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
        }
        private void circuloIzq_Click(object sender, EventArgs e)
        {
        }
        public void MoverObstaculos()
        {
            circuloIzq.Top -= velocidad;
            circuloDch.Top -= velocidad;
            cuadradoDch.Top -= velocidad;
            cuadradoIzq.Top -= velocidad;
        }
        public void ParaerJuego()
        {
            timerJuego.Stop();
            formulario3.Show();
            this.Hide();
        }
        public void AumentarVelocidad(Label puntos)
        {
            velocidad--;
            puntosPartida += 1;
            puntos.Text = puntosPartida.ToString();
            Label puntajeMayor = new Label();
            GuardarPuntos.GuardarEnTxt(nombreJugador, puntos, puntajeMayor);
        }
        //esto es para crear la tabla y guardar la informacion del fichero dentro de la tabla junto con su nombre y puntos
        public static DataTable ObtenerTablaUsuarios()
        {
            string fichero = "puntaje.txt";
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Nombre");
            dataTable.Columns.Add("Puntos");

            if (File.Exists(fichero))
            {
                string[] lineas = File.ReadAllLines(fichero);

                //aqui configuro la tabla
                int numUsuariosAMostrar = Math.Min(10, lineas.Length);
                for (int i = 0; i < numUsuariosAMostrar; i++)
                {
                    string[] elementos = lineas[i].Split(';');
                    string nombre = elementos[0];
                    string puntos = elementos[1];

                    dataTable.Rows.Add(nombre, puntos);
                }
            }

            return dataTable;
        }
        public void CrearCirculo(PictureBox coche, PictureBox circuloIzq, PictureBox circuloDch, Label puntos)
        {
            int distanciaEntreObstaculos = 100;
            if (coche.Bounds.IntersectsWith(circuloDch.Bounds))
            {
                circuloDch.Location = new Point(circuloDch.Location.X, circuloIzq.Location.Y - distanciaEntreObstaculos);
                AumentarVelocidad(puntos);
            }
            if (coche.Bounds.IntersectsWith(circuloIzq.Bounds))
            {
                circuloIzq.Location = new Point(circuloIzq.Location.X, circuloDch.Location.Y - distanciaEntreObstaculos);
                AumentarVelocidad(puntos);
            }
        }
        public void CrearCuadrado(PictureBox coche, PictureBox cuadradoIzq, PictureBox cuadradoDch, Label puntos)
        {
            if (coche.Bounds.IntersectsWith(cuadradoDch.Bounds))
            {
                ParaerJuego();
            }
            if (coche.Bounds.IntersectsWith(cuadradoIzq.Bounds))
            {
                ParaerJuego();
            }
        }
        private void juegoTimer(object sender, EventArgs e)
        {
            MoverObstaculos();
            CrearCirculo(pictureBox1, circuloIzq, circuloDch, puntaje);
            CrearCuadrado(pictureBox1, cuadradoDch, cuadradoIzq, puntaje);
        }
        public void CrearObtaculo(PictureBox invisible2, PictureBox circuloIzq, PictureBox circuloDch, PictureBox cuadradoIzq, PictureBox cuadradoDch)
        {
            if (invisible2.Bounds.IntersectsWith(circuloIzq.Bounds))
            {
                circuloIzq.Location = new Point(10, 5);
            }
            if (invisible2.Bounds.IntersectsWith(circuloDch.Bounds))
            {
                circuloDch.Location = new Point(95, 5);
            }
            if (invisible2.Bounds.IntersectsWith(cuadradoIzq.Bounds))
            {
                cuadradoIzq.Location = new Point(10, 0);
            }
            if (invisible2.Bounds.IntersectsWith(cuadradoDch.Bounds))
            {
                cuadradoDch.Location = new Point(95, 0);
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            CrearObtaculo(Invisible2, circuloIzq, circuloDch, cuadradoIzq, cuadradoDch);
        }
        private void puntaje_Click(object sender, EventArgs e)
        {
        }
        private void cuadradoIzq_Click(object sender, EventArgs e)
        {
        }
        private void Form2_Load(object sender, EventArgs e)
        {
        }
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                formulario3.Show();
            }
        }
    }
}