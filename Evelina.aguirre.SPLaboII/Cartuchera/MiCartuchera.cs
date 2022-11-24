using Entidades;
using Entidades.Archivos;
using Entidades.DB;
using Entidades.ExcepcionesPropias;
using System;
using System.IO;
using System.Windows.Forms;
using útiles;

namespace FrmCartuchera
{
    public partial class FrmManenoCartuchera : Form
    {
     public static int indexListaDeCartucherasEnMochila = 0;
        public FrmManenoCartuchera()
        {
            InitializeComponent();
        }

            Cartuchera<Utiles> cartucheraDB = new Cartuchera<Utiles>("Cartuchera1",10);
        private void Form1_Load(object sender, EventArgs e)
        {
            Mochila.Cartucheras[0].EventoPrecio += Txt.GuardarDatos;

            //cartucheraDB = ConexionDB.TraeDatosDeUnaCartucheraDesdeDB();
            //Mochila.Cartucheras.Add(cartucheraDB);

            dgvElementosCartuchera.DataSource = Mochila.Cartucheras[indexListaDeCartucherasEnMochila].Elementos;
            cmbMarca.DataSource = System.Enum.GetValues(typeof(EMarca));
            grpCaracteristicas.Text = " Elemento ";
            lblParticular.Text = "Color";
            lblCantidad.Text = "Cantidad actual: " + Mochila.Cartucheras[indexListaDeCartucherasEnMochila].Elementos.Count.ToString()
                + "  MÁX.: "+ Mochila.Cartucheras[indexListaDeCartucherasEnMochila].CantidadMaxima.ToString();
            cmbParticular.Enabled = false;
            this.txtPrecio.Enabled = false;
        }

        private void btnLapiz_Click(object sender, EventArgs e)
        {
            cmbParticular.Enabled = true;
            this.txtPrecio.Enabled = true;
            cmbParticular.DataSource = System.Enum.GetValues(typeof(EColor));
            grpCaracteristicas.Text = " Lapiz ";
            lblParticular.Text = "Color";
        }

        private void btnGoma_Click(object sender, EventArgs e)
        {
            cmbParticular.Enabled = true;
            this.txtPrecio.Enabled = true;
            grpCaracteristicas.Text = " Goma ";
            lblParticular.Text = "Para";
            cmbParticular.DataSource = System.Enum.GetValues(typeof(EPara));
        }

        private void btnSacapuntas_Click(object sender, EventArgs e)
        {
            cmbParticular.Enabled = true;
            this.txtPrecio.Enabled = true;
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
                if (txtPrecio.Text != null && esNumero && precio >0)
                {
                    //Se instancia un lapiz/goma/sacapunta según corresponda
                    Utiles util = null;
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

                    //agrega el nuevo elemento a al dgv
                    dgvElementosCartuchera.DataSource = null;
                    dgvElementosCartuchera.DataSource = Mochila.Cartucheras[0].Elementos;
                    lblCantidad.Text = "Cantidad actual: " + Mochila.Cartucheras[0].Elementos.Count.ToString() + "  MÁX.: " + Mochila.Cartucheras[0].CantidadMaxima.ToString();
                }
                else if (txtPrecio.Text == null || !esNumero)
                {
                    if (this.cmbParticular.SelectedItem is null)
                    {
                        throw new CamposVaciosException("Faltan completar campos");
                    }
                    else
                    {
                        throw new MontoInvalidoException("Debe ingresar un valor numérico");
                    }
                }
            }
            catch (MontoInvalidoException ex)
            {
                lblEError.Text = ex.Message;
                timer1.Interval = 3000;
                timer1.Start();
            }
            catch (CamposVaciosException ex)
            {
                lblEError.Text = ex.Message;
                timer1.Interval = 3000;
                timer1.Start();
            }
            catch (Exception ex)
            {
                lblEError.Text = ex.Message;
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
                Lapiz lapiz = new Lapiz((float)Convert.ToDouble(dgvElementosCartuchera.CurrentRow.Cells[1].Value), (EMarca)dgvElementosCartuchera.CurrentRow.Cells[2].Value,
                    dgvElementosCartuchera.CurrentRow.Cells[3].Value.ToString());
                lapiz.GuardarDatos(lapiz);
                MessageBox.Show("Se serializó el lapiz seleccionado");
            }

        }
        private void btnExpotarLapiz_Click(object sender, EventArgs e)
        {
            Lapiz.FormatoManejoArchivos = "Xml";
            if (dgvElementosCartuchera.Rows.Count > 0 && dgvElementosCartuchera.Rows[0].Cells[0].Value is not null)
            {
                Lapiz lapiz = new Lapiz((float)Convert.ToDouble(dgvElementosCartuchera.CurrentRow.Cells[1].Value), (EMarca)dgvElementosCartuchera.CurrentRow.Cells[2].Value,
                    dgvElementosCartuchera.CurrentRow.Cells[3].Value.ToString());
                lapiz.GuardarDatos(lapiz);
                MessageBox.Show("Se serializó el lapíz seleccionado");
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
            if (dgvElementosCartuchera.Rows.Count > 0 && dgvElementosCartuchera.CurrentRow.Cells[0].Value is not null)
            {
                string nombre = dgvElementosCartuchera.CurrentRow.Cells[0].Value.ToString();
                float precio = float.Parse(dgvElementosCartuchera.CurrentRow.Cells[1].Value.ToString());
                EMarca marca = (EMarca)dgvElementosCartuchera.CurrentRow.Cells[2].Value;
                string caracteristica = dgvElementosCartuchera.CurrentRow.Cells[3].Value.ToString();

                if (dgvElementosCartuchera.CurrentRow.Cells[0].Value.ToString() == "LAPIZ")
                {
                    l = new Lapiz(precio, marca, caracteristica);
                    Mochila.Cartucheras[0] -= l;
                }
                else if (dgvElementosCartuchera.CurrentRow.Cells[0].Value.ToString() == "GOMA")
                {
                    l = new Goma(precio, marca, caracteristica);
                    Mochila.Cartucheras[0] -= l;
                }
                else if (dgvElementosCartuchera.CurrentRow.Cells[0].Value.ToString() == "SACAPUNTAS")
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
            Cartuchera<Utiles> cartucheraAux = new Cartuchera<Utiles>("cartucheraAux",10);
            cartucheraAux = ConexionDB.TraeDatosDeUnaCartucheraDesdeDB();
            //Mochila.Cartucheras.RemoveAt(0);
            Mochila.Cartucheras.Add(cartucheraAux);
            dgvElementosCartuchera.DataSource = cartucheraAux.Elementos;
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            ConexionDB.borraElementosActualesEnUnaCartucheraEnDB();
            if (Mochila.Cartucheras[0].Elementos.Count <= Mochila.Cartucheras[0].CantidadMaxima)
            {
                foreach (Utiles item in Mochila.Cartucheras[0].Elementos)
                {
                    ConexionDB.AgregaElementoEnDB(item);
                }

            }
        }

        private void btnModifiar_Click(object sender, EventArgs e)
        {
            Utiles util = null;
            if (dgvElementosCartuchera.Rows.Count > 0 && dgvElementosCartuchera.CurrentRow.Cells[0].Value is not null)
            {
                string nombre = dgvElementosCartuchera.CurrentRow.Cells[0].Value.ToString();
                float precio = float.Parse(dgvElementosCartuchera.CurrentRow.Cells[1].Value.ToString());
                EMarca marca = (EMarca)dgvElementosCartuchera.CurrentRow.Cells[2].Value;
                string caracteristica = dgvElementosCartuchera.CurrentRow.Cells[3].Value.ToString();

                if (dgvElementosCartuchera.CurrentRow.Cells[0].Value.ToString() == "LAPIZ")
                {
                    util = new Lapiz(precio, marca, caracteristica);

                }
                else if (dgvElementosCartuchera.CurrentRow.Cells[0].Value.ToString() == "GOMA")
                {
                    util = new Goma(precio, marca, caracteristica);

                }
                else if (dgvElementosCartuchera.CurrentRow.Cells[0].Value.ToString() == "SACAPUNTAS")
                {
                    util = new Sacapunta(precio, marca, caracteristica);

                }
                FrmModificar frmModificar = new FrmModificar(util, this);
                frmModificar.ShowDialog();


            }
                dgvElementosCartuchera.DataSource = null;
                dgvElementosCartuchera.DataSource = Mochila.Cartucheras[indexListaDeCartucherasEnMochila].Elementos;
        }

        private void FrmManenoCartuchera_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAbrirArchivo frmleerArchivo = new FrmAbrirArchivo();
            frmleerArchivo.ShowDialog();
           
        }

        private void FrmManenoCartuchera_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        public void ActualizadDgvElementosCartuchera(int index)
        {
            this.dgvElementosCartuchera.DataSource = Mochila.Cartucheras[indexListaDeCartucherasEnMochila].Elementos;
        }
        
    }
}
