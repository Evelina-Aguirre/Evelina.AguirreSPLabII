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
            //CargaUnaCartuchera();
        }

      
        public static List<Cartuchera<Utiles>> Cartucheras { get => cartucheras; set => cartucheras = value; }

        public static void CargarMochila()
        {
            Cartuchera<Utiles> cartuchera1 = new Cartuchera<Utiles>(10);
           // Cartuchera<Utiles> cartuchera2 = new Cartuchera<Utiles>(20);

            Utiles l1 = new Lapiz(100,EMarca.sonMuyUtiles, EColor.Amarillo.ToString());
            Utiles l2 = new Lapiz(80, EMarca.UtilGenerico, EColor.Rojo.ToString());
            //Utiles l3 = new Lapiz(150, EMarca.MisUtiles, EColor.Gris);
            //Utiles g1 = new Goma(30, EMarca.sonMuyUtiles, EPara.Lapiz_Tinta);
            //Utiles g2 = new Goma(20, EMarca.MisUtiles, EPara.Lapiz);
            //Utiles s1 = new Sacapunta(50, EMarca.MisUtiles, EMaterial.Metal);

            //Utiles l4 = new Lapiz(100, EMarca.UtilGenerico, EColor.Negro);
            //Utiles l5 = new Lapiz(80, EMarca.UtilGenerico, EColor.Blanco);
            //Utiles l6 = new Lapiz(150, EMarca.UtilGenerico, EColor.Gris);
            //Utiles g3 = new Goma(30, EMarca.sonMuyUtiles, EPara.Lapiz_Tinta);
            //Utiles s2 = new Sacapunta(50, EMarca.MisUtiles, EMaterial.Metal);

            cartuchera1 += l1;
            cartuchera1 += l2;
            //cartuchera1 += l3;
            //cartuchera1 += g1;
            //cartuchera1 += g2;
            //cartuchera1 += s1;

            //cartuchera2 += l4;
            //cartuchera2 += l5;
            //cartuchera2 += l6;
            //cartuchera2 += g3;
            //cartuchera2 += s2;

            cartucheras.Add(cartuchera1);
            //Cartucheras.Add(cartuchera2);
        }

        public static void CargaUnaCartuchera()
        {
            Cartuchera<Utiles> cartuchera3 = new Cartuchera<Utiles>(10);

            Utiles l1 = new Lapiz(100, EMarca.sonMuyUtiles, EColor.Amarillo.ToString());
            Utiles l2 = new Lapiz(80, EMarca.UtilGenerico, EColor.Rojo.ToString());
            Utiles l3 = new Lapiz(150, EMarca.MisUtiles, EColor.Gris.ToString());
            Utiles g1 = new Goma(30, EMarca.sonMuyUtiles, EPara.Lapiz_Tinta.ToString());
            Utiles g2 = new Goma(20, EMarca.MisUtiles, EPara.Solo_Lapiz.ToString());
            Utiles s1 = new Sacapunta(50, EMarca.MisUtiles, EMaterial.Metal.ToString());

            cartuchera3 += l1;
            cartuchera3 += l2;
            cartuchera3 += l3;
            cartuchera3 += g1;
            cartuchera3 += g2;
            cartuchera3 += s1;

        }


    }
}
