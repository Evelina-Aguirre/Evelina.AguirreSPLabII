using Entidades;
using FrmCartuchera;
using System;
using System.Windows.Forms;

namespace útiles
{
    public partial class FrmModificar : Form
    {
        int m, mx, my;
        Utiles util;
        FrmManenoCartuchera frmCartuchera;

        public Utiles Util { get => util; set => util = value; }

        public FrmModificar()
        {
            InitializeComponent();

        }

        public FrmModificar(Utiles elemento, FrmManenoCartuchera cartuchera) : this()
        {
            if (elemento is Lapiz)
            {
                util = new Lapiz();
            }
            else if (elemento is Goma)
            {
                util = new Goma();
            }
            else { util = new Sacapunta(); }
            frmCartuchera = cartuchera;
            util = elemento;
            lblNombre.Text = elemento.Nombre;
            lbl_Precio.Text = elemento.Precio.ToString();
            lblMarca.Text = elemento.Marca.ToString();
            lblCaracteristica.Text = elemento.Caracteristica;
        }

        private void FrmModificar_Load(object sender, EventArgs e)
        {
            cmbMarca.DataSource = System.Enum.GetValues(typeof(EMarca));
            if (util.Nombre == "LAPIZ")
            {
                cmbCaracteristica.DataSource = System.Enum.GetValues(typeof(EColor));
            }
            else if (util.Nombre == "GOMA")
            {
                cmbCaracteristica.DataSource = System.Enum.GetValues(typeof(EPara));
            }
            else if (util.Nombre == "SACAPUNTAS")
            {
                cmbCaracteristica.DataSource = System.Enum.GetValues(typeof(EMaterial));
            }
        }

        private void llbMinimizar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void llbCerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int abonaCon;
            bool esNumero = int.TryParse(txtNuevoPrecio.Text, out abonaCon);
            Utiles utilAux = null;

            //Cambio Precio
            if (txtNuevoPrecio.Text != null && esNumero && abonaCon > 0)
            {
                DialogResult resultado = MessageBox.Show($"Item:  {lblNombre.Text}  --  Precio: {lbl_Precio.Text} \n\nNuevo Precio:         $" +
                   $"{txtNuevoPrecio.Text}\nNueva Marca:      {cmbMarca.SelectedItem.ToString()}", "Desdea Guardar los cambios?"
               , MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    if (lblNombre.Text == "LAPIZ")
                    {
                        utilAux = new Lapiz(float.Parse(txtNuevoPrecio.Text), (EMarca)cmbMarca.SelectedItem,
                            cmbCaracteristica.SelectedItem.ToString());
                        Mochila.Cartucheras[0] -= util;
                        Mochila.Cartucheras[0] += utilAux;
                    }
                    else if (lblNombre.Text == "GOMA")
                    {
                        utilAux = new Goma(float.Parse(txtNuevoPrecio.Text), (EMarca)cmbMarca.SelectedItem,
                            cmbCaracteristica.SelectedItem.ToString());
                        Mochila.Cartucheras[0] -= util;
                        Mochila.Cartucheras[0] += utilAux;
                    }
                    else if (lblNombre.Text == "SACAPUNTAS")
                    {
                        utilAux = new Sacapunta(float.Parse(txtNuevoPrecio.Text), (EMarca)cmbMarca.SelectedItem,
                             cmbCaracteristica.SelectedItem.ToString());
                        Mochila.Cartucheras[0] -= util;
                        Mochila.Cartucheras[0] += utilAux;
                        
                    }
   
                    this.Close();
                }
                else
                {
                    Close();
                }


            }
            else
            {
                lblError.Text = "Monto inválido";
                timerError.Interval = 3000;
                timerError.Start();
            }

            if (cmbMarca.SelectedIndex == -1 || cmbCaracteristica.SelectedIndex == -1)
            {
                lblError.Text = "Debe seleccionar marca y característica";
                timerError.Interval = 3000;
                timerError.Start();
            }
        }

        private void timerError_Tick(object sender, EventArgs e)
        {
            lblError.Text = "";
            timerError.Stop();
        }

    }
}
