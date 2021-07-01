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




    }
}
