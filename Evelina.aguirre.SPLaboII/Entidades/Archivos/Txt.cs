using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Entidades.ExcepcionesPropias;
using Microsoft.VisualBasic.CompilerServices;

namespace Entidades.Archivos
{
    public class Txt
    {
        static string path;
        static Txt()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path += @"\EvelinaAguirre_Archivos_2C\";
        }

        /// <summary>
        /// Guarda los datos de una cartuchera en formato .txt
        /// </summary>
        /// <param name="cartuchera"></param>
        public static void GuardarDatos(Cartuchera<Utiles> cartuchera)
        {
            string nombre = path + "Tickets.txt";
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                StreamWriter sw = new StreamWriter(nombre);
                sw.Write(cartuchera.MostrarDatos());
                sw.Close();
            }
            catch
            {
                throw new ErrorAlIntentarEscribirArchivoException("No se pudo escribir el archivo.");
            }
            
        
        }

        public static void GuardarArchivoTintaFaltante(Fibron cartuchera)
        {
            string nombre = path + "TintaFaltante.txt";
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                StreamWriter sw = new StreamWriter(nombre);
                sw.Write(cartuchera.MostrarDatos());
                sw.Close();
            }
            catch
            {
                throw new ErrorAlIntentarEscribirArchivoException("No se pudo escribir el archivo.");
            }

        }

    }
}
