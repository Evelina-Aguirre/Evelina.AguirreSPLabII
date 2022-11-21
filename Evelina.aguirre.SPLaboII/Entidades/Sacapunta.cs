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
        public Sacapunta(float precio, string marca) : base("sacapuntas",precio, marca)
        {
        }
        public Sacapunta(EMaterial material,float precio, string marca) : this(precio, marca)
        {
            this.material = material;
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Material: {this.material}");
            return sb.ToString();

        }
    }
    
}
