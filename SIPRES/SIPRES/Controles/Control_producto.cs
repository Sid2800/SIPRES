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
    class Control_producto
    {

        Producto_modelo producto = new Producto_modelo();

        public void Listar_productos()
        {
            try
            {
                DataTable dt = new DataTable();
                {
                    using (SqlConnection sqlCon = new Conexion().CadenaConexion())
                    {
                        sqlCon.Open();
                        string Qry = "select * from productos";
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

        public Producto_modelo Consultar_producto(string codigo)
        {
            try
            {
                using (SqlConnection sqlCon = new Conexion().CadenaConexion())
                {
                    sqlCon.Open();
                    string Qry = "select * from producto where id_pro = '" + codigo + "'";
                    using (SqlCommand cmd = new SqlCommand(Qry, sqlCon))
                    {
                        Producto_modelo.Existe = false;
                        SqlDataReader LeerDatos = cmd.ExecuteReader();

                        if (LeerDatos.HasRows)
                        {
                            while (LeerDatos.Read())
                            {

                                producto.Id_pro = LeerDatos.GetString(0);
                                producto.Nombre = LeerDatos.GetString(1);                         
                                producto.Uni_med = LeerDatos.GetString(2);
                                producto.Precio = LeerDatos.GetFloat(3);
                                producto.Id_tipo_pro = LeerDatos.GetInt32(4);
                           

                               Producto_modelo.Existe = true;

                            }
                        }
                    }
                    sqlCon.Close();
                }

            }
            catch (Exception e) { MessageBox.Show(e.Message + codigo); }
            return producto;
        }

        //public Boolean Añadir_producto(Persona_modelo var)
        //{
        //    Boolean agregado = false;
        //    try
        //    {
        //        using (SqlConnection sqlCon = new Conexion().CadenaConexion())
        //        {
        //            sqlCon.Open();
        //            string Qry = "insert into [dbo].[persona] VALUES ( '" + var.Identidad + "','" + var.Rtn + "','" + var.Nombre +
        //                "','" + var.Apellido + "','" + var.F_nacimiento + "','" + var.Genero + "','" + var.Correo + "','" +
        //                var.Tel_fijo + "','" + var.Tel_cell + "','" + var.Direccion + "');";

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

        //public Boolean Actualizar_persona(Persona_modelo var)
        //{

        //    Boolean modificado = false;
        //    try
        //    {
        //        using (SqlConnection sqlCon = new Conexion().CadenaConexion())
        //        {
        //            sqlCon.Open();

        //            string Qry = "update [dbo].[persona] set rtn = '" + var.Rtn +
        //           "' , nombre = '" + var.Nombre + "', apellido = '" + var.Apellido +
        //           "' , f_nacimiento = '" + var.F_nacimiento + "', genero = '" + var.Genero +
        //           "' , correo = '" + var.Correo + "', tel_fijo = '" + var.Tel_fijo +
        //           "', tel_cell = '" + var.Tel_cell + "', direccion = '" + var.Direccion + "' where identidad = '" + var.Identidad + "';";

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

    }
}
