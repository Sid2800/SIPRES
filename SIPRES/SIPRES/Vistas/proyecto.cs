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
    public partial class proyecto : Form
    {
         
        Control_proyecto control = new Control_proyecto();
        Proyecto_modelo proyectonew = new Proyecto_modelo();
        Reporte reporte = new Reporte();

        public proyecto()
        {
            InitializeComponent();
        }

        Boolean LLenos()
        {
            Boolean lleno;
            if (string.IsNullOrEmpty(TX_nombre.Text)
                || string.IsNullOrEmpty(TX_id_proy.Text)
                || string.IsNullOrEmpty(TX_identidad.Text)
                || string.IsNullOrEmpty(TX_nombre_p.Text)
                || string.IsNullOrEmpty(TX_estado.Text)
                || string.IsNullOrEmpty(TX_descripion.Text)
                )
            { lleno = false; }
            else { lleno = true; }
            return lleno;
        }

        void Limpiar()
        {
            this.TX_nombre.Clear();
            this.TX_id_proy.Clear();
            this.TX_identidad.Clear();
            this.TX_nombre_p.Clear();
            this.TX_estado.Text = "GRABACION";
            this.TX_descripion.Clear();                                 
            this.DT_inicio.Value = DateTime.Now;
            this.DT_fin.Value = DateTime.Now;
            this.TX_linea.Clear();
            this.RB_per.Checked = true;
            this.DGV_detalle.Columns.Clear();

        }

        #region Metodos de CArga

        void Selector_contenido() {
            if (RB_emp_b.Checked)
            {
                Cargar_grid_empresa();
            }
            else {
                Cargar_grid_persona();
            }

        }

        void Cargar_grid_persona()
        {
            control.Listar_proyecto("SELECT proyecto.id_proy as Codigo, proyecto.nombre as Proyecto, proyecto.descripcion as Descripcion, proyecto.estado as Estado," +
 "persona.nombre as Propietario, proyecto.tipo as Tipo,proyecto.fecha_ini as Inicio, proyecto.fecha_fin as Fin, " +
"proyecto.total as Total  FROM proyecto INNER JOIN persona On(persona.identidad = proyecto.identidad) ");
            this.DGV_datos.DataSource = Proyecto_modelo.Datos;
            
        }
        
        void Cargar_grid_empresa()
        {
            control.Listar_proyecto("SELECT proyecto.id_proy as Codigo, proyecto.nombre as Proyecto, proyecto.descripcion as Descripcion, proyecto.estado as Estado,"+
            "empresa.nombre as Propietario, proyecto.tipo as Tipo, proyecto.fecha_ini as Inicio, proyecto.fecha_fin as Fin," +
            "proyecto.total as Total  FROM proyecto INNER JOIN empresa On(empresa.id_emp = proyecto.id_emp)  ");
            this.DGV_datos.DataSource = Proyecto_modelo.Datos;
        }

        void Filtrar_datos()
        {
            Proyecto_modelo.Datos.DefaultView.RowFilter =
                $"Codigo + Proyecto + Estado + Propietario like'%" +
                TX_buscar.Text + "%'";
        }

        private void Proyecto_Load(object sender, EventArgs e)
        {
            
            RB_per_b.Checked = true;
            RB_per.Checked = true;
            Selector_contenido();
        }
        
        void Modo(string M)
        {
            switch (M)
            {
                case "C":
                case "c":
                    //Controles
                    TX_nombre.Enabled = false;
                    TX_id_proy.Enabled = false;
                    TX_estado.Enabled = false;
                    RB_per.Enabled = false;
                    RB_emp.Enabled = false;
                    TX_identidad.Enabled = false;
                    TX_descripion.Enabled = false;
                    DT_inicio.Enabled = false;
                    DT_fin.Enabled = false;
                   

                    // Deatalle Botones

                    BT_nuevo_d.Enabled = false;
                    BT_editar_d.Enabled = false;
                    BT_eliminar_d.Enabled = false;
                    BT_editar_d.Enabled = false;
                  

                    // Botones
                    BT_editar.Enabled = true;
                    BT_nuevo.Enabled = true;
                    BT_guardar.Enabled = false;
                    BT_cancelar.Visible = false;
                    break;

                case "E":
                case "e": // solo un administrador

                    //Controles
                    TX_nombre.Enabled = true;                                     
                    RB_per.Enabled = true;
                    RB_emp.Enabled = true;
                    TX_identidad.Enabled = true;
                    TX_descripion.Enabled = true;
                    DT_inicio.Enabled = true;
                    DT_fin.Enabled = true;

                  

                    // Deatalle Botones

                    BT_nuevo_d.Enabled = true;
                    BT_editar_d.Enabled = true;
                    BT_eliminar_d.Enabled = true;
                    BT_editar_d.Enabled = true;
                  
                    // Botones
                    BT_editar.Enabled = false;
                    BT_nuevo.Enabled = false;
                    BT_guardar.Enabled = true;
                    BT_cancelar.Visible = true;
                    break;

                case "A":
                case "a": // solo un administrador
                          //Controles
                    TX_nombre.Enabled = true;
                    RB_per.Enabled = true;
                    RB_emp.Enabled = true;
                    TX_identidad.Enabled = true;
                    TX_descripion.Enabled = true;
                    DT_inicio.Enabled = true;
                    DT_fin.Enabled = true;


                    // Deatalle Botones

                    BT_nuevo_d.Enabled = true;
                    BT_editar_d.Enabled = true;// ojo validacion
                    BT_eliminar_d.Enabled = true;// ojo validacion
                    BT_editar_d.Enabled = true;
                 

                    // Botones
                    BT_editar.Enabled = false;
                    BT_nuevo.Enabled = false;
                    BT_guardar.Enabled = true;
                    BT_cancelar.Visible = true;
                    TX_nombre.Focus();
                    break;

                default:
                    break;
            }

        }
        
        void Modo_consulta(string codigo, string mod)
        {
            Proyecto_modelo proyecto;
            //Detalle_modelo detalle;
            Control_detalle control_d = new Control_detalle();
            proyecto = new Control_proyecto().Consultar_proyecto(codigo,mod);
            if (Proyecto_modelo.Existe)
            {
                // Cargar Detalle
                control_d.Listar_detalle("SELECT  producto.id_pro as Codigo, producto.nombre as Articulo, producto.uni_med as Medida," +
                " producto.precio as Precio, detalle.cantidad as Cantidad, detalle.total as Total " +
                " FROM proyecto INNER JOIN detalle On(proyecto.id_proy = detalle.id_proy)  " +
                $" INNER JOIN producto On(producto.id_pro = detalle.id_pro) Where proyecto.id_proy = '{proyecto.Id_proy}'");
                DGV_detalle.DataSource = Detalle_modelo.Datos;

                switch (mod)
                {
                    case "P":
                        Persona_modelo persona;
                        persona = new Control_persona().Consultar_persona(proyecto.Identidad);
                        TX_identidad.Text = persona.Identidad.ToString();
                        TX_nombre_p.Text = persona.Nombre;
                        RB_per.Checked = true;
                        break;

                    case "E":
                        Empresa_modelo empresa;
                        empresa = new Control_empresa().Consultar_emp(proyecto.Id_emp.ToString());
                        TX_identidad.Text = empresa.Id_emp.ToString();
                        TX_nombre_p.Text = empresa.Nombre;
                        RB_emp.Checked = true;
                        break;

                    default:
                        break;
                }

                                             
                TX_nombre.Text = proyecto.Nombre;
                TX_id_proy.Text = proyecto.Id_proy.ToString();
                TX_estado.Text = proyecto.Estado;
                TX_descripion.Text = proyecto.Descripcion;
                DT_inicio.Value = proyecto.Fecha_ini;
                DT_fin.Value = proyecto.Fecha_fin;

                control.Crear_total($"SELECT  SUM(total) Suma_total FROM detalle Where detalle.id_proy = '{proyecto.Id_proy}'");
                TX_linea.Text = Proyecto_modelo.Ntotal.Rows[0][0].ToString();
                    

            }
            else
            {
                Limpiar();
            }

        }

        Proyecto_modelo Agregar_proyecto()
        {                       
            
            proyectonew.Nombre = this.TX_nombre.Text;
            proyectonew.Descripcion  = this.TX_descripion.Text;
            proyectonew.Estado = this.TX_estado.Text;
            proyectonew.Fecha_ini = DT_inicio.Value;
            proyectonew.Fecha_fin = DT_fin.Value;
            if (RB_emp.Checked)
            {
                proyectonew.Id_emp = int.Parse(this.TX_identidad.Text);
                proyectonew.Tipo = "EMPRESA";
            }
            else
            {
                proyectonew.Identidad = this.TX_identidad.Text;
                proyectonew.Tipo = "PERSONAL";

            }


     
            return proyectonew;
        }


        #endregion


        #region Metodos con Obejetos

        private void RB_emp_b_CheckedChanged(object sender, EventArgs e)
        {
            Selector_contenido();
            TX_buscar.Clear();
        }

        private void RB_per_b_CheckedChanged(object sender, EventArgs e)
        {
            Selector_contenido();
            TX_buscar.Clear();
        }

        private void TX_buscar_TextChanged(object sender, EventArgs e)
        {
            Filtrar_datos();

        }

        public void BT_limpiar_Click(object sender, EventArgs e)
        {
            TX_buscar.Clear();
            TX_buscar.Focus();
        }

        private void TC_proyecto_Selected(object sender, TabControlEventArgs e)
        {
            string codigo = TX_id_proy.Text;
            Modo("C");
            if (string.IsNullOrEmpty(codigo))
            {
                BT_editar.Enabled = false;
                Limpiar();
            }
            else {                             
                    Limpiar();

                    if (RB_emp_b.Checked)
                    {
                        Modo_consulta(codigo, "E");
                    }
                    else
                    {
                        Modo_consulta(codigo, "P");
                    }
                    Modo("c");
                
            }
        }

        private void DGV_datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Limpiar();
            string codigo = DGV_datos.SelectedCells[0].Value.ToString();
            if (string.IsNullOrEmpty(codigo))
            {

            }
            else
            {
                Limpiar();

                if (RB_emp_b.Checked)
                {
                    Modo_consulta(codigo, "E");
                }
                else
                {
                    Modo_consulta(codigo, "P");
                }
                Modo("c");
            }
            TC_proyecto.SelectedTab = TP_administrar;
        }
        
        #endregion

        #region Metodos con botones

        private void BT_editar_mini_Click(object sender, EventArgs e)
        {
            string codigo = DGV_datos.SelectedCells[0].Value.ToString();            
            if (string.IsNullOrEmpty(codigo))
            {
                
            }
            else {
                Limpiar();

                if (RB_emp_b.Checked)
                {
                    Modo_consulta(codigo, "E");
                }
                else
                {
                    Modo_consulta(codigo, "P");
                }
                
                TC_proyecto.SelectedTab = TP_administrar;
                Modo("e");
            }                                                               
        }

        private void BT_ver_Click(object sender, EventArgs e)
        {
            string codigo = DGV_datos.SelectedCells[0].Value.ToString();
            if (string.IsNullOrEmpty(codigo))
            {

            }
            else
            {
                Limpiar();

                if (RB_emp_b.Checked)
                {
                    Modo_consulta(codigo, "E");
                }
                else
                {
                    Modo_consulta(codigo, "P");
                }
                Modo("c");
            }
            TC_proyecto.SelectedTab = TP_administrar;
        }





        #endregion

        private void TX_identidad_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TX_identidad.Text) == false)
            {
                string identidad = TX_identidad.Text;
                Persona_modelo Per;
                Empresa_modelo Emp;
                Boolean existe;
                if (RB_emp.Checked)
                {
                    Emp = new Control_empresa().Consultar_emp(identidad);
                    if (Empresa_modelo.Existe)
                    {
                        TX_nombre_p.Text = Emp.Nombre;
                    }
                    else {
                        MessageBox.Show("El codigo de empresa no existe,  corrije losa datos ingresados",
                  "Sistema Presupuestario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TX_identidad.Clear();
                        TX_identidad.Focus();
                    }
                }
                else
                {
                    Per = new Control_persona().Consultar_persona(identidad);
                    if (Persona_modelo.Existe)
                    {
                        TX_nombre_p.Text = Per.Nombre;
                    }
                    else
                    {
                        MessageBox.Show("La identidad de la persona no existe,  corrije los datos ingresados",
                  "Sistema Presupuestario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TX_identidad.Clear();
                        TX_identidad.Focus();
                    }
                }                         
               
            

            }
        }

        private void RB_per_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_per.Checked)
            {
                TX_identidad.Mask = "0000-0000-00000";
                TX_nombre_p.Clear();
            }
        }

        private void RB_emp_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_emp.Checked)
            {
                TX_identidad.Mask = "000000";
                TX_nombre_p.Clear();

            }
        }

        private void BT_nuevo_mini_Click(object sender, EventArgs e)
        {
        
        }

        private void BT_excel_Click(object sender, EventArgs e)
        {
           
        }

        private void BT_nuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            Modo("A");
        }

        private void BT_editar_Click(object sender, EventArgs e)
        {
            if (LLenos()) { Modo("E"); }
        }

        private void BT_cancelar_Click(object sender, EventArgs e)
        {
       
            if (string.IsNullOrEmpty(TX_id_proy.Text))
            {
                Limpiar();
            }
            else
            {
                Limpiar();

                if (RB_emp_b.Checked)
                {
                    Modo_consulta(TX_id_proy.Text, "E");
                }
                else
                {
                    Modo_consulta(TX_id_proy.Text, "P");
                }
               
            }
            Modo("c");
        }

        private void BT_nuevo_d_Click(object sender, EventArgs e)
        {
            Detalle detalle = new Detalle();
            detalle.Padre = this;
            detalle.Show();
        }

        public void Cargar_grid_detalle() {
        }
    }
}
