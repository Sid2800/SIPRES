using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIPRES.Controles;
using SIPRES.Models;

namespace SIPRES.Vistas
{
    public partial class producto : Form
    {
        Control_producto control = new Control_producto();
        Reporte reporte = new Reporte();
        Producto_modelo personanew = new Producto_modelo();

        public producto()
        {
            InitializeComponent();
        }

        Boolean LLenos()
        {
            Boolean lleno;
            if (TX_codigo.MaskCompleted == false
                || string.IsNullOrEmpty(TX_nombre.Text)
                || string.IsNullOrEmpty(TX_descripcion.Text)
                || string.IsNullOrEmpty(TX_unidad.Text)
                || string.IsNullOrEmpty(TX_precio.Text)
                || string.IsNullOrEmpty(CB_Tipo.Text)                  

                )
            { lleno = false; }
            else { lleno = true; }
            return lleno;
        }

        void Limpiar()
        {
            this.TX_codigo.Clear();
            this.TX_nombre.Clear();
            this.TX_descripcion.Clear();
            this.TX_unidad.Clear();
            this.TX_precio.Clear();
            this.CB_Tipo.Text="";
            this.TX_descripion_t.Clear();                                 
        
        }

    }
}
