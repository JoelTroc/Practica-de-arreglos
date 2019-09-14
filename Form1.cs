using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnCargarVector_Click(object sender, EventArgs e)
        {
            //Declaracion de variables 
            int[] notas = new int[5];
            //Especificar las notas
            notas[0] = 15;
            notas[1] = 13;
            notas[2] = 11;
            notas[3] = 16;
            notas[4] = 18;

            int suma = 0;
            double promedio;

            //Proceso 
            cboNotas.Items.Clear();
            //Recorrer todo nuestro vector
            for (int i = 0; i <=4; i++)
            {
                //Mostrar notas en el comboxbox
                cboNotas.Items.Add(notas[i]);
                suma = suma + notas[i];
            }
            promedio = suma / 5;
            //Salida de informacion 
            txtPromedio.Text = Convert.ToString(promedio);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            txtPromedio.Clear();
            cboNotas.Items.Clear();
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
