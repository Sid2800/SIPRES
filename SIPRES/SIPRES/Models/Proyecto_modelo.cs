using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPRES.Models
{
    class Proyecto_modelo
    {
        public int Id_proy { get; set; }

        public int Id_emp { get; set; }

        public string Identidad { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public string Estado { get; set; }

        public string Tipo { get; set; }

        

        public DateTime Fecha_ini { get; set; }

        public DateTime Fecha_fin { get; set; }


        /// Propiedades para uso para procesos del sistema
        public static DataTable Datos { get; set; } // metodo

        public static DataTable Ntotal { get; set; } // metodo

        public static Boolean Existe { get; set; } // metodo

    }
}
