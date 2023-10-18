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
    public partial class VentanaEjercicios : Form
    {
        public VentanaEjercicios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boton1.Enabled = false;
            VentanaEjercicio2 form2 = new VentanaEjercicio2();
            form2.Show();
            form2.FormClosed += Form2_FormClosed;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Boton1.Enabled = true;
        }

        private void Boton2_Click(object sender, EventArgs e)
        {
            Boton2.Enabled = false;
            VentanaEjercicio3 form3 = new VentanaEjercicio3();
            form3.Show();
            form3.FormClosed += Form3_FormClosed;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Boton2.Enabled = true;
        }

        private void Boton3_Click(object sender, EventArgs e)
        {
            Boton3.Enabled = false;
            VentanaEjercicio4 form4 = new VentanaEjercicio4();
            form4.Show();
            form4.FormClosed += Form4_FormClosed;
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Boton3.Enabled = true;
        }

        private void Boton4_Click(object sender, EventArgs e)
        {
            Boton4.Enabled = false;
            VentanaEjercicio5 form5 = new VentanaEjercicio5();
            form5.Show();
            form5.FormClosed += Form5_FormClosed;
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Boton4.Enabled = true;
        }

        private void Boton5_Click(object sender, EventArgs e)
        {
            Boton5.Enabled = false;
            VentanaEjercicio6 form6 = new VentanaEjercicio6();
            form6.Show();
            form6.FormClosed += Form6_FormClosed;
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Boton5.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            catify catify = new catify();
            catify.Show();
        }
        

    }
}
