using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class DaoVer
    {
        public List<clsVer> MmostrarLibros()
        {
            MySqlConnection cn = new MySqlConnection();

            cn.ConnectionString = cn.ConnectionString = "server=192.168.1.74; database=biblioteca; user=admin; pwd=itsur123;";
            cn.Open();

            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "verLibros";
            comando.Connection = cn;
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            List<clsVer> lista = new List<clsVer>();
            MySqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    clsVer obj = new clsVer();
                    obj.ID = dr.GetInt32("Id");
                    obj.ISBN = dr.GetInt32("Isbn");
                    obj.Titulo = dr.GetString("Titulo");
                    obj.NumEdicion = dr.GetInt32("NumEdicion");
                    //obj.Año = dr.GetInt32("Año");
                    obj.Autor = dr.GetString("Autor");
                    obj.PaisP = dr.GetString("PaisP");
                    obj.Sinopsis = dr.GetString("Sinopsis");
                    obj.Carrera = dr.GetString("Carrera");
                    obj.Materia = dr.GetString("Materia");

                    lista.Add(obj);
                }
                comando.Dispose();

                /// FINALIZAMOS LA CONEXION CERRAMOS TODO
                cn.Close();
                cn.Dispose();
           
            
            return lista;
        }
    }
}
