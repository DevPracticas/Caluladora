using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class clConexion
    {
        //string conexionString = "Data Source=DESKTOP-ONA79OQ;Initial Catalog=calculadora4;Integrated Security=True";
        string conexionString = "Data Source=LENOVO;Initial Catalog=calculadora4;Integrated Security=True";
        public SqlConnection conexion = new SqlConnection();

        public clConexion()
        {
            conexion.ConnectionString = conexionString;
        }

        public void abrir()
        {
            try
            {
                conexion.Open();
                Console.WriteLine("conexion ok");
            }
            catch
            {
                Console.WriteLine("conexion fail");
            }
        }

        public void cerrar()
        {
            conexion.Close();
        }
    }
}
