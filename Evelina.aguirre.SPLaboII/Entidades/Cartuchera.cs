using Entidades.ExcepcionesPropias;
using System.Collections.Generic;

namespace Entidades
{
    public class Cartuchera<T> where T : Utiles
    {
        private int cantidadMaxima;
        private List<T> elementos;
        private int cantidadActual;

        public Cartuchera(int cantidadMaxima, List<T> elementos)
        {
            this.cantidadMaxima = cantidadMaxima;
            this.elementos = elementos;
            this.cantidadActual = 0;
        }

        public int CantidadActual
        {
            get
            {
                return cantidadActual;
            }
        }
        public float PrecioTotal
        {
            get
            {
               return (float)CalcularPrecioTotal();
            }
        }

        /// <summary>
        /// Recorre la lista de ítems de una lista y suma el precio de sus elementos;
        /// </summary>
        /// <returns>Total acumulado</returns>
        private double CalcularPrecioTotal()
        {
            float acum = 0;
            if (CantidadActual > 0)
            {
                foreach (T item in elementos)
                {
                    acum += item.Precio;
                }
            }
            else
            {
                throw new CartucheraVaciaException();
            }
            return acum;
        }

        /// <summary>
        /// Agrega un elemento a la cartuchera validando que esta no sobrepase su capacidad máxima.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="elemento"></param>
        /// <returns>Cartuchera con el útil agregado de tener la capacidad.</returns>
        public static Cartuchera<T> operator +(Cartuchera<T> c, T elemento)
        {
            if (c.cantidadActual < c.cantidadMaxima)
            {
                c.elementos.Add(elemento);
                c.cantidadActual++;
            }
            else
            {
                throw new CartucheraLlenaException();
            }
            return c;
        }

    }
}
