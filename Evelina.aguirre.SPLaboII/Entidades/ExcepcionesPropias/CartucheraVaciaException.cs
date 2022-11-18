using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ExcepcionesPropias
{
    class CartucheraVaciaException :Exception 
    {
        public CartucheraVaciaException() : base()
        {
        }
        public CartucheraVaciaException(string mensaje) : base(mensaje)
        {
        }
    }
}
