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
    public partial class VentanaEjercicio2 : Form
    {
        public VentanaEjercicio2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label4.Visible = true;
            label5.Text = textBox1.Text + " y " + textBox2.Text;
            label5.Visible = true;
        }

    }
}
