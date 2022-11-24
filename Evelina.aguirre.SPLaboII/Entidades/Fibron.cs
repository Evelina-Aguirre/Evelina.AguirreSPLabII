using Entidades.Archivos;
using Entidades.ExcepcionesPropias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fibron : Utiles,ISerializa<Fibron>,IDeserializa<Fibron>
    {
        public delegate void NotificadotSinTinta(Fibron fibron);
        public event NotificadotSinTinta EventoTinta;
        private static string formatoManejoArchivos;

        int cantidadTinta;
        EColor color;
        public Fibron()
        {
        }
        public Fibron(float precio, EMarca marca, string caracteristica) 
        {
        }
        public Fibron(float precio, EMarca marca, string caracteristica,int cantidadTinta )
            : this( precio, marca, caracteristica)
        {
            this.cantidadTinta = 10;
        }

        public static string FormatoManejoArchivos { get => formatoManejoArchivos; set => formatoManejoArchivos = value; }
        public int CantidadTinta { get => cantidadTinta; set => cantidadTinta = value; }
        public EColor Color { get => color; set => color = value; }

        public void Resaltar()
        {
            if(CantidadTinta >0)
            {
              cantidadTinta--;
            }
            else
            {
                EventoTinta.Invoke(this);
                throw new SinTintaException($"Sin tinta, cantidad actual = {this.cantidadTinta} ");
            }
            this.EventoTinta += Txt.GuardarArchivoTintaFaltante;

        }

        /// <summary>
        /// Serializa un fibron en formato Json o xml.
        /// </summary>
        /// <param name="lapiz"></param>
        public void GuardarDatos(Fibron fibron)
        {
            if (FormatoManejoArchivos == "Json")
            {
                Json<Fibron> json = new Json<Fibron>();
                json.GuardarDatos(fibron);
            }
            else if (FormatoManejoArchivos == "Xml")
            {
                Xml<Fibron> xml = new Xml<Fibron>();
                xml.GuardarDatos(fibron);
            }

        }

        /// <summary>
        /// Retorna un fibron de un archivo Xml o Json preexistente.
        /// </summary>
        /// <returns></returns>
        public Fibron LeerDatos()
        {
            Fibron fibron = new Fibron(0, EMarca.UtilGenerico, "");

            if (FormatoManejoArchivos == "Json")
            {
                Json<Fibron> json = new Json<Fibron>();
                fibron = json.LeerDatos();
            }
            else if (FormatoManejoArchivos == "Xml")
            {
                Xml<Fibron> xml = new Xml<Fibron>();
                fibron = xml.LeerDatos();
            }

            return fibron;
        }

    }
}
