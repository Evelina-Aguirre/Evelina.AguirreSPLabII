using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Archivos
{
    public class Txt : ISerializa<Cartuchera<Utiles>>, IDeserializa<List<Utiles>>
    {
        static string path;

        static Txt()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path += @"\EvelinaAguirre_Archivos_2C\";
        }
        public void GuardarDatos(List<Cartuchera<Utiles>> listaConDatos)
        {
            throw new NotImplementedException();
        }

        public List<Utiles> LeerDatos()
        {
            throw new NotImplementedException();
        }
    }
}
