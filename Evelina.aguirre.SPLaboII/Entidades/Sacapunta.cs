using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sacapunta : Utiles
    {
        EMaterial material;
        public Sacapunta(float precio, EMarca marca) : base("sacapuntas",precio, marca)
        {
        }
        public Sacapunta(float precio, EMarca marca, EMaterial material) : this(precio, marca)
        {
            this.material = material;
        }

        public EMaterial Material { get => material; }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Material: {this.Material}");
            return sb.ToString();

        }
    }
    
}
