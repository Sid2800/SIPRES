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
    class Control_empresa
    {
        
        Empresa_modelo emp = new Empresa_modelo();

        public void Listar_emp(string Qry)
        {
            try
            {
                DataTable dt = new DataTable();
                {
                    using (SqlConnection sqlCon = new Conexion().CadenaConexion())
                    {
                        sqlCon.Open();
                        //string Qry = "select * from empresa";
                        using (SqlCommand cmd = new SqlCommand(Qry, sqlCon))
                        {
                            SqlDataAdapter LeerDatos = new SqlDataAdapter(cmd);
                            LeerDatos.Fill(dt);
                        }
                        sqlCon.Close();
                    }
                    Empresa_modelo.Datos = dt;
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }

        public Empresa_modelo Consultar_emp(string id_emp)
        {
            try
            {
                using (SqlConnection sqlCon = new Conexion().CadenaConexion())
                {
                    sqlCon.Open();
                    string Qry = "select * from empresa where id_emp = '" + id_emp + "'";
                    using (SqlCommand cmd = new SqlCommand(Qry, sqlCon))
                    {
                        Empresa_modelo.Existe = false;
                        SqlDataReader LeerDatos = cmd.ExecuteReader();

                        if (LeerDatos.HasRows)
                        {
                            while (LeerDatos.Read())                            {

                                emp.Id_emp = LeerDatos.GetInt32(0);
                                emp.Rtn = LeerDatos.GetString(1);
                                emp.Nombre = LeerDatos.GetString(2);
                                emp.Telefono = LeerDatos.GetString(3);
                                emp.Correo = LeerDatos.GetString(4);
                                emp.Direccion = LeerDatos.GetString(5);
                                emp.Id_contacto = LeerDatos.GetString(6);             
                                Empresa_modelo.Existe = true;
                            }
                        }
                    }
                    sqlCon.Close();
                }

            }
            catch (Exception e) { MessageBox.Show(e.Message + id_emp); }
            return emp;
        }

        public Boolean Añadir_emp(Empresa_modelo var)
        {
            Boolean agregado = false;
            try
            {
                using (SqlConnection sqlCon = new Conexion().CadenaConexion())
                {
                    sqlCon.Open();
                    string Qry = "insert into [dbo].[empresa] (rtn,nombre,telefono,correo,direccion,id_contacto) values ( '" + var.Rtn + "','" + var.Nombre + "','" + var.Telefono +
             "','" + var.Correo + "','" + var.Direccion + "','" + var.Id_contacto + "');";

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

        public Boolean Actualizar_emp(Empresa_modelo var)
        {
            Boolean modificado = false;
            try
            {
                using (SqlConnection sqlCon = new Conexion().CadenaConexion())
                {
                    sqlCon.Open();

                    string Qry = "update [dbo].[empresa] set rtn = '" + var.Rtn +
              "' , nombre = '" + var.Nombre + "', telefono = '" + var.Telefono +
              "' , correo = '" + var.Correo + "', direccion = '" + var.Direccion +
              "' , id_contacto = '" + var.Id_contacto + "' where id_emp = '" + var.Id_emp + "';";

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
