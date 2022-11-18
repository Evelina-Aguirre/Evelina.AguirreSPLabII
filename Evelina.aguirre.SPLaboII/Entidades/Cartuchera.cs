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
                return (float)CalcularPrecioTotal();
            }
        }

        private double CalcularPrecioTotal()
        {
            float acum=0;
            int cont=0;
            foreach (T item in this.elementos)
            {
                acum += item.Precio;
                cont++;
            }
            return acum*cont;
        }

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
