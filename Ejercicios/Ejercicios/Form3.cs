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
    public partial class VentanaEjercicio3 : Form
    {
        public VentanaEjercicio3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) >= 5)
            {
                label3.Visible = true;
                label4.Visible = true;
            }
            label5.Visible = true;
        }

        private void BotonSalir1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
