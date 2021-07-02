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
        Control_detalle crt_detalle = new Control_detalle();
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
                || string.IsNullOrEmpty(TX_identidad.Text)
                || string.IsNullOrEmpty(TX_nombre_p.Text)
                || string.IsNullOrEmpty(TX_estado.Text)
                || string.IsNullOrEmpty(TX_descripion.Text)
                || DGV_detalle.Rows.Count < 1
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
            if (Detalle_modelo.Datos!=null)
            {
                Detalle_modelo.Datos.Columns.Clear();
                Detalle_modelo.Datos = null;
            }
                                             

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
                    BT_eliminar_d.Enabled = false;
                   
                  

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
                    //RB_per.Enabled = true;
                   // RB_emp.Enabled = true;
                    TX_identidad.Enabled = true;
                    TX_descripion.Enabled = true;
                    DT_inicio.Enabled = true;
                    DT_fin.Enabled = true;

                  

                    // Deatalle Botones

                    BT_nuevo_d.Enabled = true;                   
                    BT_eliminar_d.Enabled = true;
                    
                  
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
                    BT_eliminar_d.Enabled = true;// ojo validacion
                
                 

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
            
            proyecto = new Control_proyecto().Consultar_proyecto(codigo,mod);
            if (Proyecto_modelo.Existe)
            {
                // Cargar Detalle
                Cargar_grid_detalle(proyecto.Id_proy.ToString());

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
            if (string.IsNullOrEmpty(this.TX_id_proy.Text)!=true)
            {
                proyectonew.Id_proy = int.Parse(this.TX_id_proy.Text);
            }           
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
                          
                proyectonew.Total =0;          


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
                Empresa_modelo Emp;      //55          
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
                        TX_nombre_p.Clear();
                        //TX_identidad.Focus();
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
                        TX_nombre_p.Clear();

                        //TX_identidad.Focus();
                    }
                }                         
               
            

            }
        }

        private void RB_per_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_per.Checked)
            {
                TX_identidad.Mask = "0000-0000-00000";
                //TX_nombre_p.Clear();             

            }
        }

        private void RB_emp_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_emp.Checked)
            {
                TX_identidad.Mask = "000000";
               // TX_nombre_p.Clear();           
            }
        }

        private void BT_nuevo_mini_Click(object sender, EventArgs e)
        {
            TC_proyecto.SelectedTab = TP_administrar;
            Limpiar();
            Modo("A");
        }

        private void BT_excel_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToShortDateString();
            string fechaarch = fecha.Replace('/', '_');

            SFD_excel.FileName = "Listado_Proyectos" + fechaarch + ".csv";


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

        private void BT_editar_Click(object sender, EventArgs e)
        {
            string codigo = TX_id_proy.Text;
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
                               
                Modo("e");
            }
        }
        private void BT_cancelar_Click(object sender, EventArgs e)
        {
       
            if (string.IsNullOrEmpty(TX_id_proy.Text))
            {
                Limpiar();
                BT_editar.Enabled = false;
                TC_proyecto.SelectedTab = TP_listar;
        
            }
            else
            {               
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
            Detalle detalle = new Detalle
            {
                Padre = this
            };
            detalle.Show();
        }

        public void Cargar_grid_detalle(string Id_proy) {
            Control_detalle control_d = new Control_detalle();
            control_d.Listar_detalle("SELECT  producto.id_pro as Codigo, producto.nombre as Articulo, producto.uni_med as Medida," +
             " producto.precio as Precio, detalle.cantidad as Cantidad, detalle.total as Total " +
             " FROM proyecto INNER JOIN detalle On(proyecto.id_proy = detalle.id_proy)  " +
             $" INNER JOIN producto On(producto.id_pro = detalle.id_pro) Where proyecto.id_proy = '{Id_proy}'");
            DGV_detalle.DataSource = Detalle_modelo.Datos;

        }
        public void Cargar_grid_detalle()
        {            
            DGV_detalle.DataSource = Detalle_modelo.Datos;

        }

        private void BT_eliminar_d_Click(object sender, EventArgs e)
        {
            if (Detalle_modelo.Datos != null && DGV_detalle.Rows.Count >= 1)
            {
                string valor_se = DGV_detalle.SelectedCells[0].Value.ToString();

                DialogResult respuesta = MessageBox.Show($"Esta Seguro de eliminar el producto {DGV_detalle.SelectedCells[1].Value.ToString()}, " +
                    $"Eliminar registro", "Sistema Presupuestario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {

                    for (int i = 0; i < Detalle_modelo.Datos.Rows.Count; i++)
                    {
                        if (valor_se == Detalle_modelo.Datos.Rows[i][0].ToString())
                        {
                            Detalle_modelo.Datos.Rows.Remove(Detalle_modelo.Datos.Rows[i]);
                            Cargar_grid_detalle();
                        }
                    }

                }
            }
        }

        private void BT_salir_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void BT_guardar_Click(object sender, EventArgs e)
        {
            string id_proy = TX_id_proy.Text.ToString();            
            if (LLenos())
            {
                
                control.Consultar_proyecto2(id_proy);

                proyectonew = Agregar_proyecto();
                if (Proyecto_modelo.Existe)
                {
                    DialogResult respuesta = MessageBox.Show("Se ha encontrado el ID " + id_proy +
                                ", desea actualizar los datos del registro", "Sistema Presupuestario",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        Boolean modifico = false;
                        Boolean act_detalle= false;
                        if (RB_emp.Checked)
                        {  modifico = control.Actualizar_proyecto(proyectonew, "E"); }
                        else
                        {  modifico = control.Actualizar_proyecto(proyectonew, "P"); }


                        if (modifico)
                        {

                            act_detalle = crt_detalle.Reemplazar_detalle(Detalle_modelo.Datos, id_proy);
                            if (act_detalle)
                            {

                            }
                                                                                                          
                           // RB_per_b.Checked = true;
                            Selector_contenido();
                            if (RB_emp_b.Checked)
                            { Modo_consulta(proyectonew.Id_proy.ToString(), "E"); }
                            else
                            { Modo_consulta(proyectonew.Id_proy.ToString(), "P"); }
                            Modo("c");


                        }
                        else
                        {
                            //MessageBox.Show("No modifico ni mierda");
                        }
                    }
                    else
                    {
                        if (RB_emp_b.Checked)
                        { Modo_consulta(id_proy, "E"); }
                        else
                        { Modo_consulta(id_proy, "P"); }
                        Modo("c");
                    }



                }
                else/// Si no exixte el proyecto lo agrega
                {
                    Boolean agrego = false;
                    Boolean act_detalle = false;

                    if (RB_emp.Checked)
                    { agrego = control.Añadir_proyecto(proyectonew, "E"); }
                    else
                    { agrego = control.Añadir_proyecto(proyectonew, "P"); }


                    
                    if (agrego)
                    {
                        MessageBox.Show("Proyecto " + proyectonew.Nombre.ToString() + " agregado correctamente",
                        "Sistema Presupuestario", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        control.Ultimo_registro("SELECT id_proy FROM proyecto WHERE proyecto.id_proy=(SELECT MAX(id_proy)FROM proyecto)");


                        act_detalle = crt_detalle.Reemplazar_detalle(Detalle_modelo.Datos, Proyecto_modelo.Ultimo.Rows[0][0].ToString());
                        if (act_detalle)
                        {

                        }

                        // RB_per_b.Checked = true;
                        Selector_contenido();
                        if (RB_emp_b.Checked)
                        { Modo_consulta(proyectonew.Id_proy.ToString(), "E"); }
                        else
                        { Modo_consulta(proyectonew.Id_proy.ToString(), "P"); }
                        Modo("c");


                    }
                    else
                    {
                        //MessageBox.Show("No agrego ni mierda");
                    }


                }



            }
            else
            {// Caso que no esten llenos los controles
                MessageBox.Show("Hay campos del registro sin ingresar, tu deberias saber esto",
               "Sistema Presupuestario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        Proyecto_modelo Llena_comprobante(string codigo, string modo)
        {
            Proyecto_modelo proyecto;
             proyecto = new Control_proyecto().Consultar_proyecto(codigo,modo);

            if (Proyecto_modelo.Existe)
            {
                Proyecto_modelo persona;
                Empresa_modelo empresa;
                Usuario_modelo usuario;
                
                switch (proyecto.Tipo)
                {
                    case "PERSONAL":
                       persona = new persona


                        break;
                    case "EMPRESA":
                        



                        break;

                    default:
                        break;
                }






                Cuenta_modelo cuentaprocente, cuentabase;

                cuentabase = new Control_cuenta().Consultar_cuenta2(transa.N_cuenta.ToString());
                Usuario_modelo cajero = new Control_usuario().Consultar_usuario(Usuario_modelo.Usuario_activo);
                Persona_modelo persona = new Control_persona().Consultar_persona(cajero.Identidad.ToString());
                if (transa.Procedente != "EFECTIVO")
                {
                    cuentaprocente = new Control_cuenta().Consultar_cuenta2(transa.P_n_cuenta.ToString());
                    comprobante.Procedencia = transa.Procedente + "AHORROS";
                    Afiliado_modelo afiliad2 = new Control_afiliado().Consultar_afiliado2(cuentaprocente.N_afiliado.ToString());
                    Persona_modelo cliente2 = new Control_persona().Consultar_persona(afiliad2.Identidad);
                    comprobante.N_cuenta_procedencia = cuentaprocente.N_cuenta;
                    comprobante.Nombre_p = cliente2.Nombre + " " + cliente2.Apellido;

                }
                else
                {
                    comprobante.Procedencia = transa.Procedente;
                    comprobante.N_cuenta_procedencia = 0;
                    comprobante.Nombre_p = transa.Depositante;

                }

                // colocar aqui los datos
                comprobante.ID_usuario = Usuario_modelo.Usuario_activo;
                comprobante.Nombre_usuario = persona.Nombre + " " + persona.Apellido;
                comprobante.N_transaccion = transa.N_trasaccion;
                comprobante.Fecha_trans = transa.Fecha;
                comprobante.Descripcion = Tipo;
                comprobante.Monto = transa.Monto;
                comprobante.N_cuenta = cuentabase.N_cuenta;
                comprobante.T_cuenta = cuentabase.Tipo;
                comprobante.Estado = transa.Estado;
                Afiliado_modelo afiliado = new Control_afiliado().Consultar_afiliado2(cuentabase.N_afiliado.ToString());
                Persona_modelo cliente = new Control_persona().Consultar_persona(afiliado.Identidad);
                comprobante.Nombre = cliente.Nombre + " " + cliente.Apellido;
                comprobante.Identidad = cliente.Identidad;


            }

            return comprobante;

        }

    }
}
