using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public abstract class Utiles
    {
        private string nombre;
        private float precio;
        private EMarca marca;

        public Utiles(string nombre, float precio, EMarca marca)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.marca = marca;
           // this.caraccteristicaParticular = caraccteristicaParticular;
        }

        
        public string Nombre { get => nombre;}
        public float Precio { get => precio;}
        public EMarca Marca { get => marca;}
        //public T CaraccteristicaParticular { get => caraccteristicaParticular; }

        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\n             ");
            sb.AppendLine($"{this.nombre}");
            sb.AppendLine($"Precio: {this.precio}");
            sb.AppendLine($"Marca: {this.marca}");
            return sb.ToString();    
        }
    }
}
