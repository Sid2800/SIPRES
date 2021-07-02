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
    class Control_proyecto
    {
        readonly Proyecto_modelo proyecto = new Proyecto_modelo();

        public void Listar_proyecto(string Qry)
        {

            try
            {
                DataTable dt = new DataTable();
                {
                    using (SqlConnection sqlCon = new Conexion().CadenaConexion())
                    {

                        sqlCon.Open();
                        //string Qry = "select * from usuario";
                        using (SqlCommand cmd = new SqlCommand(Qry, sqlCon))
                        {

                            SqlDataAdapter LeerDatos = new SqlDataAdapter(cmd);
                            LeerDatos.Fill(dt);
                        }
                        sqlCon.Close();
                    }
                    Proyecto_modelo.Datos = dt;
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }

        public void Ultimo_registro(string Qry)
        {

            try
            {
                DataTable dt = new DataTable();
                {
                    using (SqlConnection sqlCon = new Conexion().CadenaConexion())
                    {

                        sqlCon.Open();
                        //string Qry = "select * from usuario";
                        using (SqlCommand cmd = new SqlCommand(Qry, sqlCon))
                        {

                            SqlDataAdapter LeerDatos = new SqlDataAdapter(cmd);
                            LeerDatos.Fill(dt);
                        }
                        sqlCon.Close();
                    }
                    Proyecto_modelo.Ultimo = dt;
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }


        public Proyecto_modelo Consultar_proyecto(string id, string mod)
        {
            try
            {
                using (SqlConnection sqlCon = new Conexion().CadenaConexion())
                {
                    sqlCon.Open();
                    string Qry = $"select * from proyecto where id_proy = ' {id} '";
                    using (SqlCommand cmd = new SqlCommand(Qry, sqlCon))
                    {
                        Proyecto_modelo.Existe = false;
                        SqlDataReader LeerDatos = cmd.ExecuteReader();

                        if (LeerDatos.HasRows)
                        {
                            while (LeerDatos.Read())
                            {
                                proyecto.Id_proy = LeerDatos.GetInt32(0);
                                switch (mod)
                                {
                                    case "E":
                                        proyecto.Id_emp = LeerDatos.GetInt32(1);
                                        break;
                                    case "P":
                                        proyecto.Identidad = LeerDatos.GetString(2);
                                        break;

                                    default:
                                        break;
                                }                                                                                           

                                                                                                    
                                proyecto.Nombre = LeerDatos.GetString(3);
                                proyecto.Descripcion = LeerDatos.GetString(4);
                                proyecto.Estado = LeerDatos.GetString(5);
                                proyecto.Tipo = LeerDatos.GetString(6);
                                proyecto.Fecha_ini = LeerDatos.GetDateTime(7);
                                proyecto.Fecha_fin = LeerDatos.GetDateTime(8);
                                Proyecto_modelo.Existe = true;

                            }
                        }
                    }
                    sqlCon.Close();
                }

            }
            catch (Exception e) { MessageBox.Show($"Consultar proyecto {e.Message}"); }
            return proyecto;
        }

        public Proyecto_modelo Consultar_proyecto2(string id)
        {
            try
            {
                using (SqlConnection sqlCon = new Conexion().CadenaConexion())
                {
                    sqlCon.Open();
                    string Qry = $"select * from proyecto where id_proy = ' {id} '";
                    using (SqlCommand cmd = new SqlCommand(Qry, sqlCon))
                    {
                        Proyecto_modelo.Existe = false;
                        SqlDataReader LeerDatos = cmd.ExecuteReader();

                        if (LeerDatos.HasRows)
                        {
                            while (LeerDatos.Read())
                            {
                                proyecto.Id_proy = LeerDatos.GetInt32(0);                          


                                proyecto.Nombre = LeerDatos.GetString(3);
                                proyecto.Descripcion = LeerDatos.GetString(4);
                                proyecto.Estado = LeerDatos.GetString(5);
                                proyecto.Tipo = LeerDatos.GetString(6);
                                proyecto.Fecha_ini = LeerDatos.GetDateTime(7);
                                proyecto.Fecha_fin = LeerDatos.GetDateTime(8);
                                Proyecto_modelo.Existe = true;

                            }
                        }
                    }
                    sqlCon.Close();
                }

            }
            catch (Exception e) { MessageBox.Show($"Consultar proyecto 2{e.Message}"); }
            return proyecto;
        }

        public Boolean Actualizar_proyecto(Proyecto_modelo var, string mod)
        {
            string Qry="";
            Boolean modificado = false;
            try
            {
                using (SqlConnection sqlCon = new Conexion().CadenaConexion())
                {
                    sqlCon.Open();

                    switch (mod)
                    {
                        case "E":
                            Qry = "update [dbo].[proyecto] set id_emp = '" + var.Id_emp + "', nombre = '" + var.Nombre +
               "' , descripcion = '" + var.Descripcion + "', estado = '" + var.Estado +
               "' , tipo = '" + var.Tipo + "', fecha_ini = '" + var.Fecha_ini + "', Total = '" + var.Total +
               "' , fecha_fin = '" + var.Fecha_fin + "' where id_proy = '" + var.Id_proy + "';";
                            break;
                        case "P":
                            Qry = "update [dbo].[proyecto] set identidad = '" + var.Identidad + "', nombre = '" + var.Nombre +
                "' , descripcion = '" + var.Descripcion + "', estado = '" + var.Estado + 
                "' , tipo = '" + var.Tipo + "', fecha_ini = '" + var.Fecha_ini + "', Total = '" + var.Total +
                "' , fecha_fin = '" + var.Fecha_fin + "' where id_proy = '" + var.Id_proy + "';";
                            break;

                        default:
                            break;
                    }

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
                MessageBox.Show(e.Message+"Actualizar Proyecto");
                modificado = false;
            }
            return modificado;
        }
        

        public Boolean Añadir_proyecto(Proyecto_modelo var, string mod)
        {
            Boolean agregado = false;
            string Qry="";
            try
            {
                using (SqlConnection sqlCon = new Conexion().CadenaConexion())
                {
                    sqlCon.Open();
                    switch (mod)
                    {
                        case "E":
                             Qry = "insert into [dbo].[proyecto] (id_emp,nombre,descripcion,estado,tipo,fecha_ini,fecha_fin,Total) values ( '" + var.Id_emp + "','" + var.Nombre +
                                "','" + var.Descripcion + "','" + var.Estado + "','" + var.Tipo + "','" + var.Fecha_ini + "','" + var.Fecha_fin + "','" + var.Total + "');";
                            break;
                        case "P":
                            Qry = "insert into [dbo].[proyecto] (identidad,nombre,descripcion,estado,tipo,fecha_ini,fecha_fin,Total) values ( '" + var.Identidad + "','" + var.Nombre +
                               "','" + var.Descripcion + "','" + var.Estado + "','" + var.Tipo + "','" + var.Fecha_ini + "','" + var.Fecha_fin + "','" + var.Total + "');";
                            break;

                        default:
                            break;
                    }
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
                MessageBox.Show(e.Message+"Añadir Proyecto");
                agregado = false;
            }
            return agregado;
        }

        public void Crear_total(string Qry)
        {

            try
            {
                DataTable dt = new DataTable();
                {
                    using (SqlConnection sqlCon = new Conexion().CadenaConexion())
                    {

                        sqlCon.Open();
                        //string Qry = "select * from usuario";
                        using (SqlCommand cmd = new SqlCommand(Qry, sqlCon))
                        {

                            SqlDataAdapter LeerDatos = new SqlDataAdapter(cmd);
                            LeerDatos.Fill(dt);
                        }
                        sqlCon.Close();
                    }
                    Proyecto_modelo.Ntotal = dt;
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }


    }
}
