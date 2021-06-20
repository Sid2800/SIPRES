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
    public partial class login : Form
    {

        Usuario_modelo usuario = new Usuario_modelo();
        readonly Control_usuario control = new Control_usuario();
        int contador = 0;

        public login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            control.Listar_usuario("select * from usuario where activo = 'true'");
            CB_id_usu.DataSource = Usuario_modelo.Datos;
            CB_id_usu.DisplayMember = "usuario";
            CB_id_usu.ValueMember = "id_usu";
            CB_id_usu.Text = "";
        }

        Boolean Comprobar_lleno()
        {
            Boolean lleno;
            if (string.IsNullOrEmpty(CB_id_usu.Text)
                || string.IsNullOrEmpty(TX_contra.Text)

                )
            { lleno = false; }
            else { lleno = true; }
            return lleno;
        }

        private void BT_ingresar_Click(object sender, EventArgs e)
        {
            string id = CB_id_usu.Text.ToUpper();
            string contra = TX_contra.Text.ToString();
            /// coomprobar si usuario existe 

            usuario = control.Consultar_usuario(id);

            // comprobar texbox llenos
            if (Comprobar_lleno())
            {
                if (Usuario_modelo.Existe == true)// Si existe el ID Usuario
                {
                    // Vefiricacion  estado de Usuario
                    if (usuario.Activo == true)
                    {
                        if (usuario.Contra == contra)
                        {
                            MessageBox.Show("Te has logeado correctamente, Bienvenido al sistema ",
                                   "Sistema de presupuestos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Usuario_modelo.Usuario_activo = id;
                            this.Hide();
                           principal principal = new principal();
                           principal.Show();
                        }
                        else
                        {
                            contador += 1;
                            MessageBox.Show("Datos Incorrectos, o contraseña erronea, Numero de intentos " + contador,
                                       "Sistema de presupuestosa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            CB_id_usu.Text = "";
                            TX_contra.Clear();
                            CB_id_usu.Focus();
                        }
                    }
                    // En caso de Usario inactivo
                    else
                    {
                        MessageBox.Show("El usuario " + id + " esta desactivado, utiliza un usuario valido",
                        "Sistema de presupuestos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        contador += 1;
                        CB_id_usu.Text = "";
                        TX_contra.Clear();
                        CB_id_usu.Focus();
                    }

                    // en caso que el usuario no existe
                }
                else
                {
                    MessageBox.Show("El usuario " + id + " no existe, corrije y vuelve a intentar ",
                             "Sistema de presupuestos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    contador += 1;
                }
            }
            // en caso que los texbx estan vacios         
            else
            {
                MessageBox.Show("Hay campos sin ingresar, tu deberias saber esto",
            "Sistema de presupuestos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //analisis del contador nuemero maximo de intentos, bloquea el ultimo id ingresado
            if (contador >= 4)
            {
                MessageBox.Show("LLegaste al Limite de Intentos, Tu usuario ha sido desactivado" + contador,
                   "Sistema de presupuestos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Desactivar_usuario(false,usuario.Id_usu);
                Application.Exit();
            }
        }

        private void BT_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
