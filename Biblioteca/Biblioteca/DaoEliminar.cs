using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class DaoEliminar
    {
        public bool MeliminarLibro(clsEliminar elim)
        {
            MySqlConnection conexxion = new MySqlConnection();
            MySqlCommand comando = new MySqlCommand();
            try
            {
                conexxion.ConnectionString = "server=192.168.1.74; database=biblioteca; user=admin; pwd=itsur123;";
                conexxion.Open();

                string strSQL = "delete from libros where Id = " + elim.ID;
                comando = new MySqlCommand(strSQL, conexxion);



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
