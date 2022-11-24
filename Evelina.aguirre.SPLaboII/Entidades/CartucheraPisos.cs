using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CartucheraPisos : Cartuchera<Utiles>
    {
        int cantidadPisos;
        public CartucheraPisos(string nombre, int cantidadMaxima) : base(nombre, cantidadMaxima)
        {
        }
        public CartucheraPisos(string nombre, int cantidadMaxima, int cantidadPisos) :base(nombre, cantidadMaxima)
        {
            this.CantidadPisos = cantidadPisos;     
        }
        public int CantidadPisos { get => cantidadPisos; set => cantidadPisos = value; }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendLine($"Cantidad de pisos: {this.cantidadPisos}");
            return sb.ToString();
        }
    }
}
