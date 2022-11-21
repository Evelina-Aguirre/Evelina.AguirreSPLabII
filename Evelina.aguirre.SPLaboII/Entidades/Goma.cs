using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Goma : Utiles
    {
        private string para;
        public Goma(float precio, EMarca marca, string para) : base("Goma",precio, marca, para)
        {
        }
      
        public string Para { get => para;}

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Es para: {this.para}");
            return sb.ToString();

        }
    }
}
