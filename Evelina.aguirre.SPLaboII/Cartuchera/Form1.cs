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
using Entidades.ExcepcionesPropias;

namespace FrmCartuchera
{
    public partial class FrmManenoCartuchera: Form
    {
       
        public FrmManenoCartuchera()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mochila.Cartucheras[0].EventoPrecio += Txt.GuardarDatos;

            dgvElementosCartuchera.DataSource = Mochila.Cartucheras[0].Elementos;
            grpCaracteristicas.Text = " Elemento ";
            lblParticular.Text = "Color";
            cmbMarca.Enabled = false;
            cmbParticular.Enabled = false;
            txtPrecio.Enabled = false;
        }

        private void btnLapiz_Click(object sender, EventArgs e)
        {
            cmbMarca.Enabled = true;
            cmbMarca.DataSource = System.Enum.GetValues(typeof(EMarca));
            cmbParticular.Enabled = true;
            cmbParticular.DataSource = System.Enum.GetValues(typeof(EColor));
            txtPrecio.Enabled = true;
            grpCaracteristicas.Text = " Lapiz ";
            lblParticular.Text = "Color";

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

        private void button7_Click(object sender, EventArgs e)
        {
            cmbMarca.Enabled = false;
            cmbParticular.Enabled = false;
            txtPrecio.Enabled = false;
            Utiles util;
            if (grpCaracteristicas.Text == " Lapiz ")
            {
             util = new Lapiz(Convert.ToInt32(txtPrecio.Text), (EMarca)Enum.Parse(typeof(EMarca),this.cmbMarca.Text), (EColor)Enum.Parse(typeof(EColor), this.cmbParticular.Text));

            }else if(grpCaracteristicas.Text == " Goma ")
            {
                 util = new Goma(Convert.ToInt32(txtPrecio.Text), (EMarca)Enum.Parse(typeof(EMarca), this.cmbMarca.Text), (EPara)Enum.Parse(typeof(EPara), this.cmbParticular.Text));

            }
            else
            {
                util = new Sacapunta(Convert.ToInt32(txtPrecio.Text), (EMarca)Enum.Parse(typeof(EMarca), this.cmbMarca.Text), (EMaterial)Enum.Parse(typeof(EMaterial), this.cmbParticular.Text));
            }

            try
            {

            Mochila.Cartucheras[0] += util;
            }catch(CartucheraLlenaException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo agregar el elemento\n" + ex.Message);
            }

            this.dgvElementosCartuchera.DataSource = null;
            this.dgvElementosCartuchera.DataSource = Mochila.Cartucheras[0].Elementos;



        }
    }
}
