using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Empleados.Datos
{

    public class ClConexion
    {
        public SqlConnection GetConnection()
        {
            string connectionString = "Data Source=DESKTOP-CQMIB01;Initial Catalog=EjercicioVentas;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}