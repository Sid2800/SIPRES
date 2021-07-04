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
    public partial class usuario : Form
    {
        Control_usuario control = new Control_usuario();
        Reporte reporte = new Reporte();
        Usuario_modelo usuarionew = new Usuario_modelo();
        Control_rol C_rol = new Control_rol();
        private seleccion seleccion_f = null;
  
        public usuario()
        {
            InitializeComponent();
        }

        Boolean LLenos()
        {
            Boolean lleno;
            if (TX_identidad.MaskCompleted == false
                || string.IsNullOrEmpty(TX_id_usu.Text)
                || string.IsNullOrEmpty(CB_rol.Text)
                || string.IsNullOrEmpty(TX_contra.Text)
                || string.IsNullOrEmpty(TX_confir.Text)
                )
            { lleno = false; }
            else { lleno = true; }
            return lleno;
        }

        Boolean Verificar_contra()
        {
            string contra = TX_contra.Text;
            string confirm = TX_confir.Text;
            Boolean conciden = false;


            if (string.IsNullOrEmpty(contra) || string.IsNullOrEmpty(confirm))
            {
            }
            else
            {
                if (contra == confirm)
                {
                    LB_indicador.Text = "Los Datos Coinciden";
                    LB_indicador.ForeColor = System.Drawing.Color.Green;
                    conciden = true;
                }
                else
                {
                    LB_indicador.Text = "Los Datos NO Coinciden";
                    LB_indicador.ForeColor = System.Drawing.Color.Red;
                    conciden = false;

                }
            }

            return conciden;
        }               

        void Limpiar()
        {
            this.TX_identidad.Clear();
            this.TX_nombre.Clear();
            this.TX_apellido.Clear();
            this.DT_nacimiento.Value = DateTime.Now;
            this.CB_sexo.Text = "";
            this.TX_edad.Clear();
            var timeSpan = DateTime.Now - DT_nacimiento.Value;
            int anios = (timeSpan.Days / 365);
            TX_edad.Text = anios.ToString() + " Años";
            this.TX_id_usu.Clear();
            this.CB_rol.Text = "";
            this.TX_contra.Clear();
            this.TX_confir.Clear();
            this.CB_activo.Checked = false;
            this.LB_indicador.Text = "";

        }

        #region Metodos de Carga

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
                    Boolean id_con_usu = new Control_usuario().ExistenciaUsuario(identidad);

                    if (id_con_usu)
                    {
                        MessageBox.Show("La identidad ingresada ya tiene un usuario asignado, agrega una nueva identidad o corrije",
                   "Sistema Financiero Cooperativista", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        TX_identidad.Clear();
                        TX_identidad.Focus();
                        this.TX_nombre.Clear();
                        this.TX_apellido.Clear();
                        this.DT_nacimiento.Value = DateTime.Now;
                        this.CB_sexo.Text = "";
                        this.TX_edad.Clear();
                    }

                    else
                    {

                        TX_identidad.Text = Var.Identidad;
                        TX_nombre.Text = Var.Nombre;
                        TX_apellido.Text = Var.Apellido;
                        DT_nacimiento.Value = Var.F_nacimiento;
                        CB_sexo.Text = Var.Genero;
                        var timeSpan = DateTime.Now - Var.F_nacimiento;
                        int anios = (timeSpan.Days / 365);
                        TX_edad.Text = anios.ToString() + " Años";

                        // Generar el ID USaurio
                        string parteid = TX_identidad.Text.Substring(10, 5);
                        string partenombre = TX_nombre.Text.Substring(0, 1);
                        string parteapellido = TX_apellido.Text.Substring(0, 5);

                        TX_id_usu.Text = parteid + "_" + partenombre + parteapellido;

                    }
                }
                else
                {
                    MessageBox.Show("La identidad ingresada no existe, agrega esta identidad o corrije",
                   "Sistema Presupuestario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TX_identidad.Clear();
                    TX_identidad.Focus();
                }

            }

        }

        public void Cargar_consultado()
        {
            if (!string.IsNullOrEmpty(Consultas.Var))
            {
                TX_identidad.Text = Consultas.Var;
                Verificar_identidad();
            }

        }     

        private void Usuario_Load(object sender, EventArgs e)
        {
            Cargar_grid();
            Cargar_combo();
        }

        void Cargar_grid()
        {       
         control.Listar_usuario("SELECT  usuario.id_usu as ID_usuario, usuario.id_rol as ID_rol, rol_usuario.rol as Rol,rol_usuario.niv_acce as Acceso,usuario.activo as Activo,persona.identidad as Identidad,persona.nombre as Nombre," +
                "persona.apellido as Apellido FROM persona INNER JOIN usuario On(persona.identidad = usuario.identidad) INNER JOIN rol_usuario On (usuario.id_rol = rol_usuario.id_rol)");
            this.DGV_datos.DataSource = Usuario_modelo.Datos;
        }

        void Filtrar_datos()
        {
            Usuario_modelo.Datos.DefaultView.RowFilter =
                $"ID_usuario + Rol + Activo + Identidad + Nombre like'%" +
                TX_buscar.Text + "%'";
        }

        void Modo(string M)
        {
            switch (M)
            {
                case "C":
                case "c":
                    //Controles
                    TX_identidad.Enabled = false;
                    TX_id_usu.Enabled = false;
                    TX_contra.ReadOnly = true;
                    TX_confir.ReadOnly = true;
                    CB_rol.Enabled = false;
                    CB_activo.Enabled = false;
                    // Botones
                    BT_editar.Enabled = true;
                    BT_nuevo.Enabled = true;
                    BT_guardar.Enabled = false;
                    BT_cancelar.Visible = false;
                    break;

                case "E":
                case "e": // solo un administrador
                          //Controles
                          // TX_identidad.ReadOnly = false;
                    TX_identidad.Enabled = false;
                    TX_id_usu.Enabled = true;
                    TX_contra.ReadOnly = false;
                    TX_confir.ReadOnly = false;
                    CB_rol.Enabled = true;
                    CB_activo.Enabled = true;
                    // Botones
                    BT_editar.Enabled = false;
                    BT_nuevo.Enabled = false;
                    BT_guardar.Enabled = true;
                    BT_cancelar.Visible = true;
                    break;

                case "A":
                case "a": // solo un administrador
                    TX_identidad.Enabled = true;
                    TX_id_usu.Enabled = true;
                    TX_contra.ReadOnly = false;
                    TX_confir.ReadOnly = false;
                    CB_rol.Enabled = true;
                    CB_activo.Enabled = true;
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

        void Modo_consulta(string IdUsuario)
        {
            Persona_modelo Var;
            Usuario_modelo User;
            Rol_modelo Rol;
            User = new Control_usuario().Consultar_usuario(IdUsuario);
            Var = new Control_persona().Consultar_persona(User.Identidad);
            Rol = new Control_rol().Consultar_rol(User.Id_rol);
            Boolean existe = Usuario_modelo.Existe;
            if (existe)
            {
                TX_identidad.Text = Var.Identidad;
                TX_nombre.Text = Var.Nombre;
                TX_apellido.Text = Var.Apellido;
                DT_nacimiento.Value = Var.F_nacimiento;
                CB_sexo.Text = Var.Genero;
                var timeSpan = DateTime.Now - Var.F_nacimiento;
                int anios = (timeSpan.Days / 365);
                TX_edad.Text = anios.ToString() + " Años";
                /// Datos de Usuario
                TX_id_usu.Text = User.Id_usu;
                CB_activo.Checked = User.Activo;           
                CB_rol.Text = Rol.Rol;
                TX_contra.Text = User.Contra;
                TX_confir.Text = User.Contra;
            }
            else
            {
                Limpiar();
            }
        }

        Usuario_modelo Agregar_usuario()
        {
            Rol_modelo Rol;         
            Rol = new Control_rol().Consultar_rol_rol(CB_rol.Text);                     
            usuarionew.Identidad = this.TX_identidad.Text;
            usuarionew.Id_usu = this.TX_id_usu.Text;
            usuarionew.Int_log = 0;
            usuarionew.Contra = this.TX_contra.Text;
            usuarionew.Activo = this.CB_activo.Checked;
            usuarionew.Id_rol = Rol.Id_rol;
            return usuarionew;
        }

        void Cargar_combo() {

            C_rol.Listar_rol("select * from rol_usuario");
            CB_rol.DataSource = Rol_modelo.Datos;
            CB_rol.DisplayMember = "rol_usuario";
            CB_rol.ValueMember = "rol";
            CB_rol.Text = "";

        }


        #endregion
             
        #region Metodos con objetos

        private void TC_usuario_Selected(object sender, TabControlEventArgs e)
        {
            Modo("C");
            if (string.IsNullOrEmpty(TX_id_usu.Text))
            {
                BT_editar.Enabled = false;
                Limpiar();
            }
            else
            {
                Modo_consulta(TX_id_usu.Text.ToString());
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
            TC_usuario.SelectedTab = TP_administrar;
            Modo("c");
        }

        private void TX_identidad_Leave(object sender, EventArgs e)
        {

            Verificar_identidad();
        }

        private void TX_confir_Leave(object sender, EventArgs e)
        {
            Verificar_contra();
        }

        #endregion

        #region Metodos de Botones

        private void BT_limpiar_Click(object sender, EventArgs e)
        {
            TX_buscar.Clear();
            TX_buscar.Focus();
        }

        private void BT_pdf_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToShortDateString();
            string fechaarch = fecha.Replace('/', '_');

            SFD_pdf.FileName = "Listado_Usuarios" + fechaarch + ".pdf";


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
            if (string.IsNullOrEmpty(TX_id_usu.Text))
            {
                BT_editar.Enabled = false;
                Limpiar();
            }
            else
            {
                Modo_consulta(TX_id_usu.Text.ToString());
            }
            TC_usuario.SelectedTab = TP_listar;
        }

        private void BT_editar_Click(object sender, EventArgs e)
        {
            if (LLenos()) { Modo("E"); }
        }

        private void BT_guardar_Click(object sender, EventArgs e)
        {
            string idusu = TX_id_usu.Text.ToString();
            control.Consultar_usuario(idusu);

            Usuario_modelo newuser;

            if (LLenos())//verifica si no estan vacios
            {
                if (Verificar_contra())
                {
                    C_rol.Consultar_rol_rol(CB_rol.Text);
                    if (Rol_modelo.Existe) // Verificamos la existencia de rango
                    {

                        newuser = Agregar_usuario();

                        control.Consultar_usuario(idusu);
                        if (Usuario_modelo.Existe)
                        {
                            DialogResult respuesta = MessageBox.Show("Se ha encontrado el ID " + idusu +
                                ", desea actualizar los datos del registro", "Sistema Presupuestario",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (respuesta == DialogResult.Yes)
                            {
                                Boolean modifico = control.Actualizar_usuario(newuser);
                                if (modifico)
                                {
                                    Cargar_grid();
                                    Modo_consulta(idusu);
                                    Modo("C");
                                }
                            }
                            else
                            {
                                Modo_consulta(idusu);
                                Modo("C");
                            }
                        }
                        // En caso que no exista se agrega
                        else
                        {
                            Boolean agrego = control.Añadir_usuario(newuser);
                            if (agrego)
                            {
                                MessageBox.Show("Usuario " + newuser.Id_usu.ToString() + " agregado correctamente",
                                "Sistema Presupuestario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Cargar_grid();
                                Modo_consulta(newuser.Identidad.ToString());
                                Modo("C");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("El rango ingresado no esta en base de datos, elige uno de los listados",
               "Sistema Presupuestario", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }


                }
                else
                {
                    MessageBox.Show("Las Contraseñas no Coinciden, tu deberias saber esto",
               "Sistema Presupuestario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            TC_usuario.SelectedTab = TP_administrar;
            Limpiar();
            Modo("A");
        }

        private void BT_editar_mini_Click(object sender, EventArgs e)
        {
            Limpiar();
            String identidad = DGV_datos.SelectedCells[0].Value.ToString();
            Modo_consulta(identidad);
            TC_usuario.SelectedTab = TP_administrar;
            Modo("e");
        }

        private void BT_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion        

        #region Metodos Cargar formulario

        private void TX_identidad_DoubleClick(object sender, EventArgs e)
        {
       
            seleccion frm = this.FormInstance;
            frm.Text = "Seleccion de Personas";
            frm.Show();
            frm.BringToFront();
        }

        private seleccion FormInstance
        {
            
            get
            {
                if (seleccion_f == null)
                {

                    seleccion_f = new seleccion("persona");
                    seleccion_f.P_usuario = this;
                    seleccion_f.Disposed += new EventHandler(form_Disposed);
                }

                return seleccion_f;
            }
        }

        void form_Disposed(object sender, EventArgs e)
        {
            seleccion_f = null;
        }

        #endregion

      


    }
}
