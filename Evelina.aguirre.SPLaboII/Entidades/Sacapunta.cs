using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sacapunta : Utiles
    {
        
        public Sacapunta(float precio, EMarca marca, string material) : base("SACAPUNTAS",precio, marca,material)
        { 
        }
       
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendLine($"Material: {base.Caracteristica}");
            return sb.ToString();

        }
    }
    
}
