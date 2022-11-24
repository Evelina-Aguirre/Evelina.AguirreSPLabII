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

        public Utiles(){
            }
        public Utiles(string nombre, float precio, EMarca marca, string caracteristica) : this()
        {
            this.nombre = nombre;
            this.precio = precio;
            this.marca = marca;
            this.caracteristica = caracteristica;
        }

        
        public string Nombre { get => nombre; set => nombre = value; }
        public float Precio { get => precio; set => precio = value; }
        public EMarca Marca { get => marca; set => marca = value; }
        public string Caracteristica { get => caracteristica; set => caracteristica = value; }

        /// <summary>
        /// Dos utiles serán iguales si todos sus atributos lo son.
        /// </summary>
        /// <param name="u1"></param>
        /// <param name="U2"></param>
        /// <returns></returns>
        public static bool operator ==(Utiles u1, Utiles U2)
        {
            return u1.Nombre == U2.Nombre && u1.Precio == U2.Precio && u1.Caracteristica == U2.Caracteristica
                && u1.Marca == U2.Marca;
        }


        /// <summary>
        /// Dos objetos son diferentes si alguno de sus atributos no coincide con el que se lo compara.
        /// </summary>
        /// <param name="u1"></param>
        /// <param name="u2"></param>
        /// <returns></returns>
        public static bool operator !=(Utiles u1, Utiles u2)
        {
            return !(u1 == u2);
        }

        /// <summary>
        /// Muestra los datos del útil.
        /// </summary>
        /// <returns></returns>
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
