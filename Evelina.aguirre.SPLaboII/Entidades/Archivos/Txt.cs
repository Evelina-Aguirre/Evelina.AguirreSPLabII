using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Entidades.ExcepcionesPropias;

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
        public void GuardarDatos(Cartuchera<Utiles> cartuchera)
        {
            //List<string> listaTickets = new List<string>();
            string nombre = path + "Tickets.txt";
            try
            {
                StreamWriter sw = new StreamWriter(nombre);
                sw.Write(cartuchera.MostrarDatos());
                sw.Close();
            }
            catch
            {
                throw new ErrorAlIntentarEscribirArchivoException("No se pudo escribir el archivo.");
            }
            
        }

        //public List<Utiles> LeerDatos()
        //{
        //    string linea;

        //    try
        //    {
        //        StreamReader sr = new StreamReader(path+ "Tickets.txt");
        //        linea = sr.ReadLine();
        //        while(linea != null)
        //        {
        //            linea = sr.ReadLine();
        //        }
        //        sr.Close();
        //    }
        //    catch
        //    {
        //        throw new NoSeEncontroElArchivoException("No se encontró el archivo.");            }
        //}
    }
}
