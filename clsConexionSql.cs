using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SITS
{
    class ClsConexionSql
    {

        ////Conexión a Base de datos Computador trabajo Ivan
        //static private string cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\ivan.bedoya\\Documents\\Proyecto_SITS\\dbSistemaInventarioTiendaSentimientos.mdf;Integrated Security=True;Connect Timeout=30";

        ////Conexión a Base de datos Computador de Luisa
       static private string cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=d:\\Luisa\\Documents\\GitHub\\Proyecto_SITS\\Image\\dbSistemaInventarioTiendaSentimientos.mdf;Integrated Security=True;Connect Timeout=30";

        ////Conexión a Base de datos Computador Personal Ivan
        //static private string cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='D:\\Nubes\\OneDrive - Institución Universitaria de Envigado - IUE\\Ing_Sistemas_IUE\\2021-2\\Dllo Software Orientado a Objetos\\Proyecto_SITS\\dbSistemaInventarioTiendaSentimientos.mdf';Integrated Security=True;Connect Timeout=30";

        ////Conexión a Base de datos Computador Personal Ivan con SQL EXPRESS
        //static private string cadenaConexion = "server=AGN5\\SQLEXPRESS ; database = replica_dbSistemaInventarioTiendaSentimientos; integrated security = true ";

        ////Conexión a Base de datos Computador trabajo Ivan con SQL EXPRESS
        //static private string cadenaConexion = "server=LMEIBEDOYA\\SQLEXPRESS ; database = replica_dbSistemaInventarioTiendaSentimientos; integrated security = true ";


        private SqlConnection conexion = new SqlConnection(cadenaConexion);

        public SqlConnection abrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }

        public SqlConnection cerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }

    }
}
