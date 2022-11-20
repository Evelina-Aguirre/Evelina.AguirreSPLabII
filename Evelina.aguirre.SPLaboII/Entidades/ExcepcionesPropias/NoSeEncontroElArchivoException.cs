using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ExcepcionesPropias
{
    public class NoSeEncontroElArchivoException :Exception
    {
        public NoSeEncontroElArchivoException(string mensaje):base(mensaje)
        {
        }
    }
}
