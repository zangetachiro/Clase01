using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();//cierra el formulario actual
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            int horastrabajadas = 0;
            float tasaimpuesto = 0, pagoxhora = 0;
            float pagobruto = 0, pagoimpuesto = 0, pagoneto = 0;
            string salida;

            horastrabajadas = int.Parse(txtHorasTrabajadas.Text);
            tasaimpuesto = float.Parse(txtTasa.Text);
            pagoxhora = float.Parse(txtPagaxHora.Text);

            pagobruto = (horastrabajadas * pagoxhora);
            pagoimpuesto = (pagobruto * tasaimpuesto);
            pagoneto = (pagobruto - pagoimpuesto);

            salida = string.Format("El trabajador {0} obtuvo\n",txtNombre.Text);
            salida += string.Format("El pago bruto es = {0}\n",pagobruto);
            salida += string.Format("El pago por impuesto es = {0}\n",pagoimpuesto);
            salida += string.Format("El pago neto es = {0}\n ",pagoneto);
            lblResultado.Text = salida;
        }
    }
}
