using Entidades.Archivos;
using System.Text;

namespace Entidades
{
    public class Lapiz : Utiles, ISerializa<Lapiz>, IDeserializa<Lapiz>
    {
        private static string formatoManejoArchivos;


        public Lapiz() : base()
        {
        }
        public Lapiz(float precio, EMarca marca, string color) : base("LAPIZ", precio, marca, color)
        {
        }

        public static string FormatoManejoArchivos { get => formatoManejoArchivos; set => formatoManejoArchivos = value; }


        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendLine($"Color: {base.Caracteristica}");
            return sb.ToString();

        }

        /// <summary>
        /// Serializa un lapiz en formato Json o xml.
        /// </summary>
        /// <param name="lapiz"></param>
        public void GuardarDatos(Lapiz lapiz)
        {
            if (FormatoManejoArchivos == "Json")
            {
            Json json = new Json();
                json.GuardarDatos(lapiz);

            }
            else if(FormatoManejoArchivos == "Xml")
            {
                Xml xml = new Xml();
                xml.GuardarDatos(lapiz);
            }

        }

        /// <summary>
        /// Retorna un lapiz de un archivo Xml o Json preexistente.
        /// </summary>
        /// <returns></returns>
        public Lapiz LeerDatos()
        {
            Lapiz lapiz = new Lapiz();

            if (FormatoManejoArchivos == "Json")
            {
                Json json = new Json();
                lapiz = json.LeerDatos();
            }
            else if (FormatoManejoArchivos == "Xml")
            {
                Xml xml = new Xml();
                lapiz = xml.LeerDatos();
            }

            return lapiz;
        }

    }
}
