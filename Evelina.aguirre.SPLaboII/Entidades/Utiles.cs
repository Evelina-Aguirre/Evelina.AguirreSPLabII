using System;
using System.Collections.Generic;

namespace Entidades
{
    public abstract class Utiles
    {
        private float precio;
        private string marca;

        public Utiles(float precio, string marca)
        {
            this.precio = precio;
            this.marca = marca;
        }

        public float Precio
        {
            get
            {
                return this.precio;
            }
        }

        public string Marca
        {
            get
            {
                return this.Marca;
            }
        }
    }
}
