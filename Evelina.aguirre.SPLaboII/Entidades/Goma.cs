using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Goma : Utiles
    {
        EPara para;
        public Goma(float precio, EMarca marca) : base("Goma",precio, marca)
        {
        }
        public Goma(float precio, EMarca marca, EPara para) : this(precio, marca)
        {
            this.para = para;
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Es para: {this.para}");
            return sb.ToString();

        }
    }
}
