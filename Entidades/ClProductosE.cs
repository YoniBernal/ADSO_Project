using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Empleados.Entidades
{
    public class ClProductosE
    {
        public int IdVenta { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public string FechaVenta { get; set; }
        public string Usuario { get; set; }
        public int IdEliminacion { get; set; }
        public string FechaEliminacion { get; set; }
    }
}