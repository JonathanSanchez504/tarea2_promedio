using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea2_promedio
{
    public partial class tarea2_20181030120 : Form
    {
        public tarea2_20181030120()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double nt1, nt2, nt3, nt4, promedio;
            string condicion;
            nt1 = Double.Parse(txb_nota1.Text);
            nt2 = Double.Parse(txb_nota2.Text);
            nt3 = Double.Parse(txb_nota3.Text);
            nt4 = Double.Parse(txb_nota4.Text);

            promedio = (nt1 + nt2 + nt3 + nt4) / 4;


            if (promedio >= 65)
            {
                condicion = "Aprobado";
                txb_promedio.Text = promedio.ToString("n2");
                txt_condicion.Text = condicion;


            }
            else if (promedio >= 0)
            {
                condicion = "Desaprobado";
                txb_promedio.Text = promedio.ToString("n2");
                txt_condicion.Text = condicion;
            }
            //
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txb_nota1.Text = "";
            txb_nota2.Text = "";
            txb_nota3.Text = "";
            txb_nota4.Text = "";
            txb_promedio.Text = "";
            txt_condicion.Text = "";
            txb_nota1.Focus();
        }
    }
}
