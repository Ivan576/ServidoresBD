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
        public bool MEliminarProducto(clsEliminar elim)
        {
            MySqlConnection conexxion = new MySqlConnection();
            MySqlCommand comando = new MySqlCommand();
            try
            {
                conexxion.ConnectionString = "server=localhost; database=biblioteca; user=root; pwd=root1";
                conexxion.Open();

                string strSQL = "delete from productos where idProducto = " + elim.ID;
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
