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
                conexxion.ConnectionString = "server=localhost; database=itsur; user=root; pwd=root1";
                conexxion.Open();

                comando.CommandText = "insertarProducto";
                comando.Connection = conexxion;
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("idProducto", null);
                comando.Parameters.AddWithValue("Nombre", agre.Nombre);
                comando.Parameters.AddWithValue("Precio", agre.Precio);
                comando.Parameters.AddWithValue("Cantidad", agre.Cantidad);
                comando.Parameters.AddWithValue("Descripcion", agre.Descripcion);
                comando.Parameters.AddWithValue("Partida", agre.Partida);



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
