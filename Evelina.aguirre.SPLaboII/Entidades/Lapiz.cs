using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lapiz : Utiles
    {
        ConsoleColor color;
        public Lapiz(float precio, string marca) : base("Lapiz",precio, marca)
        {
        }

        public Lapiz(float precio, string marca, ConsoleColor color) : this(precio, marca)
        {
            this.color = color;
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Color: {this.color}");
            return sb.ToString();
            
        }
    }
}
