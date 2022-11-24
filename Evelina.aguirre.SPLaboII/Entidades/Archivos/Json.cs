using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades.Archivos
{
    public class Json<T> where T : Utiles
    {
        static string path;

        static Json()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path += @"\EvelinaAguirre_Archivos_2C\";
        }

        /// <summary>
        /// Guarda los datos de un lapiz en formato Json.
        /// </summary>
        /// <param name="lapiz"></param>
        public void GuardarDatos(T lapiz)
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

        /// <summary>
        /// Lee datos de un lapiz desde un archivo Json.
        /// </summary>
        /// <returns></returns>
        public T LeerDatos()
        {
            string ArchivoALeer = string.Empty;
            T lapiz = null;

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
                        }

                        if (ArchivoALeer != null)
                        {
                            lapiz = JsonSerializer.Deserialize<T>(File.ReadAllText(ArchivoALeer));
                          
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
