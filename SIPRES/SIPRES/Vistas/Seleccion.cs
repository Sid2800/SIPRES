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
    public partial class seleccion : Form
    {
        public usuario Padre;
        Control_consultas control = new Control_consultas();
        string col1, col2,col3, col4;

        public seleccion()
        {
            InitializeComponent();
        }

        public seleccion(string tabla)
        {
            InitializeComponent();
            control.Listar(tabla);
            DGV_detalle.DataSource = Consultas.Datos;
            col1 = Consultas.Datos.Columns[0].ColumnName;
            col2 = Consultas.Datos.Columns[1].ColumnName;
            col3 = Consultas.Datos.Columns[2].ColumnName;
            col4 = Consultas.Datos.Columns[3].ColumnName;


        }

        private void BT_limpiar_Click(object sender, EventArgs e)
        {
            TX_buscar.Clear();
            TX_buscar.Focus();
        }

        private void BT_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TX_buscar_TextChanged(object sender, EventArgs e)
        {
            Filtrar_datos();
        }

        void Filtrar_datos()
        {

            if (Consultas.Datos != null)
            {
                Consultas.Datos.DefaultView.RowFilter =
                $"{col1} + {col2} + {col3} + {col4} like'%" +
                TX_buscar.Text + "%'";
            }
        }


        private void Bt_aseptar_Click(object sender, EventArgs e)
        {
            string codigo = DGV_detalle.SelectedCells[0].Value.ToString();
            if (!string.IsNullOrEmpty(codigo)) {
                Consultas.Var = DGV_detalle.SelectedCells[0].Value.ToString();
                Padre.Cargar_consultado();
                this.Close();
            }
        }


    }
}
