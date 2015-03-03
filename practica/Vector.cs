using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica
{
    class Vector: ModelosMat
    {
        public double x0;
        public double y0;
        public Color col;
        public static PictureBox lienzo;
        public static Graphics Grafico;
        public static Bitmap bit;
 



        public Vector(double x0s, double y0s, Color clr, Bitmap bi, PictureBox lienzos)
        {
            this.y0 = y0s;
            this.x0 = x0s;
            this.col = clr;
            lienzo = lienzos;
            bit = bi;
            Grafico = lienzo.CreateGraphics();
        }
    
        public Vector()
        { }


        

        public virtual void encender()
        {
            int sx, sy;
            double p1 = Convert.ToDouble(this.x0);//poniendo el valor de xo que ingresa
            double p2 = Convert.ToDouble(this.y0);//poniendo el valor de yo que ingresa
            pantalla(p1, p2, out sx, out sy); // parametros de x0 y y0 salida valores sx, sy
            if (sx < lienzo.Width && sx > 0 && sy < lienzo.Height && sy > 0)// es como un try para que no me de errore al momento de graficar
                bit.SetPixel(sx, sy, col);//valores que van ha graficar
            lienzo.Image = bit;//llamar a la imagen
            //Grafico.DrawImage(bit, 0, 0, lienzo.Width, lienzo.Height);
        }

        public virtual void apagar()
        {

        }

    }
}
