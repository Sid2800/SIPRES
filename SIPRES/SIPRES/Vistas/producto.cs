using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIPRES.Controles;
using SIPRES.Models;

namespace SIPRES.Vistas
{
    public partial class producto : Form
    {
        Control_producto control = new Control_producto();
        Reporte reporte = new Reporte();
        Producto_modelo producto_Modelo = new Producto_modelo();

        public producto()
        {
            InitializeComponent();
        }
        
        Boolean LLenos()
        {
            Boolean lleno;
            if (TX_codigo.MaskCompleted == false
                || string.IsNullOrEmpty(TX_nombre.Text)
                || string.IsNullOrEmpty(TX_unidad.Text)
                || string.IsNullOrEmpty(TX_precio.Text)
                || string.IsNullOrEmpty(CB_Tipo.Text)
                )
            { lleno = false; }
            else { lleno = true; }
            return lleno;
        }

        void Limpiar()
        {
            this.TX_codigo.Clear();
            this.TX_nombre.Clear();
            this.TX_unidad.Clear();
            this.TX_precio.Clear();
            this.CB_Tipo.Text = "";

        }

        ///METODOS DE CARGA
        #region Metodos de Carga


        private void Producto_Load(object sender, EventArgs e)
        {
            Cargar_grid();
        }

        void Cargar_grid()
        {
            control.Listar_productos();
            this.DGV_datos.DataSource = Producto_modelo.Datos;

        }



        void Filtrar_datos()
        {
            if (Producto_modelo.Datos != null)
            {
                Producto_modelo.Datos.DefaultView.RowFilter =
                $"Id_pro + Nombre  like'%" +
                TX_buscar.Text + "%'";
            }
        }

        void Modo(string M)
        {
            switch (M)
            {
                case "C":
                case "c":

                    this.TX_codigo.Clear();
                    this.TX_nombre.Clear();
                    this.TX_unidad.Clear();
                    this.TX_precio.Clear();
                    this.CB_Tipo.Text = "";
                   
                    //Controles
                    TX_codigo.ReadOnly = true;
                    TX_nombre.ReadOnly = true;
                    TX_unidad.ReadOnly = true;
                    TX_precio.Enabled = false;
                    CB_Tipo.Enabled = true;
                 


                    // Botones
                    BT_editar.Enabled = true;
                    BT_nuevo.Enabled = true;
                    BT_guardar.Enabled = false;
                    BT_cancelar.Visible = false;
                    break;

                case "E":
                case "e":
                    //Controles
                    TX_codigo.ReadOnly = false;
                    TX_nombre.ReadOnly = false;
                    TX_unidad.ReadOnly = true;
                    TX_precio.Enabled = true;
                    CB_Tipo.Enabled = true;
                    
                    // Botones
                    BT_editar.Enabled = false;
                    BT_nuevo.Enabled = false;
                    BT_guardar.Enabled = true;
                    BT_cancelar.Visible = true;
                    break;

                case "A":
                case "a": // solo un administrador
                          //Controles
                    TX_codigo.ReadOnly = true;
                    TX_nombre.ReadOnly = true;
                    TX_unidad.ReadOnly = true;
                    TX_precio.Enabled = true;
                    CB_Tipo.Enabled = true;
            

                    // Botones
                    BT_editar.Enabled = false;
                    BT_nuevo.Enabled = false;
                    BT_guardar.Enabled = true;
                    BT_cancelar.Visible = true;
                    TX_codigo.Focus();
                    break;

                default:
                    break;
            }

        }

        void Modo_consulta(string Id_pro)
        {
            Producto_modelo Var;
            Var = new Control_producto().Consultar_producto(Id_pro);
            Boolean existe = Producto_modelo.Existe;
            if (existe)
            {
                //Controles
                TX_codigo.Text = Var.Id_pro;
                TX_nombre.Text = Var.Nombre;
                TX_unidad.Text = Var.Uni_med;
                TX_precio.Text = Var.Precio.ToString();
                //CB_Tipo.Text = Var.Id_tipo_pro;

            }
            else
            {
                Limpiar();

            }
        }

        Producto_modelo Agregar_producto()
        {

            producto_Modelo.Id_pro = this.TX_codigo.Text;

            producto_Modelo.Nombre = this.TX_nombre.Text;
            producto_Modelo.Uni_med = this.TX_unidad.Text;
            producto_Modelo.Precio = float.Parse(this.TX_precio.Text);
            producto_Modelo.Id_tipo_pro =   int.Parse(this.CB_Tipo.Text);


            return producto_Modelo;
        }

        private void TP_administrar_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Metodos con Objetos

        private void TX_buscar_TextChanged(object sender, EventArgs e)
        {
            Filtrar_datos();
        }

        private void TC_proyecto_Selected(object sender, TabControlEventArgs e)
        {
            Modo("C");
            if (TX_codigo.MaskCompleted)
            {
                Modo_consulta(TX_codigo.Text.ToString());
            }
            else
            {
                BT_editar.Enabled = false;
                Limpiar();
            }
        }

        private void DGV_datos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (string.IsNullOrEmpty(DGV_datos.SelectedCells[0].Value.ToString()))
            {

            }
            else
            {
                Limpiar();
                Modo_consulta(DGV_datos.SelectedCells[0].Value.ToString());
                TC_proyecto.SelectedTab = TP_administrar;
                Modo("c");
            }
        }


        #endregion

        #region Metodos Botones



        private void BT_nuevo_mini_Click_1(object sender, EventArgs e)
        {
            TC_proyecto.SelectedTab = TP_administrar;
            Limpiar();
            Modo("A");
        }

        private void BT_editar_mini_Click_1(object sender, EventArgs e)
        {
            Limpiar();
            String codigo = DGV_datos.SelectedCells[0].Value.ToString();
            Modo_consulta(codigo);
            TC_proyecto.SelectedTab = TP_administrar;
            Modo("e");
        }

        private void BT_excel_Click_1(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToShortDateString();
            string fechaarch = fecha.Replace('/', '_');

            SFD_excel.FileName = "Listado_Productos" + fechaarch + ".csv";


            if (SFD_excel.ShowDialog() == DialogResult.OK)
            {
                string archivo = SFD_excel.FileName;
                reporte.A_excel(DGV_datos, archivo);

            }
        }

        private void BT_pdf_Click_1(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToShortDateString();
            string fechaarch = fecha.Replace('/', '_');

            SFD_pdf.FileName = "Listado_Productos" + fechaarch + ".pdf";


            if (SFD_pdf.ShowDialog() == DialogResult.OK)
            {
                string archivo = SFD_pdf.FileName;
                reporte.A_pdf(archivo, DGV_datos);
            }
        }

        private void BT_limpiar_Click_1(object sender, EventArgs e)
        {
            TX_buscar.Clear();
            TX_buscar.Focus();
        }

        private void BT_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_nuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            Modo("A");
        }

        private void BT_cancelar_Click(object sender, EventArgs e)
        {
            Modo("C");
            if (string.IsNullOrEmpty(TX_codigo.Text))
            {
                BT_editar.Enabled = false;
                Limpiar();
            }
            else
            {
                Modo_consulta(TX_codigo.Text.ToString());
            }
            TC_proyecto.SelectedTab = TP_listar;
        }

        private void BT_editar_Click(object sender, EventArgs e)
        {
            if (LLenos()) { Modo("E"); }
        }




        #endregion

   
    }
}