using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPRES.Models
{
    class Rol_modelo
    {
        public string Id_rol { get; set; }

        public string Rol { get; set; }

        public int Niv_acce { get; set; }


        /// Metodos para uso para procesos del sistema
        public static Boolean Existe { get; set; } // metodo

    }
}
