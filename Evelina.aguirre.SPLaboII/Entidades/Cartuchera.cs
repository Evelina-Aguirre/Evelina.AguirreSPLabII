using Entidades.ExcepcionesPropias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public float PrecioTotal
        {
            get
            {
                if(this.cantidadActual > 0)
                {
                  return (float)CalcularPrecioTotal();
                }
                else
                {
                    throw new CartucheraVaciaException();
                }
            }
        }

        /// <summary>
        /// Recorre la lista de ítems de una lista y suma el precio de sus elementos;
        /// </summary>
        /// <returns>Total acumulado</returns>
        private double CalcularPrecioTotal()
        {
            float acum=0;
            foreach (T item in this.elementos)
            {
                acum += item.Precio;
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
            if(c.cantidadActual < c.cantidadMaxima)
            {
                c.elementos.Add(elemento);
            }
            else
            {
                throw new CartucheraLlenaException();
            }
            return c;
        }

    }
}
