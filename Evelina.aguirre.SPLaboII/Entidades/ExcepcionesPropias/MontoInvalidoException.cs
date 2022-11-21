using System;

namespace Entidades.ExcepcionesPropias
{
    public class MontoInvalidoException : Exception
    {
        public MontoInvalidoException(string msj) : base(msj)
        {
        }
    }
}
