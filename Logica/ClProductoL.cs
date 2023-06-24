using Empleados.Datos;
using Empleados.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Empleados.Logica
{
    public class ClProductoL
    {
        public List<ClProductosE> mtdVentasL(ClProductosE Venta)
        {
            ClProductosD objventa = new ClProductosD();
            List<ClProductosE> listVent = objventa.mtdVentas();
            return listVent;
        }

        public int mtdinservenn(ClProductosE objinserv)
        {
           ClProductosD insertarVneta = new ClProductosD();
            int insertarVn = insertarVneta.insertarventa(objinserv);
            return insertarVn;
        }






        public int EliminarVentaProducto(string producto)
        {
            ClProductosE productoElim = new ClProductosE
            {
                Producto = producto
            };

            ClProductosD eliminarD = new ClProductosD();
            int elimi = eliminarD.EliminarVentaProducto(productoElim);
            return elimi;
        }


    }


}



