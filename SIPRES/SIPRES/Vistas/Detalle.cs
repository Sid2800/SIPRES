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
using System.Media;

namespace SIPRES.Vistas
{
    public partial class Detalle : Form
    {
        Producto_modelo producto = new Producto_modelo();
        public proyecto Padre;

        Boolean LLenos()
        {
            Boolean lleno;
            if (string.IsNullOrEmpty(TX_codigo.Text)
                || string.IsNullOrEmpty(TX_cantidad.Text)
                || int.Parse(TX_cantidad.Text)<=0)
            { lleno = false; }
            else { lleno = true; }
            return lleno;
        }

        void Limpiar() {
            TX_codigo.Clear();
            TX_producto.Clear();
            TX_cantidad.Clear();
            TX_precio.Clear();
            TX_unidad.Clear();
            TX_total.Clear();
            TX_codigo.Focus();


        }

        public Detalle()
        {
            InitializeComponent();
        }           

        private void TX_codigo_TextChanged(object sender, EventArgs e)
        {
            Veriricar_exitencia_producto();
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
            this.Close();
        }

        private Boolean Veriricar_exitencia_producto() {
            Boolean existe = false;
            if (TX_codigo.MaskCompleted == true)
            {
                producto = new Control_producto().Consultar_producto(TX_codigo.Text.ToString());

                if (Producto_modelo.Existe)
                {
                    TX_producto.Text = producto.Nombre;
                    TX_unidad.Text = producto.Uni_med;
                    TX_precio.Text = producto.Precio.ToString();
                    TX_cantidad.Focus();
                    existe = true;
                }
                else
                {
                    MessageBox.Show("El codigo ingresado no esta en base de datos, ingresa uno nuevo",
               "Sistema Presupuestario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            return existe;
        }

        private void Bt_aseptar_Click(object sender, EventArgs e)
        {
            DataRow linea;
            DataColumn columna;

            if (Veriricar_exitencia_producto())
            {
                if (LLenos())
                {
                    if (Detalle_modelo.Datos != null) // si el objeto no esta vacion, caso contrario lo creamos
                    {
                        int i;
                        for (i = 0; i < Detalle_modelo.Datos.Rows.Count; i++)
                        {
                            if (Detalle_modelo.Datos.Rows[i][0].ToString() == TX_codigo.Text)
                            {
                                MessageBox.Show("Existe una refencia a este codigo, verifica he intentalo de nuevo",
     "Sistema Presupuestario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                            }
                        }

                        if (i >= Detalle_modelo.Datos.Rows.Count)
                        {
                            linea = Detalle_modelo.Datos.NewRow();
                            linea[0] = TX_codigo.Text;
                            linea[1] = TX_producto.Text;
                            linea[2] = TX_unidad.Text;
                            linea[3] = TX_precio.Text;
                            linea[4] = TX_cantidad.Text;
                            linea[5] = TX_total.Text;
                            Detalle_modelo.Datos.Rows.Add(linea);
                            SystemSounds.Beep.Play();
                            Limpiar();
                            Padre.Cargar_grid_detalle();
                        }

                    }
                    else {  //Se ejecutara el siguiente codigo si el objeto esta vacio
                        
                        Detalle_modelo.Datos = new DataTable();
                        // Creando las Columnas
                        columna = new DataColumn();
                        columna.ColumnName = "Codigo";                        
                        Detalle_modelo.Datos.Columns.Add(columna);
                      
                        columna = new DataColumn();
                        columna.ColumnName = "Articulo";
                        Detalle_modelo.Datos.Columns.Add(columna);
                      
                        columna = new DataColumn();
                        columna.ColumnName = "Medida";
                        Detalle_modelo.Datos.Columns.Add(columna);
                     
                        columna = new DataColumn();
                        columna.ColumnName = "Precio";
                        Detalle_modelo.Datos.Columns.Add(columna);

                        columna = new DataColumn();
                        columna.ColumnName = "Cantidad";
                        Detalle_modelo.Datos.Columns.Add(columna);

                        columna = new DataColumn();
                        columna.ColumnName = "Total";
                        Detalle_modelo.Datos.Columns.Add(columna);

                        linea = Detalle_modelo.Datos.NewRow();
                        linea[0] = TX_codigo.Text;
                        linea[1] = TX_producto.Text;
                        linea[2] = TX_unidad.Text;
                        linea[3] = TX_precio.Text;
                        linea[4] = TX_cantidad.Text;
                        linea[5] = TX_total.Text;
                        Detalle_modelo.Datos.Rows.Add(linea);
                        SystemSounds.Beep.Play();
                        Limpiar();

                        Padre.Cargar_grid_detalle();
                    }

                }
                else
                {
                    MessageBox.Show("Hay datos sin ingresar, verifica he intentalo de nuevo",
     "Sistema Presupuestario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                               
            }
         

            




          
        }
    }
}
