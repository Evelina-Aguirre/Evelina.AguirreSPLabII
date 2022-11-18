using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lapiz : Utiles
    {
        public Lapiz(int cantidadMaxima, List<Utiles> elementos) : base(cantidadMaxima, elementos)
        {
        }
    }
}
