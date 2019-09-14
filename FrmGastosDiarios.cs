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
    public partial class FrmGastosDiarios : Form
    {
        public FrmGastosDiarios()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            double[] vGastos;
            double gasto, totalGasto, diaMayor, GastoMayor;
            int cantDias;
            //Inicializar variables
            totalGasto = 0;
            diaMayor = 1;
            GastoMayor = 0;
            //Empezamos a leer los gastos
            cantDias = Convert.ToInt32(txtCantiDias.Text);
            vGastos = new double[cantDias];
            for (int dia=1;dia<=cantDias;dia++)
            {
                gasto = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el gasto del dia"+dia,"Gastos"));
                vGastos[dia - 1] = gasto;
            }
            for (int i = 0;i<cantDias; i++)
            {
                //Evaluamos el gasto mayor
                if (vGastos[i]>GastoMayor)
                {
                    GastoMayor = vGastos[i];
                    diaMayor = i + 1;

                }
                //Calcular el total de gastos
                totalGasto = totalGasto + vGastos[i];
                //Mostramos los gastos en el ComboBox
                cboGastos.Items.Add("Dia"+(i+1)  + vGastos[i]);
            }
            //Mostrar informacion resulante
            txtGastoMayor.Text = Convert.ToString(GastoMayor);
            txtDiaMayor.Text = Convert.ToString(diaMayor);
            txtTotalGastos.Text = Convert.ToString(totalGasto);


        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            txtCantiDias.Clear();
            txtDiaMayor.Clear();
            txtGastoMayor.Clear();
            txtTotalGastos.Clear();
            cboGastos.Items.Clear();

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
