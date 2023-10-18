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
    public partial class VentanaEjercicio4 : Form
    {
        private int nPares = 0;
        private int nImpares = 0;

        public VentanaEjercicio4()
        {
            InitializeComponent();
        }

        private void BotonSalir1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(textBox1.Text) % 2) == 0)
            {
                nPares += 1;
                label5.Text = nPares.ToString();
            }
            else
            {
                nImpares += 1;
                label6.Text = nImpares.ToString();
            }
            textBox1.Text = "";
        }
    }
}
