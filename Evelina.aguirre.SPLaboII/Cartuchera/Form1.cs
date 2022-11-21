using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Entidades.Archivos;

namespace FrmCartuchera
{
    public partial class FrmManenoCartuchera: Form
    {
       
        Cartuchera<Utiles> cartuchera = new Cartuchera<Utiles>(10);
        public FrmManenoCartuchera()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cartuchera.EventoPrecio += Txt.GuardarDatos;
        }
         

    }
}
