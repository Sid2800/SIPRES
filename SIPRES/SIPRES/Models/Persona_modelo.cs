using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPRES.Models
{
    class Persona_modelo
    {

        public string Identidad { get; set; } // metodo

        public string Rtn { get; set; } // metodo

        public string Nombre { get; set; } // metodo

        public string Apellido { get; set; } // metodo

        public DateTime F_nacimiento { get; set; } // metodo

        public string Genero { get; set; } // metodo

        public string Correo { get; set; }

        public string Tel_fijo { get; set; } // metodo

        public string Tel_cell { get; set; } // metodo

        public string Direccion { get; set; } // metodo



        /// Metodos para uso para procesos del sistema
        public static DataTable Datos { get; set; } // metodo

        public static Boolean Existe { get; set; } // metodo



    }
}
