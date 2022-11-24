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
            CargarMochilaCartucheraFirbones();
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

        public static void CargarMochilaCartucheraFirbones()
        {
            Cartuchera<Utiles> cartucheraFirbones = new Cartuchera<Utiles>("Cartuchera1", 20);
            
            Fibron f1 = new Fibron(100, EMarca.MisUtiles, "Amarillo", 10);
            Fibron f2 = new Fibron(100, EMarca.MisUtiles, "Naranja", 10);
            Fibron f3 = new Fibron(100, EMarca.MisUtiles, "Verde", 10);

            cartucheraFirbones.Elementos.Add(f1);
            cartucheraFirbones.Elementos.Add(f2);
            cartucheraFirbones.Elementos.Add(f3);

            cartucheras.Add(cartucheraFirbones);

        }


    }
}
