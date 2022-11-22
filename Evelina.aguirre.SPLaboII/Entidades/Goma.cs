using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Goma : Utiles
    {
        public Goma()
        {

        }
        public Goma(float precio, EMarca marca, string para) : base("GOMA",precio, marca, para)
        {
        }
      
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendLine($"Utilidad: {base.Caracteristica}");
            return sb.ToString();

        }
    }
}
