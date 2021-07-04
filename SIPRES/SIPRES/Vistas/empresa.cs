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
    public partial class empresa : Form
    {
        Control_empresa control = new Control_empresa();
        Reporte reporte = new Reporte();
        Empresa_modelo empnew = new Empresa_modelo();
        private seleccion seleccion_f = null;

        public empresa()
        {
            InitializeComponent();
        }

        Boolean LLenos()
        {
            Boolean lleno;
            if (TX_rtn.MaskCompleted == false
                || string.IsNullOrEmpty(TX_nombre.Text)
                || string.IsNullOrEmpty(TX_tell_e.Text)
                || string.IsNullOrEmpty(TX_correo.Text)
                || string.IsNullOrEmpty(TX_direccion.Text)
                || string.IsNullOrEmpty(TX_identidad.Text)
                )
            { lleno = false; }
            else { lleno = true; }
            return lleno;
        }

        void Limpiar()
        {
            this.TX_identidad.Clear();
            this.TX_tell.Clear();
            this.TX_nombre.Clear();
            this.TX_apellido.Clear();
            this.TX_correo.Clear();

            this.TX_id_emp.Clear();
            this.TX_rtn.Clear();
            this.TX_nombre_e.Clear();
            this.TX_tell_e.Clear();
            this.TX_correo_e.Clear();
            this.TX_direccion.Clear();
        }


        #region Metodos de Carga
   
        private void Empresa_Load(object sender, EventArgs e)
        {
            Cargar_grid();
        }

        public void Verificar_identidad()
        {
            if (TX_identidad.MaskCompleted == true)
            {
                string identidad = TX_identidad.Text;
                Persona_modelo Var;
                Var = new Control_persona().Consultar_persona(identidad);

                Boolean existe = Persona_modelo.Existe;
                if (existe)
                {
                    TX_identidad.Text = Var.Identidad;
                    TX_nombre.Text = Var.Nombre;
                    TX_apellido.Text = Var.Apellido;
                    TX_tell.Text = Var.Tel_cell;
                    TX_correo.Text = Var.Correo;
                }
                else
                {
                    MessageBox.Show("La identidad ingresada no existe, agrega esta identidad o corrije",
                   "Sistema presupuestario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TX_identidad.Clear();
                    TX_identidad.Focus();
                }
            }
        }
        
        void Cargar_grid()
        {
            control.Listar_emp("SELECT  empresa.id_emp as Codigo, empresa.nombre as Empresa, empresa.rtn as RTN, empresa.telefono as Telefono," +
                "empresa.direccion as Direccion, empresa.correo as Correo,persona.identidad as Ident_Cont,persona.nombre as Nombre_Cont, persona.apellido as Apellido_Cont, persona.tel_cell as Telefono_Cont," +
                " persona.correo as Correo_Cont 	FROM empresa INNER JOIN persona on(empresa.id_contacto = persona.identidad)");
            this.DGV_datos.DataSource = Empresa_modelo.Datos;
        }

        void Filtrar_datos()
        {
            Empresa_modelo.Datos.DefaultView.RowFilter =
                 $"Codigo + Empresa + Direccion + Ident_Cont + Nombre_Cont like'%" +
                 TX_buscar.Text + "%'";
        }

        void Modo(string M)
        {
            switch (M)
            {
                case "C":
                case "c":
                    //Controles
                    TX_id_emp.ReadOnly = true;
                    TX_rtn.ReadOnly = true;
                    TX_nombre_e.ReadOnly = true;
                    TX_tell_e.ReadOnly = true;
                    TX_correo_e.ReadOnly = true;
                    TX_direccion.ReadOnly = true;
                    TX_identidad.ReadOnly = true;
                    // Botones
                    BT_editar.Enabled = true;
                    BT_nuevo.Enabled = true;
                    BT_guardar.Enabled = false;
                    BT_cancelar.Visible = false;
                    break;

                case "E":
                case "e": // solo un administrador
                          //Controles                      

                    TX_rtn.ReadOnly = false;
                    TX_nombre_e.ReadOnly = false;
                    TX_tell_e.ReadOnly = false;
                    TX_correo_e.ReadOnly = false;
                    TX_direccion.ReadOnly = false;
                    TX_identidad.ReadOnly = false;
                    // Botones
                    BT_editar.Enabled = false;
                    BT_nuevo.Enabled = false;
                    BT_guardar.Enabled = true;
                    BT_cancelar.Visible = true;
                    break;

                case "A":
                case "a": // solo un administrador
                    TX_rtn.ReadOnly = false;
                    TX_nombre_e.ReadOnly = false;
                    TX_tell_e.ReadOnly = false;
                    TX_correo_e.ReadOnly = false;
                    TX_direccion.ReadOnly = false;
                    TX_identidad.ReadOnly = false;
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

        void Modo_consulta(string Idemp)
        {
            Empresa_modelo Var;
            Persona_modelo per;
            Var = new Control_empresa().Consultar_emp(Idemp);
            per = new Control_persona().Consultar_persona(Var.Id_contacto);
            Boolean existe = Empresa_modelo.Existe;
            if (existe)
            {
                TX_id_emp.Text = Var.Id_emp.ToString();
                TX_rtn.Text = Var.Rtn;
                TX_nombre_e.Text = Var.Nombre;
                TX_tell_e.Text = Var.Telefono;
                TX_correo_e.Text = Var.Correo;
                TX_direccion.Text = Var.Direccion;

                //Persona
                TX_identidad.Text = Var.Id_contacto;
                TX_nombre.Text = per.Nombre;
                TX_apellido.Text = per.Apellido;
                TX_tell.Text = per.Tel_cell;
                TX_correo.Text = per.Correo;
            }
            else
            {
                Limpiar();
            }
        }

        Empresa_modelo Agregar_empresa()
        {
            empnew.Id_emp = int.Parse(this.TX_id_emp.Text);
            empnew.Rtn = this.TX_rtn.Text;
            empnew.Nombre = this.TX_nombre_e.Text;
            empnew.Telefono = this.TX_tell_e.Text;
            empnew.Correo = this.TX_correo_e.Text;
            empnew.Direccion = this.TX_direccion.Text;
            empnew.Id_contacto = this.TX_identidad.Text;
            return empnew;
        }

        #endregion


        #region Metodos de Objetos

        private void TX_identidad_DoubleClick(object sender, EventArgs e)
        {

            seleccion frm = this.FormInstance;
            frm.Text = "Seleccion de Personas";
            frm.Show();
            frm.BringToFront();
        }
        private void TC_empresa_Selected(object sender, TabControlEventArgs e)
        {
            Modo("C");
            if (string.IsNullOrEmpty(TX_id_emp.Text))
            {
                BT_editar.Enabled = false;
                Limpiar();
            }
            else
            {
                Modo_consulta(TX_id_emp.Text.ToString());
            }
        }

        private void TX_buscar_TextChanged(object sender, EventArgs e)
        {
            Filtrar_datos();
        }

        private void DGV_datos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Limpiar();
            String Idusu = DGV_datos.SelectedCells[0].Value.ToString();
            Modo_consulta(Idusu);
            TC_empresa.SelectedTab = TP_administrar;
            Modo("c");
        }

        private void TX_identidad_Leave(object sender, EventArgs e)
        {
            Verificar_identidad();
        }


        #endregion


        #region Metodos Botones

        private void BT_limpiar_Click(object sender, EventArgs e)
        {
            TX_buscar.Clear();
            TX_buscar.Focus();
        }

        private void BT_pdf_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToShortDateString();
            string fechaarch = fecha.Replace('/', '_');

            SFD_pdf.FileName = "Listado_Empresas" + fechaarch + ".pdf";


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

            SFD_excel.FileName = "Listado_Empresas" + fechaarch + ".csv";


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
            if (string.IsNullOrEmpty(TX_id_emp.Text))
            {
                BT_editar.Enabled = false;
                Limpiar();
            }
            else
            {
                Modo_consulta(TX_id_emp.Text.ToString());
            }
            TC_empresa.SelectedTab = TP_listar;
        }

        private void BT_editar_Click(object sender, EventArgs e)
        {
            if (LLenos()) { Modo("E"); }
        }

        private void BT_guardar_Click(object sender, EventArgs e)
        {
            string idemp = TX_id_emp.Text.ToString();
            Empresa_modelo newemp;
            if (LLenos())//verifica si no estan vacios
            {
                newemp = Agregar_empresa();
                control.Consultar_emp(idemp);
                if (Empresa_modelo.Existe)
                {
                    DialogResult respuesta = MessageBox.Show("Se ha encontrado el ID " + idemp +
                        ", desea actualizar los datos del registro", "Sistema Presupuestario",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        Boolean modifico = control.Actualizar_emp(newemp);
                        if (modifico)
                        {

                            Cargar_grid();
                            Modo_consulta(idemp);
                            Modo("C");
                        }
                    }
                    else
                    {

                        Modo_consulta(idemp);
                        Modo("C");
                    }
                }
                // En caso que no exista se agrega
                else
                {
                    Boolean agrego = control.Añadir_emp(newemp);
                    if (agrego)
                    {
                        MessageBox.Show("Empresa " + newemp.Nombre.ToString() + " agregado correctamente",
                        "Sistema Presupuestario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cargar_grid();
                        Modo_consulta(newemp.Id_emp.ToString());
                        Modo("C");
                    }
                }
            }
            else
            {// Caso que no esten llenos los controles
                MessageBox.Show("Hay campos del registro sin ingresar, tu deberias saber esto",
               "Sistema Presupuestario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BT_nuevo_mini_Click(object sender, EventArgs e)
        {
            TC_empresa.SelectedTab = TP_administrar;
            Limpiar();
            Modo("A");
        }

        private void BT_editar_mini_Click(object sender, EventArgs e)
        {
            Limpiar();
            String id_emp = DGV_datos.SelectedCells[0].Value.ToString();
            Modo_consulta(id_emp);
            TC_empresa.SelectedTab = TP_administrar;
            Modo("e");
        }

        private void BT_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        #endregion      


        #region Metodos Cargar formulario               
        private seleccion FormInstance
        {
            get
            {
                if (seleccion_f == null)
                {

                    seleccion_f = new seleccion("persona");
                    seleccion_f.P_empresa = this;
                    seleccion_f.Disposed += new EventHandler(form_Disposed);
                }
                return seleccion_f;
            }
        }

        void form_Disposed(object sender, EventArgs e)
        {
            seleccion_f = null;
        }

        public void Cargar_consultado()
        {
            if (!string.IsNullOrEmpty(Consultas.Var))
            {
                TX_identidad.Text = Consultas.Var;
                Verificar_identidad();
            }
        }                     

        #endregion

    
    }
}
