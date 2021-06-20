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
    public partial class principal : Form
    {
        Control_usuario control = new Control_usuario();
        Control_rol control_r = new Control_rol();

        Usuario_modelo usuario = new Usuario_modelo();
        Rol_modelo rol_usu = new Rol_modelo();

        public principal()
        {
            InitializeComponent();

            Usuario_activo();

        }
        
        private void Usuario_activo()
        {
            usuario = control.Consultar_usuario(Usuario_modelo.Usuario_activo);
            activo.Text = " " + usuario.Id_usu;
            rol_usu = control_r.Consultar_rol(usuario.Id_rol);
            rol.Text = rol_usu.Rol;
            /// Accedo al Menu
            /// 
            switch (rol_usu.Niv_acce)
            {
                case 1:
                    Menu_modo(1);
                    break;
                case 2:               
                    Menu_modo(2);
                    break;
                case 3:
                    Menu_modo(3);
                    break;
                default:
                    break;
            }
        }

        private void Abrir_formulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = P_formulario.Controls.OfType<MiForm>().FirstOrDefault(); //Busca en la coleccion el formulario
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                P_formulario.Controls.Add(formulario);
                P_formulario.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
                formulario.BringToFront();

        }
        
        private void Menu_modo(int M)
        {
            switch (M)
            {
                case 1:
                    BT_persona.Enabled = true;
                    BT_usuario.Enabled = true;
                    BT_cliente.Enabled = true;
                    BT_producto.Enabled = true;
                    BT_proyecto.Enabled = true;

                    break;

                case 2:
                    BT_persona.Enabled = true;
                    //BT_usuario.Enabled = true;
                    BT_cliente.Enabled = true;
                    BT_producto.Enabled = true;
                    BT_proyecto.Enabled = true;
                    break;

                case 3:
                    BT_proyecto.Enabled = true;
                    break;

                default:
                    break;
            }
        }

        private void BT_salir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Deseas realmente de la aplicacion, todos los cambios no guardados se perderan"
                , "Sistema Presupuestario",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes) {
                Application.Exit();
            }


               
        }

        private void BT_persona_Click(object sender, EventArgs e)
        {
            Abrir_formulario<persona>();
        }
    }
}
