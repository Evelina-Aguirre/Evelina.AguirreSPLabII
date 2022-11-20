using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ExcepcionesPropias
{
    public class CartucheraLlenaException : Exception
    {
        public CartucheraLlenaException() : base()
        {      
        }
        public CartucheraLlenaException(string mensaje) : base(mensaje)
        {
        }
    }
}
