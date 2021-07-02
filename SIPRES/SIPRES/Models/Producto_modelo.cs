using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPRES.Models
{
    class Producto_modelo
    {
        public string Id_pro { get; set; } // metodo

        public string Nombre { get; set; } // metodo

        public string Uni_med { get; set; } // metodo

        public float Precio{ get; set; } // metodo

        public int Id_tipo_pro { get; set; } // metodo
        

        /// Metodos para uso para procesos del sistema
        public static DataTable Datos { get; set; } // metodo

        public static Boolean Existe { get; set; } // metodo

     

    }
}
