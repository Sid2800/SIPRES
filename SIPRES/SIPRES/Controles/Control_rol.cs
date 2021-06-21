using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIPRES.Models;

namespace SIPRES.Controles
{
    class Control_rol
    {

        readonly Rol_modelo rol = new Rol_modelo();

        public void Listar_rol(string Qry)
        {

            try
            {
                DataTable dt = new DataTable();
                {
                    using (SqlConnection sqlCon = new Conexion().CadenaConexion())
                    {
                        sqlCon.Open();
                        using (SqlCommand cmd = new SqlCommand(Qry, sqlCon))
                        {
                            SqlDataAdapter LeerDatos = new SqlDataAdapter(cmd);
                            LeerDatos.Fill(dt);
                        }
                        sqlCon.Close();
                    }
                   Rol_modelo.Datos = dt;
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }


        public Rol_modelo Consultar_rol(string id_rol)
        {
            try
            {
                using (SqlConnection sqlCon = new Conexion().CadenaConexion())
                {
                    sqlCon.Open();
                    string Qry = "select * from rol_usuario where id_rol = '" + id_rol + "'";
                    using (SqlCommand cmd = new SqlCommand(Qry, sqlCon))
                    {
                        Rol_modelo.Existe = false;
                        SqlDataReader LeerDatos = cmd.ExecuteReader();

                        if (LeerDatos.HasRows)
                        {
                            while (LeerDatos.Read())
                            {

                                rol.Id_rol = LeerDatos.GetString(0);
                                rol.Rol = LeerDatos.GetString(1);
                                rol.Niv_acce = LeerDatos.GetInt32(2);

                                Rol_modelo.Existe = true;

                            }
                        }
                    }
                    sqlCon.Close();
                }

            }
            catch (Exception e) { MessageBox.Show($"Listar usuario {e.Message}"); }
            return rol;
        }


        public Rol_modelo Consultar_rol_rol(string rol_r)
        {
            try
            {
                using (SqlConnection sqlCon = new Conexion().CadenaConexion())
                {
                    sqlCon.Open();
                    string Qry = "select * from rol_usuario where rol = '" + rol_r + "'";
                    using (SqlCommand cmd = new SqlCommand(Qry, sqlCon))
                    {
                        Rol_modelo.Existe = false;
                        SqlDataReader LeerDatos = cmd.ExecuteReader();

                        if (LeerDatos.HasRows)
                        {
                            while (LeerDatos.Read())
                            {

                                rol.Id_rol = LeerDatos.GetString(0);
                                rol.Rol = LeerDatos.GetString(1);
                                rol.Niv_acce = LeerDatos.GetInt32(2);

                                Rol_modelo.Existe = true;

                            }
                        }
                    }
                    sqlCon.Close();
                }

            }
            catch (Exception e) { MessageBox.Show($"Listar usuario {e.Message}"); }
            return rol;
        }



    }
}
