using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CartucheraSobre :Cartuchera<Utiles>
    {
        EMaterialCartuchera material;
        public CartucheraSobre(string nombre, int cantidadMaxima) :base(nombre,cantidadMaxima)
        {     
        }
        public CartucheraSobre(string nombre, int cantidadMaxima, EMaterialCartuchera material ) : this(nombre,cantidadMaxima)
        {
            this.material = material;
        }
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendLine($"Material: {this.material}");
            return sb.ToString();
        }
    }
}
