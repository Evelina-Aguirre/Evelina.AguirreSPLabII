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
            Cartuchera<Utiles> cartuchera = new Cartuchera<Utiles>(2, elementos);
            Lapiz lapiz = new Lapiz(10, "Lapiz");
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
            Cartuchera<Utiles> cartuchera = new Cartuchera<Utiles>(1, elementos);
            Lapiz lapiz = new Lapiz(10, "Lapiz");
            Goma goma = new Goma(10, "Goma");

            //Act
            cartuchera += goma;
            cartuchera += lapiz;
        }

        [TestMethod]
        [ExpectedException(typeof(CartucheraVaciaException))]
        public void Prueba_excepcion_cartuchera_vacia()
        {
            //Arrange
            List<Utiles> elementos = new List<Utiles>();
            Cartuchera<Utiles> cartuchera2 = new Cartuchera<Utiles>(1, elementos);

            //Act
            float cantidadActual = cartuchera2.PrecioTotal;
            
        }

        [TestMethod]
        public void calcular_precio_total_correctamente()
        {
            //Arrange
            List<Utiles> elementos = new List<Utiles>();
            Cartuchera<Utiles> cartuchera = new Cartuchera<Utiles>(2, elementos);
            Lapiz lapiz = new Lapiz(10, "Lapiz");
            Goma goma = new Goma(10, "Goma");

            //Act
            cartuchera += lapiz;
            cartuchera += goma;

            //Assert
            Assert.AreEqual(20, cartuchera.PrecioTotal);
        }

    }
}
