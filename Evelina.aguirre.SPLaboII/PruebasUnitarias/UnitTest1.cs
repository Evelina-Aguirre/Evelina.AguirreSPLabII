using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Entidades.ExcepcionesPropias;

namespace PruebasUnitarias
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Prueba_agregar_elemento_a_cartuchera_operador_mas()
        {
            //Arrange
            List<Utiles> elementos = new List<Utiles>();
            Cartuchera<Utiles> cartuchera = new Cartuchera<Utiles>("auxCart",2);
            Lapiz lapiz = new Lapiz();
            elementos.Add(lapiz);

            //Act
            cartuchera += lapiz;

            //Assert
            Assert.AreEqual(1, cartuchera.CantidadActual);
        }

        [TestMethod]
        [ExpectedException(typeof(CartucheraLlenaException))]
        public void Prueba_excepcion_cartuchera_llena()
        {
            //Arrange
            List<Utiles> elementos = new List<Utiles>();
            Cartuchera<Utiles> cartuchera = new Cartuchera<Utiles>("auxCart", 1);
            Lapiz lapiz = new Lapiz(10, EMarca.MisUtiles, "");
            Lapiz lapiz1 = new Lapiz(10, EMarca.MisUtiles, "");
            elementos.Add(lapiz);
            elementos.Add(lapiz1);

            //Act
            cartuchera += lapiz1;
            cartuchera += lapiz;
        }


        [TestMethod]
        public void calcular_precio_total_correctamente()
        {
            //Arrange
           List<Utiles> elementos = new List<Utiles>();
            Cartuchera<Utiles> cartuchera = new Cartuchera<Utiles>("auxCart",2);
            Lapiz lapiz = new Lapiz(10,EMarca.MisUtiles,"");
            Lapiz lapiz1 = new Lapiz(10, EMarca.MisUtiles, "");
            elementos.Add(lapiz);
            elementos.Add(lapiz1);


            //Act
            cartuchera += lapiz;
            cartuchera += lapiz1;

            //Assert
            Assert.AreEqual(20, cartuchera.PrecioTotal);
        }

    }
}
