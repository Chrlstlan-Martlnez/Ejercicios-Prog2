using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios
{
    public partial class VentanaEjercicio5 : Form
    {
        public VentanaEjercicio5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota = Convert.ToDouble(textBox1.Text);
            
            if ((nota < 0) || (nota > 10))
            {
                label3.Text = "Nota Invalida";
            }
            else if (nota == 10)
            {
                label3.Text = "Matrícula de Honor";
            }
            else if (nota >= 9)
            {
                label3.Text = "Sobresaliente";
            }
            else if (nota >= 7)
            {
                label3.Text = "Notable";
            }
            else if (nota >= 6)
            {
                label3.Text = "Bien";
            }
            else if (nota >= 5)
            {
                label3.Text = "Suficiente";
            }
            else
            {
                label3.Text = "Suspenso";
            }
            label4.Visible = true;
            label3.Visible = true;
            textBox1.Text = "";
        }

        private void BotonSalir1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
