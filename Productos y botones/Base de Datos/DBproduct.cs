using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Productos_y_botones.Base_de_Datos
{
     class DBproduct
    {
        public static int Agregar(Producto p)
        {
            int re = 0;
            MySqlCommand cmd = new MySqlCommand(string.Format("Insert into producto (Nombre,Id,Precio,Dimensiones,Tipo,Descripcion) " +
                "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", 
               p.Nombre, p.ID, p.Precio, p.Dimension, p.Tipo, p.Descripcion), ConexionBD.ObtenerConexion());

            re = cmd.ExecuteNonQuery();

            return re;
        }

        public static List<Producto> Buscar(string Tipo)
        {
            List<Producto> _lista = new List<Producto>();

            MySqlCommand cmd = new MySqlCommand(string.Format("SELECT NRegistro,Nombre, Id, Precio, Dimensiones,Tipo, Descripcion FROM producto  where Tipo like '{0}' ", Tipo), ConexionBD.ObtenerConexion());
                       MySqlDataReader _reader = cmd.ExecuteReader();
            while (_reader.Read())
            {
                Producto p = new Producto();
                p.NRegistro = _reader.GetInt32(0);
                p.Nombre = _reader.GetString(1);
                p.ID = _reader.GetString(2);
                p.Precio = _reader.GetDouble(3);
                p.Dimension = _reader.GetString(4);
                p.Tipo = _reader.GetString(5);
                p.Descripcion = _reader.GetString(6);
                _lista.Add(p);
            }

            return _lista;
        }


        public static List<Producto> Cargar()
        {
            List<Producto> _lista = new List<Producto>();

            MySqlCommand cmd = new MySqlCommand(string.Format("SELECT  NRegistro,Nombre, Id, Precio, Dimensiones,Tipo, Descripcion FROM producto"), ConexionBD.ObtenerConexion());
            MySqlDataReader _reader = cmd.ExecuteReader();
            while (_reader.Read())
            {
                Producto p = new Producto();
                p.NRegistro = _reader.GetInt32(0);
                p.Nombre = _reader.GetString(1);
                p.ID = _reader.GetString(2);
                p.Precio = _reader.GetDouble(3);
                p.Dimension = _reader.GetString(4);
                p.Tipo = _reader.GetString(5);
                p.Descripcion = _reader.GetString(6);
                _lista.Add(p);
            }

            return _lista;
        }


        public static Producto ObtenerProducto(int nregistro)
        {
           Producto po = new Producto();
            MySqlCommand cmd = new MySqlCommand(string.Format("SELECT NRegistro,Nombre, Id, Precio, Dimensiones,Tipo, Descripcion FROM producto  where NRegistro = {0} ", nregistro), ConexionBD.ObtenerConexion());
            MySqlDataReader _reader = cmd.ExecuteReader();
            while (_reader.Read())
            {
                //Producto po = new Producto();
                po.NRegistro = _reader.GetInt32(0);
                po.Nombre = _reader.GetString(1);
                po.ID = _reader.GetString(2);
                po.Precio = _reader.GetDouble(3);
                po.Dimension = _reader.GetString(4);
                po.Tipo = _reader.GetString(5);
                po.Descripcion = _reader.GetString(6);
                
            }

            ConexionBD.ObtenerConexion().Close();
            return po;
        }


        public static int Eliminar(int nregistro)
        {
            int re = 0;
            MySqlCommand cmd = new MySqlCommand(string.Format("Delete From producto  where NRegistro = {0} ", nregistro), ConexionBD.ObtenerConexion());



            re = cmd.ExecuteNonQuery();
            ConexionBD.ObtenerConexion().Close();
            return re;
        }

        public static int Actualizar(Producto pro)
        {
            int retorno = 0;

           // MySqlConnection conexion = ConexionBD.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand(string.Format("Update producto set Nombre = '{0}', Id = '{1}', Precio = {2}, Dimensiones = '{3}',Tipo = '{4}', Descripcion ='{5}' Where NRegistro = {6} ",
                pro.Nombre, pro.ID, pro.Precio, pro.Dimension, pro.Tipo, pro.Descripcion, pro.NRegistro), ConexionBD.ObtenerConexion());

            retorno = cmd.ExecuteNonQuery();

            ConexionBD.ObtenerConexion().Close();

            return retorno;
        }





    }
}
