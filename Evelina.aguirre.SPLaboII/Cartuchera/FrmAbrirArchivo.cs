using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace útiles
{
    public partial class FrmAbrirArchivo : Form
    {
        public FrmAbrirArchivo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Busca el archivo...";
            openFileDialog1.ShowDialog();
                string txt = openFileDialog1.FileName;
            if (File.Exists(openFileDialog1.FileName))
            {
                StreamReader leer = new StreamReader(txt);
                this.textBox1.Text = leer.ReadToEnd();
                leer.Close();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
