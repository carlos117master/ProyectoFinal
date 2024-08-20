using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public class CambioCoche
    {
        public CambioCoche() { }
        public static void CambioCarril(PictureBox coche, KeyPressEventArgs e)
        {
            int cambioCoches;
            if (e.KeyChar == ' ' || e.KeyChar == ' ')
            {
                if (coche.Location.X == 95)
                {
                    cambioCoches = 10;
                }
                else
                {
                    cambioCoches = 95;
                }
                coche.Location = new Point(cambioCoches, coche.Location.Y);
            }
           
        }
    }
}
