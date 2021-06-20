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
    class Control_persona
    {

        Persona_modelo persona = new Persona_modelo();

        public void Listar_persona()
        {
            try
            {
                DataTable dt = new DataTable();
                {
                    using (SqlConnection sqlCon = new Conexion().CadenaConexion())
                    {
                        sqlCon.Open();
                        string Qry = "select * from persona";
                        using (SqlCommand cmd = new SqlCommand(Qry, sqlCon))
                        {
                            SqlDataAdapter LeerDatos = new SqlDataAdapter(cmd);
                            LeerDatos.Fill(dt);
                        }
                        sqlCon.Close();
                    }
                    Persona_modelo.Datos = dt;
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }

        public Persona_modelo Consultar_persona(string identidad)
        {
            try
            {
                using (SqlConnection sqlCon = new Conexion().CadenaConexion())
                {
                    sqlCon.Open();
                    string Qry = "select * from persona where identidad = '" + identidad + "'";
                    using (SqlCommand cmd = new SqlCommand(Qry, sqlCon))
                    {
                        Persona_modelo.Existe = false;
                        SqlDataReader LeerDatos = cmd.ExecuteReader();

                        if (LeerDatos.HasRows)
                        {
                            while (LeerDatos.Read())
                            {

                                persona.Identidad = LeerDatos.GetString(0);
                                persona.Rtn = LeerDatos.GetString(1);
                                persona.Nombre = LeerDatos.GetString(2);
                                persona.Apellido = LeerDatos.GetString(3);
                                persona.F_nacimiento = LeerDatos.GetDateTime(4);
                                persona.Genero = LeerDatos.GetString(5);
                                persona.Correo = LeerDatos.GetString(6);
                                persona.Tel_fijo = LeerDatos.GetString(7);
                                persona.Tel_cell = LeerDatos.GetString(8);
                                persona.Direccion = LeerDatos.GetString(9);

                                Persona_modelo.Existe = true;

                            }
                        }
                    }
                    sqlCon.Close();
                }

            }
            catch (Exception e) { MessageBox.Show(e.Message + identidad ); }
            return persona;
        }

        public Boolean Añadir_persona(Persona_modelo var)
        {
            Boolean agregado = false;
            try
            {
                using (SqlConnection sqlCon = new Conexion().CadenaConexion())
                {
                    sqlCon.Open();
                    string Qry = "insert into [dbo].[persona] VALUES ( '" + var.Identidad + "','" + var.Rtn + "','" + var.Nombre +
                        "','" + var.Apellido + "','" + var.F_nacimiento + "','" + var.Genero + "','" + var.Correo + "','" +
                        var.Tel_fijo + "','" + var.Tel_cell + "','" + var.Direccion + "');";

                    using (SqlCommand cmd = new SqlCommand(Qry, sqlCon))
                    {
                        cmd.ExecuteNonQuery();
                        agregado = true;
                    }
                    sqlCon.Close();

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                agregado = false;
            }
            return agregado;
        }

        public Boolean Actualizar_persona(Persona_modelo var)
        {

            Boolean modificado = false;
            try
            {
                using (SqlConnection sqlCon = new Conexion().CadenaConexion())
                {
                    sqlCon.Open();

                    string Qry = "update [dbo].[persona] set rtn = '" + var.Rtn +
                   "' , nombre = '" + var.Nombre + "', apellido = '" + var.Apellido +
                   "' , f_nacimiento = '" + var.F_nacimiento + "', genero = '" + var.Genero +
                   "' , correo = '" + var.Correo + "', tel_fijo = '" + var.Tel_fijo +
                   "', tel_cell = '" + var.Tel_cell + "', direccion = '" + var.Direccion     + "' where identidad = '" + var.Identidad + "';";

                    using (SqlCommand cmd = new SqlCommand(Qry, sqlCon))
                    {
                        cmd.ExecuteNonQuery();
                        modificado = true;
                    }
                    sqlCon.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                modificado = false;
            }
            return modificado;
        }

    }
}
