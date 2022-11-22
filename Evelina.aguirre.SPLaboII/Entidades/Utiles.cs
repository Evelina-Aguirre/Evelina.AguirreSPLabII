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
        string caracteristica;

        public Utiles()
        {     
        }
        public Utiles(string nombre, float precio, EMarca marca, string caracteristica)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.marca = marca;
            this.caracteristica = caracteristica;
        }

        
        public string Nombre { get => nombre;}
        public float Precio { get => precio;}
        public EMarca Marca { get => marca;}
        public string Caracteristica { get => caracteristica;}

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
