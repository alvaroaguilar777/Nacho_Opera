using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nacho;
using NachoOperaRestar;
using NachoOperaMultiplica;
using NachoOPeraDivicion;
using System.Windows.Forms;

namespace Nacho_Opera
{
    public partial class Form1 : Form
    {
        int v1, v2;

        public Form1()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            v1 = int.Parse(textBox1.Text);
            v2 = int.Parse(textBox2.Text);
            long resta;
            resta = NachoOperaRestar.Class1.restar(v1, v2);
            label2.Text = ("Resultado = " + resta);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            v1 = int.Parse(textBox1.Text);
            v2 = int.Parse(textBox2.Text);
            long multiplica;
            multiplica = NachoOperaMultiplica.Class1.multiplicar(v1, v2);
            label2.Text = ("Resultado = " + multiplica);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            v1 = int.Parse(textBox1.Text);
            v2 = int.Parse(textBox2.Text);
            long divide;
            if (v1 == 0 || v2 == 0)
            {
                label2.Text = ("Resultado = Error");
                MessageBox.Show(" No se puede Dividir Por 0 ");
            }
            else
            {
                divide = NachoOPeraDivicion.Class1.divide(v1, v2);
                label2.Text = ("Resultado = " + divide);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            v1 = int.Parse(textBox1.Text);
            v2 = int.Parse(textBox2.Text);
            long suma;
            suma = nacho.Class1.Sumar(v1, v2);

            label2.Text= ("Resultado = " + suma);

        }
    }
}
