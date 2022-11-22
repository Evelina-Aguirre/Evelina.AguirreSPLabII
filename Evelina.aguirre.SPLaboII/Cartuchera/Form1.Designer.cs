
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.lblEError = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElementosCartuchera)).BeginInit();
            this.grpCaracteristicas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLapiz
            // 
            this.btnLapiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(157)))), ((int)(((byte)(216)))));
            this.btnLapiz.FlatAppearance.BorderSize = 0;
            this.btnLapiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapiz.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLapiz.Location = new System.Drawing.Point(431, 32);
            this.btnLapiz.Name = "btnLapiz";
            this.btnLapiz.Size = new System.Drawing.Size(93, 46);
            this.btnLapiz.TabIndex = 0;
            this.btnLapiz.Text = "Lapiz";
            this.btnLapiz.UseVisualStyleBackColor = false;
            this.btnLapiz.Click += new System.EventHandler(this.btnLapiz_Click);
            // 
            // dgvElementosCartuchera
            // 
            this.dgvElementosCartuchera.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(157)))), ((int)(((byte)(216)))));
            this.dgvElementosCartuchera.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvElementosCartuchera.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvElementosCartuchera.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(104)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(104)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvElementosCartuchera.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvElementosCartuchera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(157)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(102)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvElementosCartuchera.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvElementosCartuchera.EnableHeadersVisualStyles = false;
            this.dgvElementosCartuchera.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(205)))), ((int)(((byte)(235)))));
            this.dgvElementosCartuchera.Location = new System.Drawing.Point(21, 32);
            this.dgvElementosCartuchera.Name = "dgvElementosCartuchera";
            this.dgvElementosCartuchera.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(170)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(129)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvElementosCartuchera.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvElementosCartuchera.RowHeadersVisible = false;
            this.dgvElementosCartuchera.RowTemplate.Height = 25;
            this.dgvElementosCartuchera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvElementosCartuchera.Size = new System.Drawing.Size(394, 200);
            this.dgvElementosCartuchera.TabIndex = 1;
            // 
            // btnGoma
            // 
            this.btnGoma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(157)))), ((int)(((byte)(216)))));
            this.btnGoma.FlatAppearance.BorderSize = 0;
            this.btnGoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoma.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGoma.Location = new System.Drawing.Point(431, 84);
            this.btnGoma.Name = "btnGoma";
            this.btnGoma.Size = new System.Drawing.Size(93, 46);
            this.btnGoma.TabIndex = 2;
            this.btnGoma.Text = "Goma";
            this.btnGoma.UseVisualStyleBackColor = false;
            this.btnGoma.Click += new System.EventHandler(this.btnGoma_Click);
            // 
            // btnSacapuntas
            // 
            this.btnSacapuntas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(157)))), ((int)(((byte)(216)))));
            this.btnSacapuntas.FlatAppearance.BorderSize = 0;
            this.btnSacapuntas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacapuntas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSacapuntas.Location = new System.Drawing.Point(431, 136);
            this.btnSacapuntas.Name = "btnSacapuntas";
            this.btnSacapuntas.Size = new System.Drawing.Size(93, 46);
            this.btnSacapuntas.TabIndex = 3;
            this.btnSacapuntas.Text = "Sacapuntas";
            this.btnSacapuntas.UseVisualStyleBackColor = false;
            this.btnSacapuntas.Click += new System.EventHandler(this.btnSacapuntas_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(157)))), ((int)(((byte)(216)))));
            this.btnQuitar.FlatAppearance.BorderSize = 0;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuitar.Location = new System.Drawing.Point(431, 188);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(93, 46);
            this.btnQuitar.TabIndex = 4;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(431, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Agregar";
            // 
            // btnExportarJson
            // 
            this.btnExportarJson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(157)))), ((int)(((byte)(216)))));
            this.btnExportarJson.FlatAppearance.BorderSize = 0;
            this.btnExportarJson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarJson.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportarJson.Location = new System.Drawing.Point(21, 239);
            this.btnExportarJson.Name = "btnExportarJson";
            this.btnExportarJson.Size = new System.Drawing.Size(91, 55);
            this.btnExportarJson.TabIndex = 7;
            this.btnExportarJson.Text = "Exportar Lapiz JSon";
            this.btnExportarJson.UseVisualStyleBackColor = false;
            this.btnExportarJson.Click += new System.EventHandler(this.btnExportarJson_Click);
            // 
            // btnExpotarLapiz
            // 
            this.btnExpotarLapiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(157)))), ((int)(((byte)(216)))));
            this.btnExpotarLapiz.FlatAppearance.BorderSize = 0;
            this.btnExpotarLapiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpotarLapiz.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExpotarLapiz.Location = new System.Drawing.Point(122, 239);
            this.btnExpotarLapiz.Name = "btnExpotarLapiz";
            this.btnExpotarLapiz.Size = new System.Drawing.Size(89, 55);
            this.btnExpotarLapiz.TabIndex = 8;
            this.btnExpotarLapiz.Text = "Exportar Lapiz Xml";
            this.btnExpotarLapiz.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(20, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Elementos en la cartuchera";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(157)))), ((int)(((byte)(216)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(605, 280);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(204, 27);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(641, 69);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(145, 23);
            this.cmbMarca.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(563, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Marca";
            // 
            // lblParticular
            // 
            this.lblParticular.AutoSize = true;
            this.lblParticular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblParticular.Location = new System.Drawing.Point(25, 105);
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
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(21, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Precio";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(157)))), ((int)(((byte)(216)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Location = new System.Drawing.Point(21, 147);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(225, 40);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
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
            this.grpCaracteristicas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpCaracteristicas.Location = new System.Drawing.Point(542, 30);
            this.grpCaracteristicas.Name = "grpCaracteristicas";
            this.grpCaracteristicas.Size = new System.Drawing.Size(267, 202);
            this.grpCaracteristicas.TabIndex = 22;
            this.grpCaracteristicas.TabStop = false;
            this.grpCaracteristicas.Text = "Lapiz";
            // 
            // lblEError
            // 
            this.lblEError.AutoSize = true;
            this.lblEError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblEError.Location = new System.Drawing.Point(19, 129);
            this.lblEError.Name = "lblEError";
            this.lblEError.Size = new System.Drawing.Size(91, 15);
            this.lblEError.TabIndex = 22;
            this.lblEError.Text = "                            ";
            this.lblEError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(157)))), ((int)(((byte)(216)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(325, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 56);
            this.button1.TabIndex = 24;
            this.button1.Text = "Leer Lapiz Xml";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(157)))), ((int)(((byte)(216)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(221, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 55);
            this.button2.TabIndex = 23;
            this.button2.Text = "Leer Lapiz JSon";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(354, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "                  ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(157)))), ((int)(((byte)(216)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(605, 247);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 27);
            this.button3.TabIndex = 26;
            this.button3.Text = "Guardar todo";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // FrmManenoCartuchera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(137)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(835, 322);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmManenoCartuchera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mis útiles";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmManenoCartuchera_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmManenoCartuchera_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmManenoCartuchera_MouseUp);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}
