using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public class GuardarPuntos
    {
        int puntajeActual;
        int puntajeMayor = 0;
        public GuardarPuntos() { }

        public int PuntajeActual { get => puntajeActual; set => puntajeActual = value; }
        public int PuntajeMayor { get => puntajeMayor; set => puntajeMayor = value; }

        public override string ToString()
        {
            return $"{puntajeActual};{puntajeMayor}";
        }
        //esta funcion se encarga de guardar los puntos actuales dentro del fichero y ordenarlos 
        public static void GuardarEnTxt(string nombreJugador, Label puntajeAct, Label puntajeMax)
        {
            string[] lineas = File.ReadAllLines("puntaje.txt");
            List<string> jugadores = new List<string>();

            foreach (string linea in lineas)
            {
                jugadores.Add(linea);
            }

            jugadores.Add($"{nombreJugador};{puntajeAct.Text}");

            //utiliza la función OrderBy de LINQ y una expresión lambda para ordenar los jugadores de la lista en función de sus puntajes de forma descendente.
            jugadores = jugadores.OrderBy(jugador =>
            {
                string[] datos = jugador.Split(';');
                if (datos.Length >= 2 && int.TryParse(datos[1], out int puntosJugador))
                {
                    return -puntosJugador;
                }
                else
                {
                    return 0;
                }
            }).ToList();

            //abre el streamwriter y sobreescribe el contenido existente
            using (StreamWriter escritor = new StreamWriter("puntaje.txt", false))
            {
                foreach (string jugador in jugadores)
                {
                    escritor.WriteLine(jugador);
                }
            }
            BorrarLineasRepetidas("puntaje.txt");
            Console.WriteLine("Datos escritos en el archivo y ordenados por puntos.");
        }
        //comprueba que el nombre del jugador este dentro del fichero, y esta sustituye
        //su puntaje anterior por el actual en caso de que el anterior sea mayor
        public static void BorrarLineasRepetidas(string archivo)
        {
            string[] lineas = File.ReadAllLines(archivo);

            Dictionary<string, int> diccionario = new Dictionary<string, int>();

            foreach (string linea in lineas)
            {
                string[] elementos = linea.Split(';');
                string primerElemento = elementos[0];
                int segundoElemento = int.Parse(elementos[1].Trim());

                if (diccionario.ContainsKey(primerElemento))
                {
                    //comprueba si el puntaje actual es mayor al puntaje antiguo y si lo es lo sustituye
                    if (segundoElemento > diccionario[primerElemento])
                    {
                        diccionario[primerElemento] = segundoElemento;
                    }
                }
                else
                {
                    diccionario.Add(primerElemento, segundoElemento);
                }
            }
            List<string> lineasFinales = new List<string>();

            foreach (string linea in lineas)
            {
                string[] elementos = linea.Split(';');
                string primerElemento = elementos[0];
                int segundoElemento = int.Parse(elementos[1].Trim());

                if (segundoElemento == diccionario[primerElemento])
                {
                    lineasFinales.Add(linea);
                }
            }
            File.WriteAllLines(archivo, lineasFinales);
        }
    }
}
