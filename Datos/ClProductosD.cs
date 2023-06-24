using Empleados.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Empleados.Datos
{
    public class ClProductosD
    {
        public List<ClProductosE> mtdVentas()
        {
            string consprodu = "SELECT * FROM VentasProductos";
            ClProcesosSQLcs sqlprod = new ClProcesosSQLcs();
            DataTable tblVentas = sqlprod.mtdSelectDes(consprodu);

            List<ClProductosE> ListaVentas = new List<ClProductosE>();
            ClProductosE objventas = null;

            for (int i = 0; i < tblVentas.Rows.Count; i++)
            {
                objventas = new ClProductosE();
                objventas.IdVenta = int.Parse(tblVentas.Rows[i]["IdVentaProducto"].ToString());
                objventas.Producto = tblVentas.Rows[i]["Producto"].ToString();
                objventas.Cantidad = int.Parse(tblVentas.Rows[i]["Cantidad"].ToString());
                objventas.FechaVenta = tblVentas.Rows[i]["FechaVenta"].ToString();
                objventas.Usuario = tblVentas.Rows[i]["Usuario"].ToString();
                ListaVentas.Add(objventas);
            }

            return ListaVentas;
        }

        public int insertarventa(ClProductosE objinserVen)
        {
            string conssql = "INSERT INTO VentasProductos(Producto,Cantidad,FechaVenta,Usuario)" + "VALUES('"+objinserVen.Producto+ "','"+objinserVen.Cantidad+ "','"+objinserVen.FechaVenta+ "','"+objinserVen.Usuario+ "')";
                     ClProcesosSQLcs Objsql = new ClProcesosSQLcs();
            int inserVentaa = Objsql.mtdIUDconect(conssql);
            return inserVentaa;
        }




        public int EliminarVentaProducto(ClProductosE producto)
        {
            string delete = "DELETE FROM VentasProductos WHERE producto = @Producto";

            using (SqlConnection connection = new ClCElim().GetConnectionn())
            {
                using (SqlCommand command = new SqlCommand(delete, connection))
                {
                    command.Parameters.AddWithValue("@Producto", producto.Producto);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
        }
    }
}


    




   