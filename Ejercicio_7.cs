using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios_Segunda_Unidad_L3
{
    public partial class Ejercicio_7 : Form
    {
        public Ejercicio_7()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Ejercicio_7_Load(object sender, EventArgs e)
        {

        }

        private void tsRegistrar_Click(object sender, EventArgs e)
        {
            string telefono = txtTelefono.Text;
            int minutos = int.Parse(txtMinutos.Text);

            string tipo = "";
            if (rbNacional.Checked == true) tipo = "Fijo Nacional";
            if (rbmNacional.Checked == true) tipo = "Movil Nacional";
            if (rbmInternacional.Checked == true) tipo = "Movil Internacional";

            if (tipo == "")
            {
                MessageBox.Show("Debe seleccionar el tipo de llamda...!!"
                    , "Llamadas");
                return;

            }
            double tarifa = 0;
            switch (tipo)
            {
                case "Fijo Nacional": tarifa = 0.25; break;
                case "Fijo Internacional": tarifa = 1.75; break;
                case "Movil Nacional": tarifa = 1.25; break;
                case "Movil Internacional": tarifa = 2.50; break;
            }
            double importe = tarifa * minutos;

            double descuento;
            switch (tipo)
            {
                case "Fijo Nacional":
                    descuento = 5.0 / 100 * importe; break;
                case "Fijo Internacional":
                    descuento = 7.0 / 100 * importe; break;
                case "Movil Nacional":
                    descuento = 9.0 / 100 * importe; break;
                case "Movil Internacional":
                    descuento = 12.0 / 100 * importe; break;

                default:
                    descuento = 0; break;
            }

            double neto = importe - descuento;

            ListViewItem fila = new ListViewItem();
            fila.SubItems.Add(tipo);
            fila.SubItems.Add(minutos.ToString());
            fila.SubItems.Add(importe.ToString("C"));
            fila.SubItems.Add(descuento.ToString("C"));
            fila.SubItems.Add(neto.ToString("C"));
            lvLlamadas.Items.Add(fila);
        }

        private void tsCancelar_Click(object sender, EventArgs e)
        {
            txtTelefono.Clear();
            txtMinutos.Clear();
            rbNacional.Checked = true;
            txtTelefono.Focus();
        }

        private void tsSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show ("Esta seguro de salir?",
                "Llamadas",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);
            if (r == DialogResult.Yes) this.Close();
        }

        private void txtMinutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Debe ingresar solo numeros", "Llamadas");
                e.Handled = true;
                return;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Debe ingresar solo numeros", "Llamadas");
                e.Handled = true;
                return;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtTelefono.Clear();
            txtMinutos.Clear();
            lvLlamadas.Clear();

        }
    }
}
