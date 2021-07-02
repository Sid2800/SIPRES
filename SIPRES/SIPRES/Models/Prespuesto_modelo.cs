using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPRES.Models
{
    class Prespuesto_modelo
    {
        public string ID_usuario { get; set; } // metodo

        public string Nombre_Usuario { get; set; } // metodo

        public int ID_proyecto { get; set; } // metodo

        public string Nombre_proyecto { get; set; } // metodo

        
        public int Tipo_proyecto { get; set; }

        public DateTime Fecha_inicio { get; set; } // metodo

        public DateTime Fecha_fin { get; set; } // metodo

        public float Total_proyecto { get; set; } // metodo

        public string Descripcion_proyecto { get; set; }
        
        /// propietario

        public string identidad { get; set; }


        public int id_emp { get; set; }




    }
}
