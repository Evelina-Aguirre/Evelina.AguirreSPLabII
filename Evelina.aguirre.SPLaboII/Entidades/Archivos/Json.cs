using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades.Archivos
{
    public class Json : ISerializa<Lapiz>, IDeserializa<Lapiz>
    {
        static string path;

        static Json()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path += @"\EvelinaAguirre_Archivos_2C\";
        }

        public void GuardarDatos(Lapiz lapiz)
        {
            string nombre = path + "LapicesJson.js";
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                File.WriteAllText(nombre, JsonSerializer.Serialize(lapiz));
            }
            catch (Exception ex)
            {
                throw new Exception($"No se pudo generar el Archivo : ", ex);
            }
        }

        public Lapiz LeerDatos()
        {
            string ArchivoALeer = string.Empty;
            Lapiz lapiz = null;

            try
            {
                if (Directory.Exists(path))
                {
                    string[] archivosPreviosEnEsePath = Directory.GetFiles(path);
                    foreach (string path in archivosPreviosEnEsePath)
                    {
                        if (path.Contains("LapicesJson.js"))
                        {
                            ArchivoALeer = path;
                            break;
                        }

                        if (ArchivoALeer != null)
                        {
                            lapiz = JsonSerializer.Deserialize<Lapiz>(File.ReadAllText(ArchivoALeer));
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
