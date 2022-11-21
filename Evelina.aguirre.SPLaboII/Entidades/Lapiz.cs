﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lapiz : Utiles
    {
        EColor color;
        public Lapiz(float precio, EMarca marca) : base("Lapiz",precio, marca)
        {
        }

        public Lapiz(float precio, EMarca marca, EColor color) : this(precio, marca)
        {
            this.color = color;
        }

        public EColor Color { get => color;}

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendLine($"Color: {this.Color}");
            return sb.ToString();
            
        }
    }
}
