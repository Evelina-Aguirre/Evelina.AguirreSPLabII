using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Archivos
{
    public class Json : ISerializa<Lapiz>, IDeserializa<List<Lapiz>>
    {
        public void GuardarDatos(List<Lapiz> listaConDatos)
        {
            throw new NotImplementedException();
        }

        public List<Lapiz> LeerDatos()
        {
            throw new NotImplementedException();
        }
    }
}
