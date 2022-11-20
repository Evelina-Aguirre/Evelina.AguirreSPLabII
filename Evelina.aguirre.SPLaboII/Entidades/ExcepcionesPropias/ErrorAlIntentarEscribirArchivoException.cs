using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ExcepcionesPropias
{
    public class ErrorAlIntentarEscribirArchivoException : Exception
    {
        public ErrorAlIntentarEscribirArchivoException():base()
        {
        }
        public ErrorAlIntentarEscribirArchivoException(string mensaje) : base(mensaje)
        {
        }
    }
}
