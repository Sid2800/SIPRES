using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPRES.Models
{
    class Empresa_modelo
    {
        public int Id_emp { get; set; }

        public string Rtn { get; set; }

        public string Nombre { get; set; }

        public string Telefono { get; set; }
        
        public string Correo { get; set; }

        public string Direccion { get; set; }

        public string Id_contacto { get; set; }

        /// Metodos para uso para procesos del sistema
        public static Boolean Existe { get; set; } 

        public static DataTable Datos { get; set; }

    }
}
