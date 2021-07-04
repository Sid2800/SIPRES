using SIPRES.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIPRES.Controles
{
    class Control_consultas
    {
        public void Listar(string tabla)
        {
            try
            {
                DataTable dt = new DataTable();
                {
                    using (SqlConnection sqlCon = new Conexion().CadenaConexion())
                    {
                        sqlCon.Open();
                        string Qry = $"select * from {tabla}";
                        using (SqlCommand cmd = new SqlCommand(Qry, sqlCon))
                        {
                            SqlDataAdapter LeerDatos = new SqlDataAdapter(cmd);
                            LeerDatos.Fill(dt);
                        }
                        sqlCon.Close();
                    }
                    Consultas.Datos = dt;
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }


    }
}
