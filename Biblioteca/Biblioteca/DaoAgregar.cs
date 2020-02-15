using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class DaoAgregar
    {
        public bool MAgregarlibro(clsAgregar agre)
        {
            MySqlConnection conexxion = new MySqlConnection();
            MySqlCommand comando = new MySqlCommand();
            try
            {
                conexxion.ConnectionString = "server=localhost; database=biblioteca; user=root; pwd=root1";
                conexxion.Open();

                comando.CommandText = "InsertarLibro";
                comando.Connection = conexxion;
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("Id", null);
                comando.Parameters.AddWithValue("Isbn", agre.ISBN);
                comando.Parameters.AddWithValue("Titulo", agre.Titulo);
                comando.Parameters.AddWithValue("NumEdicion", agre.NumEdicion);
                comando.Parameters.AddWithValue("Año", agre.AñoP);
                comando.Parameters.AddWithValue("Autor", agre.Autor);
                comando.Parameters.AddWithValue("PaisP", agre.PaisP);
                comando.Parameters.AddWithValue("Sinopsis", agre.Sinopsis);
                comando.Parameters.AddWithValue("Carrera", agre.Carrera);
                comando.Parameters.AddWithValue("Materia", agre.Materia);
                comando.ExecuteNonQuery();
            }
            catch
            {

                return false;

            }
            finally
            {
                comando.Dispose();
                conexxion.Close();
                conexxion.Dispose();

            }

            return true;

        }
    }
}
