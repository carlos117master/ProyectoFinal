using System;
using System.Collections.Generic;
using System.Text;
using System.Media;
using System.Security.Permissions;
using System.Windows;
using System.Windows.Forms;
using System.Drawing.Text;

namespace ProyectoFinal
{
    internal class ReproducirMusica
    {
        public ReproducirMusica() { }
        public static void Reproducir()
        {
            try
            {
                List<SoundPlayer> list = new List<SoundPlayer>();
                Random rnMusica = new Random();
                SoundPlayer musica = new SoundPlayer(@"LoboHombreEnParis.wav");
                SoundPlayer musica2 = new SoundPlayer(@"DeMúsicaLigera.wav");
                list.Add(musica);
                list.Add(musica2);
                int index = rnMusica.Next(list.Count);
                SoundPlayer selectedMusica = list[index];
                selectedMusica.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al cargar");
            }
           
        }
    }
}
