using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPRES.Models
{
    class Usuario_modelo
    {
        public string Id_usu { get; set; } // metodo

        public Boolean Activo { get; set; } // metodo

        public string Contra { get; set; } // metodo

        public int Int_log { get; set; }


        public string Id_rol { get; set; }

        public string Identidad { get; set; } // metodo


        /// Metodos para uso para procesos del sistema
        public static Boolean Existe { get; set; } // metodo

        public static DataTable Datos { get; set; } // metodo

        public static string Usuario_activo { get; set; }



    }
}
