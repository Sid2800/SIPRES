using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIPRES.Models;
using SIPRES.Controles;

namespace SIPRES.Vistas
{
    public partial class Detalle : Form
    {
        Producto_modelo producto = new Producto_modelo();
        public proyecto Padre; 

        public Detalle()
        {
            InitializeComponent();
        }

        private void TX_codigo_TextChanged(object sender, EventArgs e)
        {
            if (TX_codigo.MaskCompleted == true)
            {
                producto = new Control_producto().Consultar_producto(TX_codigo.Text.ToString());

                if (Producto_modelo.Existe)
                {
                    TX_producto.Text = producto.Nombre;
                    TX_unidad.Text = producto.Uni_med;
                    TX_precio.Text = producto.Precio.ToString();
                    TX_cantidad.Focus();
                }
                else
                {
                    MessageBox.Show("El codigo ingresado no esta en base de datos, ingresa uno nuevo",
               "Sistema Presupuestario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
              
            }
        }

        private void TX_cantidad_Leave(object sender, EventArgs e)
        {
            float total;

            if (string.IsNullOrEmpty(TX_cantidad.Text) == false)
            {
                total = float.Parse(TX_cantidad.Text) * float.Parse(TX_precio.Text);
                TX_total.Text = Convert.ToString(total);
            }
        }

        private void BT_cancelar_Click(object sender, EventArgs e)
        {
            Padre.Cargar_grid_detalle()
        }
    }
}
