using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades.Archivos
{
    public class Xml : ISerializa<Lapiz>, IDeserializa<Lapiz>
    {
        static string path;
        static Xml()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path += @"\EvelinaAguirre_Archivos_2C\";
        }

        /// <summary>
        /// Guarda los datos de un lapiz en formato Xml.
        /// </summary>
        /// <param name="lapiz"></param>
        public void GuardarDatos(Lapiz lapiz)
        {
            string nombre = path + "LapizXml.xml";
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                using (StreamWriter writer = new StreamWriter(nombre))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Lapiz));

                    xmlSerializer.Serialize(writer, lapiz);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"No se pudo generar el Archivo : ", ex);
            }

        }

        /// <summary>
        /// Lee datos de un lapiz desde un archivo Xml.
        /// </summary>
        /// <returns></returns>
        public Lapiz LeerDatos()
        {
            Lapiz lapiz = null;

            try
            {
                string rutaArchivoPrevioEnPath = string.Empty;
                string ArchivoALeer = string.Empty;

                if (Directory.Exists(path))
                {

                    string[] archivosPreviosEnEsePath = Directory.GetFiles(path);
                    foreach (string path in archivosPreviosEnEsePath)
                    {
                        if (path.Contains("LapizXml.xml"))
                        {
                            ArchivoALeer = path;
                            break;
                        }

                        if (ArchivoALeer != null)
                        {
                            using (StreamReader reader = new StreamReader(ArchivoALeer))
                            {
                                XmlSerializer serializer = new XmlSerializer(typeof(Lapiz));
                                lapiz = (Lapiz)serializer.Deserialize(reader);

                            }
                        }
                    }

                }
                return lapiz;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al intentar leer Archivo : ", ex);
            }
        }
    
    }
}
