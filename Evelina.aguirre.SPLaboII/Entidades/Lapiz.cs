using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lapiz : Utiles
    {
        private string color;
        public Lapiz(float precio, EMarca marca, string color) : base("Lapiz",precio, marca, color)
        {
            this.color = color;
        }

        public string Color { get => color; }

        private static string caracteristicaString(EColor color)
        {
            string aux = color.ToString();
            return aux;
        }
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendLine($"Color: {this.Color}");
            return sb.ToString();
            
        }
    }
}
