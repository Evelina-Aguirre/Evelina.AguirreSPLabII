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
            Mochila.Cartucheras[0].EventoPrecio += Txt.GuardarDatos;
           
            grpCaracteristicas.Text = " Elemento ";
            lblParticular.Text = "Color";
            cmbMarca.Enabled = false;
            cmbParticular.Enabled = false;
            txtPrecio.Enabled = false;
        }

        private void btnLapiz_Click(object sender, EventArgs e)
        { 
            grpCaracteristicas.Text = " Lapiz ";
            lblParticular.Text = "Color";
            cmbParticular.DataSource = System.Enum.GetValues(typeof(EColor));
        }

        private void btnGoma_Click(object sender, EventArgs e)
        {
            grpCaracteristicas.Text = " Goma ";
            lblParticular.Text = "Para";
            cmbParticular.DataSource = System.Enum.GetValues(typeof(EPara));
        }

        private void btnSacapuntas_Click(object sender, EventArgs e)
        {
            grpCaracteristicas.Text = " Sacapuntas ";
            lblParticular.Text = "Material";
            cmbParticular.DataSource = System.Enum.GetValues(typeof(EMaterial));
        }
    }
}
