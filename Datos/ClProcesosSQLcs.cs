using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Empleados.Datos
{
    public class ClProcesosSQLcs
    {
        public DataTable mtdSelectDes(string consul)
        {
            ClConexion objConexion = new ClConexion();
            SqlDataAdapter adaptador = new SqlDataAdapter(consul, objConexion.GetConnection());
            DataTable tblDatos = new DataTable();
            adaptador.Fill(tblDatos);
            objConexion.GetConnection().Close();
            return tblDatos;
        }

        //Ejecuta consulta Select de forma Conectada y retorna DataReader 
        public void mtdSelectConec(string consul)
        {
            ClConexion obConexion = new ClConexion();
            obConexion.GetConnection().Open();
            SqlCommand comando = new SqlCommand(consul, obConexion.GetConnection());
            SqlDataReader regis = comando.ExecuteReader();
            obConexion.GetConnection().Close();


        }

        //Ejecuta SQL Insert, Delet, Update en forma conectada y retorna conectada y retorna entero

        public int mtdIUDconect(string consul)
        {
            ClConexion conexion = new ClConexion();
            SqlCommand comando = new SqlCommand(consul, conexion.GetConnection());
            int regis = comando.ExecuteNonQuery();
            conexion.GetConnection().Close();
            return regis;

        }
    }
}

 