using Entidades.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Mochila
    {
        private static List<Cartuchera<Utiles>> cartucheras;

        static Mochila()
        {
            cartucheras = new List<Cartuchera<Utiles>>();
            CargarMochila();
        }

        public static List<Cartuchera<Utiles>> Cartucheras { get => cartucheras; set => cartucheras = value; }


        /// <summary>
        /// Carga la Mochilca con una cartuchera.
        /// </summary>
        public static void CargarMochila()
        {
            Cartuchera<Utiles> cartuchera = new Cartuchera<Utiles>("Cartuchera1", 20);
            cartuchera = ConexionDB.TraeDatosDeUnaCartucheraDesdeDB();
            cartucheras.Add(cartuchera);
        }


    }
}
