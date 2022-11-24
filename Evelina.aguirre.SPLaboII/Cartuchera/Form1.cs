using Entidades;
using Entidades.Archivos;
using Entidades.DB;
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

            cmbMarca.DataSource = System.Enum.GetValues(typeof(EMarca));
            dgvElementosCartuchera.DataSource = Mochila.Cartucheras[0].Elementos;
            grpCaracteristicas.Text = " Elemento ";
            lblParticular.Text = "Color";
            cmbMarca.Enabled = false;
            cmbParticular.Enabled = false;
            txtPrecio.Enabled = false;
            btnAgregar.Enabled = false;
            this.lblCantidad.Text = Mochila.Cartucheras[0].Elementos.Count.ToString();
        }

        private void btnLapiz_Click(object sender, EventArgs e)
        {
            cmbMarca.Enabled = true;
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
                        util = new Lapiz(float.Parse(txtPrecio.Text), (EMarca)Enum.Parse(typeof(EMarca), cmbMarca.Text), cmbParticular.Text);

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
                    this.lblCantidad.Text = "Cantidad Actual: " + Mochila.Cartucheras[0].Elementos.Count.ToString();
                }
                else if (txtPrecio.Text == null || !esNumero)
                {
                    throw new MontoInvalidoException("Debe ingresar un valor numérico");
                }
            }
            catch (MontoInvalidoException ex)
            {
                this.lblEError.Text = ex.Message;
                timer1.Interval = 3000;
                timer1.Start();
            }
            catch (Exception ex)
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExportarJson_Click(object sender, EventArgs e)
        {
            Lapiz.FormatoManejoArchivos = "Json";
            if (dgvElementosCartuchera.Rows.Count > 0 && dgvElementosCartuchera.Rows[0].Cells[0].Value is not null)
            {
                Lapiz lapiz = new Lapiz((float)Convert.ToDouble(this.dgvElementosCartuchera.CurrentRow.Cells[1].Value), (EMarca)this.dgvElementosCartuchera.CurrentRow.Cells[2].Value,
                    this.dgvElementosCartuchera.CurrentRow.Cells[3].Value.ToString());
                lapiz.GuardarDatos(lapiz);
            }

        }
        private void btnExpotarLapiz_Click(object sender, EventArgs e)
        {
            Lapiz.FormatoManejoArchivos = "Xml";
            if (dgvElementosCartuchera.Rows.Count > 0 && dgvElementosCartuchera.Rows[0].Cells[0].Value is not null)
            {
                Lapiz lapiz = new Lapiz((float)Convert.ToDouble(this.dgvElementosCartuchera.CurrentRow.Cells[1].Value), (EMarca)this.dgvElementosCartuchera.CurrentRow.Cells[2].Value,
                    this.dgvElementosCartuchera.CurrentRow.Cells[3].Value.ToString());
                lapiz.GuardarDatos(lapiz);
            }

        }

        private void btnLeerJson_Click(object sender, EventArgs e)
        {
            Lapiz.FormatoManejoArchivos = "Json";
            Lapiz lapiz = new Lapiz(0, EMarca.UtilGenerico, "");
            lapiz = lapiz.LeerDatos();

            MessageBox.Show(lapiz.MostrarDatos());


        }
        private void btnLeerXml_Click(object sender, EventArgs e)
        {
            Lapiz.FormatoManejoArchivos = "Xml";
            Lapiz lapiz = new Lapiz(0, EMarca.UtilGenerico, "");
            lapiz = lapiz.LeerDatos();
            MessageBox.Show(lapiz.MostrarDatos());

        }
        int m, mx, my;
        private void FrmManenoCartuchera_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            Utiles l;
            if (this.dgvElementosCartuchera.Rows.Count > 0 && dgvElementosCartuchera.CurrentRow.Cells[0].Value is not null)
            {
                string nombre = this.dgvElementosCartuchera.CurrentRow.Cells[0].Value.ToString();
                float precio = float.Parse(this.dgvElementosCartuchera.CurrentRow.Cells[1].Value.ToString());
                EMarca marca = (EMarca)this.dgvElementosCartuchera.CurrentRow.Cells[2].Value;
                string caracteristica = this.dgvElementosCartuchera.CurrentRow.Cells[3].Value.ToString();

                Utiles g = new Goma(precio, marca, caracteristica);
                Utiles s = new Sacapunta(precio, marca, caracteristica);
                if(this.dgvElementosCartuchera.CurrentRow.Cells[0].Value.ToString() == "LAPIZ")
                {
                    l = new Lapiz(precio, marca, caracteristica);
                    Mochila.Cartucheras[0] -= l;  
                }
                else if(this.dgvElementosCartuchera.CurrentRow.Cells[0].Value.ToString() == "GOMA")
                {
                    l = new Goma(precio, marca, caracteristica);
                    Mochila.Cartucheras[0] -= l;
                }
                else if (this.dgvElementosCartuchera.CurrentRow.Cells[0].Value.ToString() == "SACAPUNTAS")
                {
                    l = new Sacapunta(precio, marca, caracteristica);
                    Mochila.Cartucheras[0] -= l;
                }
                dgvElementosCartuchera.DataSource = null;
                dgvElementosCartuchera.DataSource = Mochila.Cartucheras[0].Elementos;



            }
    
     }



        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//13 es el ASCII para la tecla Enter
            {
                //le informo que el evento (hacer sonido por no poder dar un salto de linea en un textBox)
                //ya fue manejado para que no lo reproduzca.
                e.Handled = true;
                btnAgregar.PerformClick();
            }
        }

        private void btnCargarDesdeDB_Click(object sender, EventArgs e)
        {
            Cartuchera<Utiles> cartucheraAux = new Cartuchera<Utiles>(10);
            cartucheraAux = ConexionDB.TraeDatosDeUnaCartucheraDesdeDB();
            this.dgvElementosCartuchera.DataSource = cartucheraAux.Elementos;
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            foreach (Utiles item in Mochila.Cartucheras[0].Elementos)
            {
                ConexionDB.AgregaElementoEnDB(item);
            }
        }

        private void FrmManenoCartuchera_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void FrmManenoCartuchera_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }
    }
}
