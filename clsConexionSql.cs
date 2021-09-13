using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SITS
{
    class clsConexionSql
    {

        static private string cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='.\\dbSistemaInventarioTiendaSentimientos.mdf';Integrated Security=True;Connect Timeout=30";
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
