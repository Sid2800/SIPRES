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
    class Control_usuario
    {
        readonly Usuario_modelo usuario = new Usuario_modelo();

        public Usuario_modelo Consultar_usuario(string id_user)
        {
            try
            {
                using (SqlConnection sqlCon = new Conexion().CadenaConexion())
                {
                    sqlCon.Open();
                    string Qry = "select * from usuario where id_usu = '" + id_user + "'";
                    using (SqlCommand cmd = new SqlCommand(Qry, sqlCon))
                    {
                        Usuario_modelo.Existe = false;
                        SqlDataReader LeerDatos = cmd.ExecuteReader();

                        if (LeerDatos.HasRows)
                        {
                            while (LeerDatos.Read())
                            {

                                usuario.Id_usu = LeerDatos.GetString(0);
                                usuario.Activo = LeerDatos.GetBoolean(1);
                                usuario.Contra = LeerDatos.GetString(2);
                                usuario.Int_log = LeerDatos.GetInt32(3);
                                usuario.Id_rol = LeerDatos.GetString(4);
                                usuario.Identidad = LeerDatos.GetString(5);

                                Usuario_modelo.Existe = true;

                            }
                        }
                    }
                    sqlCon.Close();
                }

            }
            catch (Exception e) { MessageBox.Show($"Listar usuario {e.Message}"); }
            return usuario;
        }

        public Boolean ExistenciaUsuario(string var)
        {

            Boolean existe = false;
            try
            {
                using (SqlConnection sqlCon = new Conexion().CadenaConexion())
                {
                    sqlCon.Open();
                    string Qry = "select * from usuario where identidad = '" + var + "'";
                    using (SqlCommand cmd = new SqlCommand(Qry, sqlCon))
                    {
                        SqlDataReader conteo = cmd.ExecuteReader();
                        if (conteo.HasRows) { existe = true; }

                    }
                    sqlCon.Close();

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                existe = false;
            }

            return existe;

        }

        public void Listar_usuario(string Qry)
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
                    Usuario_modelo.Datos = dt;
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }

        //public Boolean Actualizar_usuario(Usuario_modelo var)
        //{

        //    Boolean modificado = false;
        //    try
        //    {
        //        using (SqlConnection sqlCon = new Conexion().CadenaConexion())
        //        {
        //            sqlCon.Open();

        //            string Qry = "update [dbo].[usuario] set contra = '" + var.Contra +
        //           "' , categoria = '" + var.Categoria + "' , estado = '" + var.Estado + "' where id_usu = '" + var.Id_usu + "';";

        //            using (SqlCommand cmd = new SqlCommand(Qry, sqlCon))
        //            {
        //                cmd.ExecuteNonQuery();
        //                modificado = true;
        //            }
        //            sqlCon.Close();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //        modificado = false;
        //    }
        //    return modificado;
        //}

        //public Boolean Añadir_usuario(Usuario_modelo var)
        //{
        //    Boolean agregado = false;
        //    try
        //    {
        //        using (SqlConnection sqlCon = new Conexion().CadenaConexion())
        //        {
        //            sqlCon.Open();
        //            string Qry = "insert into [dbo].[usuario] (id_usu,contra,categoria,estado,identidad) values ( '" + var.Id_usu + "','" + var.Contra + "','" + var.Categoria +
        //             "','" + var.Estado + "','" + var.Identidad + "');";

        //            using (SqlCommand cmd = new SqlCommand(Qry, sqlCon))
        //            {
        //                cmd.ExecuteNonQuery();
        //                agregado = true;
        //            }
        //            sqlCon.Close();

        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //        agregado = false;
        //    }
        //    return agregado;
        //}


        public Boolean Desactivar_usuario(Boolean var, String Id)
        {

            Boolean desactivado = false;
            try
            {
                using (SqlConnection sqlCon = new Conexion().CadenaConexion())
                {
                    sqlCon.Open();

                    string Qry = "update [dbo].[usuario] set activo = '" + var +
                   "'  where id_usu = '" + Id + "';";

                    using (SqlCommand cmd = new SqlCommand(Qry, sqlCon))
                    {
                        cmd.ExecuteNonQuery();
                        desactivado = true;
                    }
                    sqlCon.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                desactivado = false;
            }
            return desactivado;
        }



    }
}
