using Entidades.Archivos;
using System.Text;

namespace Entidades
{
    public class Lapiz : Utiles, ISerializa<Lapiz>, IDeserializa<Lapiz>
    {
        private static string formatoManejoArchivos;
        public Lapiz()
        {       
        }
        public Lapiz(float precio, EMarca marca, string caracteristica) : base("LAPIZ", precio, marca,caracteristica)
        {
        }

        public static string FormatoManejoArchivos { get => formatoManejoArchivos; set => formatoManejoArchivos = value; }
       
        /// <summary>
        /// Serializa un lapiz en formato Json o xml.
        /// </summary>
        /// <param name="lapiz"></param>
        public void GuardarDatos(Lapiz lapiz)
        {
            if (FormatoManejoArchivos == "Json")
            {
            Json<Lapiz> json = new Json<Lapiz>();
                json.GuardarDatos(lapiz);
            }
            else if(FormatoManejoArchivos == "Xml")
            {
                Xml<Lapiz> xml = new Xml<Lapiz>();
                xml.GuardarDatos(lapiz);
            }

        }

        /// <summary>
        /// Retorna un lapiz de un archivo Xml o Json preexistente.
        /// </summary>
        /// <returns></returns>
        public Lapiz LeerDatos()
        {
            Lapiz lapiz = new Lapiz(0, EMarca.UtilGenerico, "");

            if (FormatoManejoArchivos == "Json")
            {
                Json<Lapiz> json = new Json<Lapiz>();
                lapiz = json.LeerDatos();
            }
            else if (FormatoManejoArchivos == "Xml")
            {
                Xml<Lapiz> xml = new Xml<Lapiz>();
                lapiz = xml.LeerDatos();
            }

            return lapiz;
        }

        /// <summary>
        /// Sobreescribe el método MostrarDatos de útiles para agregarle el color del lapiz.
        /// </summary>
        /// <returns></returns>
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendLine($"Color: {base.Caracteristica}");
            return sb.ToString();

        }

    }
}
