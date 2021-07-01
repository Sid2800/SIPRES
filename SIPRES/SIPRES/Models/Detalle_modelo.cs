using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPRES.Models
{
    class Detalle_modelo
    {
        public int Id_det { get; set; }

        public int Id_proy { get; set; }

        public int Id_pro { get; set; }

        public int Cantidad { get; set; }

        public float Total { get; set; }

        /// Propiedades para uso para procesos del sistema
        public static DataTable Datos { get; set; } // metodo

        public static DataTable detalle { get; set; }

        public static Boolean Existe { get; set; } // metodo


    }
}
