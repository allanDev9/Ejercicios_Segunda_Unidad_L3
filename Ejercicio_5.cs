using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejercicios_Segunda_Unidad_L3
{
    public partial class Ejercicio_5 : Form
    {
       // ListView item;
        public Ejercicio_5()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Ejercicio_5_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.Date.ToShortDateString();
            lbHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text;
            double velocidad  = double.Parse(txtVelocidad.Text);
            DateTime fecha = DateTime.Parse(lblFecha.Text);
            DateTime hora = DateTime.Parse(lbHora.Text);

            double multa = 0;
            if (velocidad <= 70)
                multa = 0;

            else if (velocidad > 70 && velocidad <= 90)
                multa = 120;

            else if (velocidad > 90 && velocidad <= 100)
                multa = 240;
            else if (velocidad > 100)
                multa = 350;

            ListViewItem fila = new ListViewItem();
            fila.SubItems.Add(lblFecha.Text);
            fila.SubItems.Add(lbHora.Text);
            fila.SubItems.Add(velocidad.ToString("0.00"));
            fila.SubItems.Add(multa.ToString("C"));
            lvMultas.Items.Add(fila);   

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           // if (item != null)
            {
             //   lvMultas.Items.Remove(item);
                MessageBox.Show("Multa eliminada correctamente");

            }
          //  else
            {
                MessageBox.Show("Debe seleccionar una multa de la lista");
            }
        }

        private void Ejercicio_5_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void lvMultas_MouseClick(object sender, MouseEventArgs e)
        {
         //   item = lvMultas.GetItemAt(e.X, e.Y);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtPlaca.Text = string.Empty;
            txtVelocidad.Text = string.Empty;
            // Clear the ListView
            lvMultas.Items.Clear();

        }
    }
}
