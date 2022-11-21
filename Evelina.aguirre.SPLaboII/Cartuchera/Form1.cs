using Entidades;
using Entidades.Archivos;
using Entidades.ExcepcionesPropias;
using System;
using System.Windows.Forms;

namespace FrmCartuchera
{
    public partial class FrmManenoCartuchera : Form
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
            btnAgregar.Enabled = false;
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
            btnAgregar.Enabled = true;

        }

        private void btnGoma_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            cmbMarca.Enabled = true;
            cmbParticular.Enabled = true;
            txtPrecio.Enabled = true;
            grpCaracteristicas.Text = " Goma ";
            lblParticular.Text = "Para";
            cmbParticular.DataSource = System.Enum.GetValues(typeof(EPara));
        }

        private void btnSacapuntas_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            cmbMarca.Enabled = true;
            cmbParticular.Enabled = true;
            txtPrecio.Enabled = true;
            grpCaracteristicas.Text = " Sacapuntas ";
            lblParticular.Text = "Material";
            cmbParticular.DataSource = System.Enum.GetValues(typeof(EMaterial));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            float precio;
            string txtConComa = txtPrecio.Text.Replace('.', ',');
            txtPrecio.Text = txtConComa;
            bool esNumero = float.TryParse(txtPrecio.Text, out precio);

            try
            {    //si el monto ingresado es valido
                if (txtPrecio.Text != null && esNumero)
                {
                    //Se instancia un lapiz/goma/sacapunta según corresponda
                    Utiles util;
                    if (grpCaracteristicas.Text == " Lapiz ")
                    {
                        util = new Lapiz(float.Parse(txtPrecio.Text), (EMarca)Enum.Parse(typeof(EMarca), cmbMarca.Text),cmbParticular.Text);

                    }
                    else if (grpCaracteristicas.Text == " Goma ")
                    {
                        util = new Goma(float.Parse(txtPrecio.Text), (EMarca)Enum.Parse(typeof(EMarca), cmbMarca.Text),
                            cmbParticular.Text);
                    }
                    else
                    {
                        util = new Sacapunta(float.Parse(txtPrecio.Text), (EMarca)Enum.Parse(typeof(EMarca), cmbMarca.Text),
                             cmbParticular.Text);
                    }

                    //Intenta agregar ese elemento a la cartuchera e invoca el evento que imprime tiket en .txt
                    try
                    {
                        Mochila.Cartucheras[0] += util;
                    }
                    catch (CartucheraLlenaException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo agregar el elemento\n" + ex.Message);
                    }

                    //deshabilita la posibilidad de mofificar sin saber qué elemento será.
                    cmbMarca.Enabled = false;
                    cmbParticular.Enabled = false;
                    txtPrecio.Enabled = false;
                    btnAgregar.Enabled = false;

                    //agrega el nuevo elemento a al dgv
                    dgvElementosCartuchera.DataSource = null;
                    dgvElementosCartuchera.DataSource = Mochila.Cartucheras[0].Elementos;
                }
                else if (txtPrecio.Text == null || !esNumero)
                {
                    throw new MontoInvalidoException("Debe ingresar un valor numérico");
                }
            }
            catch (MontoInvalidoException ex)
            {
                this.lblEError.Text =ex.Message;
                timer1.Interval = 3000;
                timer1.Start();
            }
            catch(Exception ex)
            {
                this.lblEError.Text = ex.Message;
                timer1.Interval = 3000;
                timer1.Start();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblEError.Text = "";
            timer1.Stop();
        }
    }
}
