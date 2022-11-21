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
            elementos = new List<T>();
            this.cantidadMaxima = cantidadMaxima;
            cantidadActual = 0;
        }

        public List<T> Elementos { get => elementos; set => elementos = value; }
        public int CantidadActual { get => cantidadActual; }


        public float PrecioTotal
        {
            get
            {
                if (CantidadActual > 0)
                {
                    return (float)CalcularPrecioTotal();
                }

                return 0;
            }
        }

        /// <summary>
        /// Recorre la lista de ítems de una lista y suma el precio de sus elementos.
        /// </summary>
        /// <returns>Total acumulado</returns>
        private double CalcularPrecioTotal()
        {
            float acum = 0;

            foreach (Utiles item in Elementos)
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
                if (c.PrecioTotal > 500)
                {
                    c.EventoPrecio.Invoke(c);
                }
            }
            else
            {
                throw new CartucheraLlenaException("La cartuchera está llena.");
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
            sb.AppendLine($"Capacidad cartuchera: {cantidadMaxima}");
            sb.AppendLine($"Cantidad de elementos: {CantidadActual}");
            sb.AppendLine($"Precio total: {PrecioTotal}\n");
            sb.AppendLine("------------------------- ");
            sb.AppendLine("Elementos:");
            foreach (Utiles item in Elementos)
            {
                sb.AppendLine(item.MostrarDatos());
            }
            return sb.ToString();
        }

    }
}
