using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIPRES.Controles;
using SIPRES.Models;

namespace SIPRES.Controles
{
    class Control_detalle
    {
        readonly Detalle_modelo detalle = new Detalle_modelo();
               
        public void Listar_detalle(string Qry)
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
                    Detalle_modelo.Datos = dt;
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }


        public Boolean Reemplazar_detalle(DataTable tabla, string id_proy)
        {
            Boolean reemplazado = false;
            string Qry2 = "";
            try
            {
                using (SqlConnection sqlCon = new Conexion().CadenaConexion())
                {
                    sqlCon.Open();

                    string Qry = $"DELETE FROM detalle WHERE id_proy = '{id_proy}'";
                    using (SqlCommand cmd = new SqlCommand(Qry, sqlCon))
                    {
                        cmd.ExecuteNonQuery();
                        reemplazado = true;
                    }
                   
                    for (int i = 0; i < tabla.Rows.Count; i++)
                    {
                                             
                            Qry2 = "insert into [dbo].[detalle] VALUES ( '" + id_proy + "','" + tabla.Rows[i][0] + "','" + tabla.Rows[i][4] +
                 "','" + tabla.Rows[i][5] + "');";
                            using (SqlCommand cmd = new SqlCommand(Qry2, sqlCon))
                            {
                                cmd.ExecuteNonQuery();
                                reemplazado = true;
                            }                                                     
                        
                    }

                    sqlCon.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                reemplazado = false;
            }
            return reemplazado;
        }



    }
}
