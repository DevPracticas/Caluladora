using capaEntidades;
using MySqlX.XDevAPI.CRUD;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class consultas
    {
        clConexion objConexion = new clConexion();
        SqlCommand command = new SqlCommand();

        public string nuevaOperacion(entidades_resultado_operacion datos)
        {
            string resultado = "";
            string sql = "insert into resultadoOperacion values(@dato1, @dato2, @operacion, @resultado)";
            command.CommandText = sql;
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@dato1", datos.dato1);
            command.Parameters.AddWithValue("@dato2", datos.dato2);
            command.Parameters.AddWithValue("@operacion", datos.operacion);
            command.Parameters.AddWithValue("@resultado", datos.resultado);

            try
            {
                command.Connection = objConexion.conexion;
                objConexion.abrir();
                command.ExecuteNonQuery();

                resultado = "ingreso correcto";
            }catch(Exception error)
            {
                resultado = error.Message;
            }
            finally
            {
                command.Parameters.Clear();
                objConexion.cerrar();
            }

            return resultado;
        }

        public string update(entidades_resultado_operacion datos)
        {
            string resultado = "";
            string sql = "update resultadoOperacion set dato1 = @dato1, dato2 = @dato2, resultado = @resultado where id_operacion = @id_operacion";
            command.CommandText = sql;
            command.Parameters.AddWithValue("@dato1", datos.dato1);
            command.Parameters.AddWithValue("@dato2", datos.dato2);
            command.Parameters.AddWithValue("@resultado", datos.resultado);
            command.Parameters.AddWithValue("@id_operacion", datos.id_resultadoOperacion);
            Console.WriteLine(datos.id_resultadoOperacion);


            try
            {
                command.Connection = objConexion.conexion;
                objConexion.abrir();
                command.ExecuteNonQuery();

                resultado = "modificación correcta";
            }
            catch (Exception error)
            {
                resultado = error.Message;
            }
            finally
            {
                command.Parameters.Clear();
                objConexion.cerrar();
            }
            return resultado;
        }

        public entidades_resultado_operacion buscar(int id_operacion)
        {
            entidades_resultado_operacion resultado = null;
            string sql = "select * from resultadoOperacion where id_operacion = @id_operacion";
            command.CommandText = sql;
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id_operacion", id_operacion);
            command.Connection = objConexion.conexion;
            objConexion.abrir();

            SqlDataReader objreader = command.ExecuteReader();

            if (objreader.Read())
            {
                entidades_resultado_operacion objEntidad = new entidades_resultado_operacion();
                objEntidad.id_resultadoOperacion = Convert.ToInt32(objreader["id_operacion"]);
                objEntidad.dato1 = Convert.ToInt32(objreader["dato1"]);
                objEntidad.dato2 = Convert.ToInt32(objreader["dato2"]);
                objEntidad.operacion = Convert.ToString(objreader["operacion"]);
                objEntidad.resultado = Convert.ToInt32(objreader["resultado"]);

                resultado = objEntidad;
            }

            objreader.Close();
            objConexion.cerrar();
            command.Parameters.Clear();

            return resultado;
        }
    }
}
