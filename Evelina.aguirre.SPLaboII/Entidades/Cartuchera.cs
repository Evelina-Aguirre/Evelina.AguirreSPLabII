using Entidades.ExcepcionesPropias;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Cartuchera<T> where T : Utiles
    {
        public delegate void NotificadorSuperaPrecio(Cartuchera<T> cartuchera);
        public event NotificadorSuperaPrecio EventoPrecio;

        private int cantidadMaxima;
        private List<T> elementos;
        private int cantidadActual;

        public Cartuchera(int cantidadMaxima)
        {
            this.cantidadMaxima = cantidadMaxima;
        }
        public Cartuchera(int cantidadMaxima, List<T> elementos):this(cantidadMaxima)
        {
            this.elementos = elementos;
            this.cantidadActual = 0;
        }

        public int CantidadActual { get => cantidadActual; }
        public float PrecioTotal
        {
            get
            {
                if (CantidadActual > 0)
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
        /// Recorre la lista de ítems de una lista y suma el precio de sus elementos.
        /// </summary>
        /// <returns>Total acumulado</returns>
        private double CalcularPrecioTotal()
        {
            float acum = 0;

            foreach (T item in elementos)
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
            if (c.CantidadActual < c.cantidadMaxima)
            {
                c.elementos.Add(elemento);
                c.cantidadActual++;
                if(c.PrecioTotal > 500)
                {
                    c.EventoPrecio.Invoke(c);
                }
            }
            else
            {
                throw new CartucheraLlenaException();
            }
            return c;
        }

        /// <summary>
        /// Muestra los datos de una cartuchera.
        /// </summary>
        /// <returns></returns>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Capacidad cartuchera: {this.cantidadMaxima}");
            sb.AppendLine($"Cantidad de elementos: {this.CantidadActual}");
            sb.AppendLine($"Precio total: {this.PrecioTotal}");
            sb.AppendLine("\nElementos:");
            foreach (Utiles item in this.elementos)
            {
                sb.AppendLine(item.MostrarDatos());
            }
            return sb.ToString();
        }

    }
}
