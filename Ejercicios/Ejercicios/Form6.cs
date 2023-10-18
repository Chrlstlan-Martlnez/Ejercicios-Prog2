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
    public partial class VentanaEjercicio6 : Form
    {
        public VentanaEjercicio6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (Convert.ToInt32(textBox1.Text))
            {
                case 1: label3.Text = "ENERO";
                    break;
                case 2: label3.Text = "FEBRERO";
                    break;
                case 3: label3.Text = "MARZO";
                    break;
                case 4: label3.Text = "ABRIL";
                    break;
                case 5: label3.Text = "MAYO";
                    break;
                case 6: label3.Text = "JUNIO";
                    break;
                case 7: label3.Text = "JULIO";
                    break;
                case 8: label3.Text = "AGOSTO";
                    break;
                case 9: label3.Text = "SEPTIEMBRE";
                    break;
                case 10: label3.Text = "OCTUBRE";
                    break;
                case 11: label3.Text = "NOVIEMBRE";
                    break;
                case 12: label3.Text = "DICIEMBRE";
                    break;
                default: label3.Text = "Inexistente :0";
                    break;
            }
            label3.Visible = true;
            label4.Visible = true;
        }

        private void BotonSalir1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
