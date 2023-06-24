using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Empleados.Datos
{
    public class ClCElim
    {
       
            public SqlConnection GetConnectionn()
            {
                return new SqlConnection("Data Source=DESKTOP-CQMIB01;Initial Catalog=EjercicioVentas;Integrated Security=True");
            }
        }

    }
