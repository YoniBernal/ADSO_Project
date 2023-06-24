using Empleados.Datos;
using Empleados.Entidades;
using Empleados.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Xceed.Wpf.Toolkit;

namespace Empleados.Vista
{
    public partial class Ventas : System.Web.UI.Page
    {
        private ClProductoL ventaPr = new ClProductoL();
        protected void Page_Load(object sender, EventArgs e)
        {
            ClProductoL producL = new ClProductoL();
            ClProductosE productosE = new ClProductosE();
            List<ClProductosE> ListaProd = producL.mtdVentasL(productosE);
            gvVentas.DataSource = ListaProd;
            gvVentas.DataBind();
        }

        protected void btnAgregar_Click1(object sender, EventArgs e)
        {
            ClProductosE venta = new ClProductosE();
            venta.Producto = txtProducto.Text;
            venta.Cantidad = int.Parse(txtCantidad.Text);
            venta.FechaVenta = txtFecha.Text;
            venta.Usuario = txtUsuario.Text;

            ClProductoL proL = new ClProductoL();
            int agregar = proL.mtdinservenn(venta);

            string mensaje = "¡El producto fue Gregado!";
            string scri = "<script type=\"text/javascript\">alert('" + mensaje + "');</script>";


            if (scri != "" || scri != null)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", scri);
            }

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string producto = txtProd.Text;

            ClProductoL eliminarL = new ClProductoL();
            int eliminado = eliminarL.EliminarVentaProducto(producto);

            if (eliminado > 0)
            {
                string mensa = "¡Registro eliminado!";
                string scri = "<script type=\"text/javascript\">alert('" + mensa + "');</script>";
                ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", scri);
            }
            else
            {
                string errorMensa = "¡Error al eliminar el registro!";
                string errorScri = "<script type=\"text/javascript\">alert('" + errorMensa + "');</script>";
                ClientScript.RegisterStartupScript(this.GetType(), "Error", errorScri);
            }
        }

    }
}
