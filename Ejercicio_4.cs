using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios_Segunda_Unidad_L3
{
    public partial class Ejercicio_4 : Form
    {
        double precio = 0;
        public Ejercicio_4()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbFecha.Text = DateTime.Today.Date.ToString("d");
            lbPrecio.Text = (0).ToString("C");
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string producto = cboProducto.Text;

            if (producto.Equals("Colecion Escolar")) precio = 250;
            if (producto.Equals("Colecion PreUniversitaria")) precio = 150;
            if (producto.Equals("Colecion Profesional")) precio = 350;

            lbPrecio.Text = lbPrecio.ToString();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cboProducto.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar un producto...!!!");
            else if (cboTipo.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar un tipo...!!!");
            else
            {
                string producto = cboProducto.Text;
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                string tipo = cboTipo.Text;

                double subTotal = cantidad * precio;

                double descuento = 0, recargo = 0;
                if (tipo.Equals("Contado"))
                descuento = 0.05 * subTotal;
                else
                    recargo = 0.1 * subTotal;

                double precioFinal = subTotal - descuento + recargo;

                ListViewItem fila = new ListViewItem(producto);
                fila.SubItems.Add(cantidad.ToString());
                fila.SubItems.Add(precio.ToString("C"));
                fila.SubItems.Add(tipo);
                fila.SubItems.Add(descuento.ToString("C"));
                fila.SubItems.Add(recargo.ToString("C"));
                fila.SubItems.Add(precioFinal.ToString("C"));

                lvVentas.Items.Add(fila);
                

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cboProducto.Text = "(Seccione producto)";
            cboTipo.Text = "(Seleccione tipo)";
            txtCantidad.Clear();
            lbPrecio.Text = (0).ToString("C");
            cboProducto.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de salir?",
                "Venta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);

            if (r == DialogResult.Yes) this.Close(); 
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            cboProducto.Items.Clear();
            cboTipo.Items.Clear();
            txtCantidad.Text = string.Empty;
            
            // Clear the ListView
            lvVentas.Items.Clear();
        }
    }
}
