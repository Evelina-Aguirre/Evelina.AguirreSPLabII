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

        
        public static Cartuchera<Utiles> TraeDatosDeUnaCartucheraDesdeDB()
        {
            string consulta = $"Select * from Elementos"; 
            SqlConnection conexion= new SqlConnection(conexionString);
            SqlCommand comando = new SqlCommand(consulta, conexion);
            Cartuchera<Utiles> cartuchera;

            try
            {
                cartuchera = new Cartuchera<Utiles>(20);
                Utiles elemento;
                comando.CommandText = consulta;
                conexion.Open();
                dataReader = comando.ExecuteReader();

                while (dataReader.Read())
                {
                    cartuchera = new Cartuchera<Utiles>(20);
                 
                    if(dataReader["Nombre"].ToString() == "LAPIZ")
                    {
                        elemento = new Lapiz(0,EMarca.MisUtiles,"");
                        elemento.Precio = float.Parse(dataReader["Precio"].ToString());
                        elemento.Marca = (EMarca)(Enum.Parse(typeof(EMarca), dataReader["Marca"].ToString()));
                        elemento.Caracteristica = dataReader["Caracteristica"].ToString();
                    }
                    else if (dataReader["Nombre"].ToString() == "GOMA")
                    {
                        elemento = new Goma();
                        elemento.Precio = (float)(dataReader["Precio"]);
                        elemento.Marca = (EMarca)Enum.Parse(typeof(EMarca), dataReader["Marca"].ToString());
                        elemento.Caracteristica = dataReader["Caracteristica"].ToString();
                    }
                    else
                    {
                        elemento = new Sacapunta();
                        elemento.Precio = (float)(dataReader["Precio"]);
                        elemento.Marca = (EMarca)Enum.Parse(typeof(EMarca), dataReader["Marca"].ToString());
                        elemento.Caracteristica = dataReader["Caracteristica"].ToString();
                    }

                    cartuchera.Elementos.Add(elemento);
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

        public static EMarca deStringAEnumEMarca(string marcaString)
        {
            EMarca marca = EMarca.UtilGenerico;
            switch (marcaString)
            {
                case "MisUtiles":
                    marca = EMarca.MisUtiles;
                    break;
                case "SonMuyUtiles":
                    marca = EMarca.SonMuyUtiles;
                    break;
                case "UtilGenerico":
                    marca = EMarca.UtilGenerico;
                    break;
            }
            return marca;
        }



    }
}
