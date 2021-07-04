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
    public partial class persona : Form
    {
        Control_persona control = new Control_persona();
        Reporte reporte = new Reporte();
        Persona_modelo personanew = new Persona_modelo();

        public persona()
        {
            InitializeComponent();
        }
        
        Boolean LLenos()
        {
            Boolean lleno;
            if (TX_identidad.MaskCompleted == false
                || string.IsNullOrEmpty(TX_rtn.Text)
                || string.IsNullOrEmpty(TX_nombre.Text)
                || string.IsNullOrEmpty(TX_rtn.Text)
                || string.IsNullOrEmpty(TX_apellido.Text)
                || string.IsNullOrEmpty(CB_sexo.Text)
                || string.IsNullOrEmpty(TX_tell_cell.Text)
                || string.IsNullOrEmpty(TX_tel_fijo.Text)
                || string.IsNullOrEmpty(TX_tell_cell.Text)
                || string.IsNullOrEmpty(TX_direccion.Text)

                )
            { lleno = false; }
            else { lleno = true; }
            return lleno;
        }

        void Limpiar()
        {
            this.TX_identidad.Clear();
            this.TX_rtn.Clear();
            this.TX_nombre.Clear();
            this.TX_apellido.Clear();
            this.DT_nacimiento.Value = DateTime.Now;
            this.CB_sexo.Text = "";
            this.TX_edad.Clear();
            var timeSpan = DateTime.Now - DT_nacimiento.Value;
            int anios = (timeSpan.Days / 365);
            TX_edad.Text = anios.ToString() + " Años";
            this.TX_tell_cell.Clear();
            this.TX_tel_fijo.Clear();
            this.TX_correo.Clear();
            this.TX_direccion.Clear();

        }
                
        #region Metodos de Carga

        private void Persona_Load(object sender, EventArgs e)
        {
            Cargar_grid();
        }
        
        void Cargar_grid()
        {
            control.Listar_persona();
            this.DGV_datos.DataSource = Persona_modelo.Datos;

        }

        void Filtrar_datos()
        {
            if (Persona_modelo.Datos != null)
            {
                Persona_modelo.Datos.DefaultView.RowFilter =
                $"identidad + nombre + apellido like'%" +
                TX_buscar.Text + "%'";
            }
        }

        void Modo(string M)
        {
            switch (M)
            {
                case "C":
                case "c":
                    //Controles
                    TX_identidad.ReadOnly = true;
                    TX_rtn.ReadOnly = true;
                    TX_nombre.ReadOnly = true;
                    TX_apellido.ReadOnly = true;
                    DT_nacimiento.Enabled = false;
                    CB_sexo.Enabled = false;
                    TX_tell_cell.ReadOnly = true;
                    TX_tel_fijo.ReadOnly = true;
                    TX_correo.ReadOnly = true;
                    TX_direccion.ReadOnly = true;

                    // Botones
                    BT_editar.Enabled = true;
                    BT_nuevo.Enabled = true;
                    BT_guardar.Enabled = false;
                    BT_cancelar.Visible = false;
                    break;

                case "E":
                case "e":

                    TX_rtn.ReadOnly = false;
                    TX_nombre.ReadOnly = false;
                    TX_apellido.ReadOnly = false;
                    DT_nacimiento.Enabled = true;
                    CB_sexo.Enabled = true;
                    TX_tell_cell.ReadOnly = false;
                    TX_tel_fijo.ReadOnly = false;
                    TX_correo.ReadOnly = false;
                    TX_direccion.ReadOnly = false;

                    // Botones
                    BT_editar.Enabled = false;
                    BT_nuevo.Enabled = false;
                    BT_guardar.Enabled = true;
                    BT_cancelar.Visible = true;
                    break;

                case "A":
                case "a": // solo un administrador
                    TX_identidad.ReadOnly = false;
                    TX_rtn.ReadOnly = false;
                    TX_nombre.ReadOnly = false;
                    TX_apellido.ReadOnly = false;
                    DT_nacimiento.Enabled = true;
                    CB_sexo.Enabled = true;
                    TX_tell_cell.ReadOnly = false;
                    TX_tel_fijo.ReadOnly = false;
                    TX_correo.ReadOnly = false;
                    TX_direccion.ReadOnly = false;

                    // Botones
                    BT_editar.Enabled = false;
                    BT_nuevo.Enabled = false;
                    BT_guardar.Enabled = true;
                    BT_cancelar.Visible = true;
                    TX_identidad.Focus();
                    break;

                default:
                    break;
            }

        }

        void Modo_consulta(string identidad)
        {
            Persona_modelo Var;
            Var = new Control_persona().Consultar_persona(identidad);
            Boolean existe = Persona_modelo.Existe;
            if (existe)
            {

                TX_identidad.Text = Var.Identidad;
                TX_rtn.Text = Var.Identidad;
                TX_nombre.Text = Var.Nombre;
                TX_apellido.Text = Var.Apellido;
                DT_nacimiento.Value = Var.F_nacimiento;
                CB_sexo.Text = Var.Genero;
                var timeSpan = DateTime.Now - Var.F_nacimiento;
                int anios = (timeSpan.Days / 365);
                TX_edad.Text = anios.ToString() + " Años";
                TX_tell_cell.Text = Var.Tel_cell;
                TX_tel_fijo.Text = Var.Tel_fijo;
                TX_correo.Text = Var.Correo;
                TX_direccion.Text = Var.Direccion;

            }
            else
            {
                Limpiar();

            }
        }

        Persona_modelo Agregar_persona()
        {
            personanew.Identidad = this.TX_identidad.Text;
            personanew.Rtn = this.TX_rtn.Text;
            personanew.Nombre = this.TX_nombre.Text;
            personanew.Apellido = this.TX_apellido.Text;
            personanew.F_nacimiento = this.DT_nacimiento.Value;
            personanew.Genero = this.CB_sexo.Text;
            personanew.Tel_cell = this.TX_tell_cell.Text;
            personanew.Tel_fijo = this.TX_tel_fijo.Text;
            personanew.Correo = this.TX_correo.Text;
            personanew.Direccion = this.TX_direccion.Text;
            return personanew;
        }


        #endregion


        #region Metodos con Objetos

        private void TX_buscar_TextChanged(object sender, EventArgs e)
        {
            Filtrar_datos();
        }

        private void BT_limpiar_Click(object sender, EventArgs e)
        {
            TX_buscar.Clear();
            TX_buscar.Focus();
        }

        private void DT_nacimiento_ValueChanged(object sender, EventArgs e)
        {
            var timeSpan = DateTime.Now - DT_nacimiento.Value;
            int anios = (timeSpan.Days / 365);
            TX_edad.Text = anios.ToString() + " Años";
        }

        private void TC_persona_Selected(object sender, TabControlEventArgs e)
        {
            Modo("C");
            if (TX_identidad.MaskCompleted)
            {
                Modo_consulta(TX_identidad.Text.ToString());
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
                TC_persona.SelectedTab = TP_administrar;
                Modo("c");
            }
        }

        #endregion


        #region Metodos de Botones
        
        private void BT_pdf_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToShortDateString();
            string fechaarch = fecha.Replace('/', '_');

            SFD_pdf.FileName = "Listado_Personas" + fechaarch + ".pdf";


            if (SFD_pdf.ShowDialog() == DialogResult.OK)
            {
                string archivo = SFD_pdf.FileName;
                reporte.A_pdf(archivo, DGV_datos);
            }
        }

        private void BT_excel_Click(object sender, EventArgs e) 
        {
            string fecha = DateTime.Now.ToShortDateString();
            string fechaarch = fecha.Replace('/', '_');

            SFD_excel.FileName = "Listado_Personas" + fechaarch + ".csv";
            
            if (SFD_excel.ShowDialog() == DialogResult.OK)
            {
                string archivo = SFD_excel.FileName;
                reporte.A_excel(DGV_datos, archivo);
            }
        }

        private void BT_nuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            Modo("A");
        }
                
        private void BT_cancelar_Click(object sender, EventArgs e)
        {
            Modo("C");
            if (TX_identidad.MaskCompleted)
            {
                Modo_consulta(TX_identidad.Text.ToString());
            }
            else
            {
                BT_editar.Enabled = false;
                Limpiar();
            }
            TC_persona.SelectedTab = TP_listar;
        }

        private void BT_guardar_Click(object sender, EventArgs e)
        {
            string identidad_persona = TX_identidad.Text.ToString();
            control.Consultar_persona(identidad_persona);
            Persona_modelo newper;

            if (LLenos())//verifica si no estan vacios
            {
                newper = Agregar_persona();

                if (Persona_modelo.Existe)
                {
                    DialogResult respuesta = MessageBox.Show("Se ha encontrado el ID " + this.TX_identidad.Text.ToString() +
                        ", desea actualizar los datos del registro", "Sistema Presupuestario",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        Boolean modifico = control.Actualizar_persona(newper);
                        if (modifico)
                        {
                            Cargar_grid();
                            Modo_consulta(identidad_persona);
                            Modo("C");
                        }

                    }
                    else
                    {
                        Modo_consulta(identidad_persona);
                        Modo("C");
                    }

                }
                // En caso que no exista se agrega
                else
                {
                    Boolean agrego = control.Añadir_persona(newper);
                    if (agrego)
                    {
                        MessageBox.Show("Persona " + newper.Nombre.ToString() + " agregado correctamente",
                        "Sistema Presupuestaria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cargar_grid();
                        Modo_consulta(newper.Identidad.ToString());
                        Modo("C");
                    }

                }
            }
            else
            {// Caso que no esten llenos los controles
                MessageBox.Show("Hay campos del registro sin ingresar, tu deberias saber esto",
               "Sistema Financiero Cooperativista", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
               
        private void BT_nuevo_mini_Click(object sender, EventArgs e)
        {
            TC_persona.SelectedTab = TP_administrar;
            Limpiar();
            Modo("A");
        }

        private void BT_editar_mini_Click(object sender, EventArgs e)
        {
            Limpiar();
            String identidad = DGV_datos.SelectedCells[0].Value.ToString();
            Modo_consulta(identidad);
            TC_persona.SelectedTab = TP_administrar;
            Modo("e");
        }

        private void BT_editar_Click(object sender, EventArgs e)
        {
            if (LLenos()) { Modo("E"); }
        }

        private void BT_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }       

        #endregion


    }
}
