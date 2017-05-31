using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorPrestamos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double capital, interes, anios, Resultado;
            string cadena = "";
            capital = Convert.ToDouble(textBox1.Text);
            interes = Convert.ToDouble(textBox2.Text);
            anios = Convert.ToDouble(textBox3.Text);


            for (int i = 1; i <= anios; i++)
            {

                Resultado = (capital * (1 + (interes / 100) * i));
                cadena += (i + "\t" + string.Format("{0:C}", Resultado + "\r\n"));
            }
            txtResult.Text = cadena;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
