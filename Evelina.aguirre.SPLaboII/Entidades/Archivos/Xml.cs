using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Archivos
{
    public class Xml : ISerializa<Lapiz>, IDeserializa<List<Lapiz>>
    {
        static string path;

        static Xml()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path += @"\EvelinaAguirre_Archivos_2C\";
        }
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
