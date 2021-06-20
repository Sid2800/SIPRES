using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPRES.Controles
{
    class Conexion
    {
        public SqlConnection CadenaConexion()
        {
            //Guardamos el nombre de la conexion en una varible, Ver App.config
            String NombreConexion = "ConexionBaseDatos";
            SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings[NombreConexion].ToString());
            return sqlCon;


        }
    }
}
