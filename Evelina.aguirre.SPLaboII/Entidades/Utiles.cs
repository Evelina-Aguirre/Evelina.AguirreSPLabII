using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public abstract class Utiles
    {
        private string nombre;
        private float precio;
        private string marca;

        public Utiles(string nombre, float precio, string marca)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.marca = marca;
        }

        
        public string Nombre { get => nombre;}
        public float Precio { get => precio;}
        public string Marca { get => marca;}

        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Elemento: {this.nombre}");
            sb.AppendLine($"Precio: {this.precio}");
            sb.AppendLine($"Marca: {this.marca}");
            return sb.ToString();    
        }
    }
}
