using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica
{
    public partial class Form1 : Form
    {
        Bitmap Grafico;
        public Form1()
        {
            InitializeComponent();
            Grafico = new Bitmap(600, 400);
            VentanaP.Image = Grafico;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vector vec = new Vector(0,0,Color.Yellow,Grafico,VentanaP);
            vec.encender();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
