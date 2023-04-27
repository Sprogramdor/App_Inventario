using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Productos_y_botones.Base_de_Datos
{
    internal class ConexionBD
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=c#db;user id=root;password=12345;port=3306");
            //MySqlCommand cmd = conn.CreateCommand();
            conn.Open();
            return conn;

        }
    }
}
