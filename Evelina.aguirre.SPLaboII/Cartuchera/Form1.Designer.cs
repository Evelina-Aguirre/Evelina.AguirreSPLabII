
namespace FrmCartuchera
{
    partial class FrmManenoCartuchera
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnLapiz = new System.Windows.Forms.Button();
            this.dgvElementosCartuchera = new System.Windows.Forms.DataGridView();
            this.btnGoma = new System.Windows.Forms.Button();
            this.btnSacapuntas = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExportarJson = new System.Windows.Forms.Button();
            this.btnExpotarLapiz = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblParticular = new System.Windows.Forms.Label();
            this.cmbParticular = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grpCaracteristicas = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblEError = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvElementosCartuchera)).BeginInit();
            this.grpCaracteristicas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLapiz
            // 
            this.btnLapiz.Location = new System.Drawing.Point(395, 32);
            this.btnLapiz.Name = "btnLapiz";
            this.btnLapiz.Size = new System.Drawing.Size(93, 46);
            this.btnLapiz.TabIndex = 0;
            this.btnLapiz.Text = "Lapiz";
            this.btnLapiz.UseVisualStyleBackColor = true;
            this.btnLapiz.Click += new System.EventHandler(this.btnLapiz_Click);
            // 
            // dgvElementosCartuchera
            // 
            this.dgvElementosCartuchera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElementosCartuchera.Location = new System.Drawing.Point(21, 32);
            this.dgvElementosCartuchera.Name = "dgvElementosCartuchera";
            this.dgvElementosCartuchera.RowTemplate.Height = 25;
            this.dgvElementosCartuchera.Size = new System.Drawing.Size(347, 202);
            this.dgvElementosCartuchera.TabIndex = 1;
            // 
            // btnGoma
            // 
            this.btnGoma.Location = new System.Drawing.Point(395, 84);
            this.btnGoma.Name = "btnGoma";
            this.btnGoma.Size = new System.Drawing.Size(93, 46);
            this.btnGoma.TabIndex = 2;
            this.btnGoma.Text = "Goma";
            this.btnGoma.UseVisualStyleBackColor = true;
            this.btnGoma.Click += new System.EventHandler(this.btnGoma_Click);
            // 
            // btnSacapuntas
            // 
            this.btnSacapuntas.Location = new System.Drawing.Point(395, 136);
            this.btnSacapuntas.Name = "btnSacapuntas";
            this.btnSacapuntas.Size = new System.Drawing.Size(93, 46);
            this.btnSacapuntas.TabIndex = 3;
            this.btnSacapuntas.Text = "Sacapuntas";
            this.btnSacapuntas.UseVisualStyleBackColor = true;
            this.btnSacapuntas.Click += new System.EventHandler(this.btnSacapuntas_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(395, 188);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(93, 46);
            this.btnQuitar.TabIndex = 4;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Agregar";
            // 
            // btnExportarJson
            // 
            this.btnExportarJson.Location = new System.Drawing.Point(21, 239);
            this.btnExportarJson.Name = "btnExportarJson";
            this.btnExportarJson.Size = new System.Drawing.Size(91, 45);
            this.btnExportarJson.TabIndex = 7;
            this.btnExportarJson.Text = "Exportar Lapiz JSon";
            this.btnExportarJson.UseVisualStyleBackColor = true;
            // 
            // btnExpotarLapiz
            // 
            this.btnExpotarLapiz.Location = new System.Drawing.Point(122, 239);
            this.btnExpotarLapiz.Name = "btnExpotarLapiz";
            this.btnExpotarLapiz.Size = new System.Drawing.Size(89, 45);
            this.btnExpotarLapiz.TabIndex = 8;
            this.btnExpotarLapiz.Text = "Exportar Lapiz Xml";
            this.btnExpotarLapiz.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Elementos en la cartuchera";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(569, 247);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(204, 27);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(605, 69);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(145, 23);
            this.cmbMarca.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(521, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Marca";
            // 
            // lblParticular
            // 
            this.lblParticular.AutoSize = true;
            this.lblParticular.Location = new System.Drawing.Point(19, 104);
            this.lblParticular.Name = "lblParticular";
            this.lblParticular.Size = new System.Drawing.Size(36, 15);
            this.lblParticular.TabIndex = 18;
            this.lblParticular.Text = "Color";
            // 
            // cmbParticular
            // 
            this.cmbParticular.FormattingEnabled = true;
            this.cmbParticular.Location = new System.Drawing.Point(99, 101);
            this.cmbParticular.Name = "cmbParticular";
            this.cmbParticular.Size = new System.Drawing.Size(145, 23);
            this.cmbParticular.TabIndex = 17;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(99, 68);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(145, 23);
            this.txtPrecio.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Precio";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(19, 147);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(225, 40);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button7_Click);
            // 
            // grpCaracteristicas
            // 
            this.grpCaracteristicas.Controls.Add(this.lblEError);
            this.grpCaracteristicas.Controls.Add(this.lblParticular);
            this.grpCaracteristicas.Controls.Add(this.cmbParticular);
            this.grpCaracteristicas.Controls.Add(this.label6);
            this.grpCaracteristicas.Controls.Add(this.txtPrecio);
            this.grpCaracteristicas.Controls.Add(this.btnAgregar);
            this.grpCaracteristicas.Location = new System.Drawing.Point(506, 32);
            this.grpCaracteristicas.Name = "grpCaracteristicas";
            this.grpCaracteristicas.Size = new System.Drawing.Size(267, 202);
            this.grpCaracteristicas.TabIndex = 22;
            this.grpCaracteristicas.TabStop = false;
            this.grpCaracteristicas.Text = "Lapiz";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 45);
            this.button1.TabIndex = 24;
            this.button1.Text = "Exportar Lapiz Xml";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 45);
            this.button2.TabIndex = 23;
            this.button2.Text = "Exportar Lapiz JSon";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblEError
            // 
            this.lblEError.AutoSize = true;
            this.lblEError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblEError.Location = new System.Drawing.Point(144, 129);
            this.lblEError.Name = "lblEError";
            this.lblEError.Size = new System.Drawing.Size(91, 15);
            this.lblEError.TabIndex = 22;
            this.lblEError.Text = "                            ";
            this.lblEError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmManenoCartuchera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 288);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExpotarLapiz);
            this.Controls.Add(this.btnExportarJson);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnSacapuntas);
            this.Controls.Add(this.btnGoma);
            this.Controls.Add(this.dgvElementosCartuchera);
            this.Controls.Add(this.btnLapiz);
            this.Controls.Add(this.grpCaracteristicas);
            this.Name = "FrmManenoCartuchera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mis útiles";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvElementosCartuchera)).EndInit();
            this.grpCaracteristicas.ResumeLayout(false);
            this.grpCaracteristicas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLapiz;
        private System.Windows.Forms.DataGridView dgvElementosCartuchera;
        private System.Windows.Forms.Button btnGoma;
        private System.Windows.Forms.Button btnSacapuntas;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExportarJson;
        private System.Windows.Forms.Button btnExpotarLapiz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblParticular;
        private System.Windows.Forms.ComboBox cmbParticular;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox grpCaracteristicas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblEError;
        private System.Windows.Forms.Timer timer1;
    }
}
