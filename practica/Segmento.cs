using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica
{
    class Segmento: Vector
    {
        private double sx0;
        private double sy0;
        private double sxf;
        private double syf;
        

        public double Sx0
        {
            get { return sx0; }
            set { sx0 = value; }
        }

        public double Sy0
        {
            get { return sy0; }
            set { sy0 = value; }
        }

        public double Sxf
        {
            get { return sxf; }
            set { sxf = value; }
        }
        

        public double Syf
        {
            get { return syf; }
            set { syf = value; }
        }
       

        public Segmento(double x0, double y0, double xf, double yf, Color c, Bitmap bi, PictureBox li) 
        {
            sx0 = x0;
            sy0 = y0;
            sxf = xf;
            syf = yf;
            col = c;
            bit = bi;
            Grafico = li.CreateGraphics();
            lienzo = li;           
        }

        public override void encender()
        {
            double t=0, dt = 0.003;
            Vector vector = new Vector(0,0,col, bit,lienzo);
            do
            {
                vector.x0 = sx0 * (1 - t) + sxf * (t);
                vector.y0 = sy0 * (1 - t) + syf * (t);
                vector.encender();
                t = t + dt;

            } while (t < 1);
            
        }




        
    }
}
