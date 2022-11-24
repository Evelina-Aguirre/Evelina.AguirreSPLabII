using Entidades.ExcepcionesPropias;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Cartuchera<T> where T : Utiles
    {
        public delegate void NotificadorSuperaPrecio(Cartuchera<T> cartuchera);
        public event NotificadorSuperaPrecio EventoPrecio;


        private string nombre;
        private int cantidadMaxima;
        private List<T> elementos;
        private int cantidadActual;

        
        public Cartuchera(string nombre, int cantidadMaxima)
        {
            this.nombre = nombre;
            elementos = new List<T>();
            this.cantidadMaxima = cantidadMaxima;
            cantidadActual = elementos.Count;
        }

        public List<T> Elementos { get => elementos; set => elementos = value; }
        public int CantidadActual { get => elementos.Count;}
        public int CantidadMaxima { get => cantidadMaxima; set => cantidadMaxima = value; }
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
        /// Remueve un elemento a la cartuchera
        /// </summary>
        /// <param name="c"></param>
        /// <param name="util"></param>
        /// <returns></returns>
        public static Cartuchera<T> operator -(Cartuchera<T> c, T util)
        {
            bool existe = false;
            int index = -1;
            if (c.elementos.Count > 0)
            {
                foreach (T item in c.elementos)
                {
                    if (item == util)
                    {
                        existe = true;
                        index = c.elementos.IndexOf(item);
                    }
                }
                if (existe)
                {
                    c.elementos.RemoveAt(index);
                }

             }
            return c;
        }

        /// <summary>
        /// Busca un elemento en la cartuchera.
        /// </summary>
        /// <param name="util"></param>
        /// <returns></returns>
        public T BuscarElementoEnCartuchera(T util)
        {
            foreach (T item in elementos)
            {
                if(item == util)
                {
                    return item;
                }
            }
            return null;
        }
        /// <summary>
        /// Muestra los datos de una cartuchera.
        /// </summary>
        /// <returns></returns>
        public  virtual string MostrarDatos()
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
