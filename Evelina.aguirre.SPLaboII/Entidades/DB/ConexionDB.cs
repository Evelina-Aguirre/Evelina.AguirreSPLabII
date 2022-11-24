using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.DB
{
    public static class ConexionDB
    {
        static SqlConnection conexion;
        static SqlCommand comando;
        static SqlDataReader dataReader;
        static string conexionString = @"Data Source=.\sqlexpress;Database=Utiles;Trusted_Connection=True;TrustServerCertificate=True;";
        static ConexionDB()
        {
            conexion = new SqlConnection();
            comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
        }

        /// <summary>
        /// Agrega un elemento a la DB.
        /// </summary>
        /// <param name="util"></param>
        public static void AgregaElementoEnDB(Utiles util)
        {
            string consulta = $"Insert into [Utiles].[dbo].[Cartuchera1]";
            SqlConnection conexion = new SqlConnection(conexionString);
            SqlCommand comando = new SqlCommand(consulta, conexion);

            comando.CommandText = $"Insert into [Utiles].[dbo].[Cartuchera1] (Nombre, Precio, Marca, Caracteristica) values ('{util.Nombre}','{util.Precio}'," +
                $"'{util.Marca}','{util.Caracteristica}')";
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            finally
            {
                conexion.Close();
            }

        }

        /// <summary>
        /// Trae una cartuchera desde db.
        /// </summary>
        /// <returns></returns>
        public static Cartuchera<Utiles> TraeDatosDeUnaCartucheraDesdeDB()
        {
            string consulta = $"Select * FROM [Utiles].[dbo].[Cartuchera1]"; 
            SqlConnection conexion= new SqlConnection(conexionString);
            SqlCommand comando = new SqlCommand(consulta, conexion);
            Cartuchera<Utiles> cartuchera;
            Utiles elemento;
            

            try
            {
                cartuchera = new Cartuchera<Utiles>("cartuchera",20);
                comando.CommandText = consulta;
                conexion.Open();
                dataReader = comando.ExecuteReader();

                while (dataReader.Read())
                {
                 
                    if(dataReader["Nombre"].ToString() == "LAPIZ")
                    {
                        elemento = new Lapiz(0,EMarca.MisUtiles,"");
                        elemento.Precio = float.Parse(dataReader["Precio"].ToString());
                        elemento.Marca = (EMarca)(Enum.Parse(typeof(EMarca), dataReader["Marca"].ToString()));
                        elemento.Caracteristica = dataReader["Caracteristica"].ToString();
                        cartuchera.Elementos.Add(elemento);
                    }
                    else if (dataReader["Nombre"].ToString() == "GOMA")
                    {
                        elemento = new Goma(0, EMarca.MisUtiles, "");
                        elemento.Precio = float.Parse(dataReader["Precio"].ToString());
                        elemento.Marca = (EMarca)Enum.Parse(typeof(EMarca), dataReader["Marca"].ToString());
                        elemento.Caracteristica = dataReader["Caracteristica"].ToString();
                        cartuchera.Elementos.Add(elemento);
                    }
                    else
                    {
                        elemento = new Sacapunta(0, EMarca.MisUtiles, "");
                        elemento.Precio = float.Parse(dataReader["Precio"].ToString());
                        elemento.Marca = (EMarca)Enum.Parse(typeof(EMarca), dataReader["Marca"].ToString());
                        elemento.Caracteristica = dataReader["Caracteristica"].ToString();
                        cartuchera.Elementos.Add(elemento);
                    }

                }
            }
            catch (Exception)
            {
                throw new Exception("Error de conexión a la base de datos");
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return cartuchera;
        }


        public static void borraElementosActualesEnUnaCartucheraEnDB()
        {
            string consulta = $"DELETE FROM [Utiles].[dbo].[Cartuchera1]";
            SqlConnection conexion = new SqlConnection(conexionString);
            SqlCommand comando = new SqlCommand(consulta, conexion);

            comando.CommandText = consulta;
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            finally
            {
                conexion.Close();
            }

        }

    }
}
