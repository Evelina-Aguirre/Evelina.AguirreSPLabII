
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnLeerXml = new System.Windows.Forms.Button();
            this.btnLeerJson = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnCargarDesdeDB = new System.Windows.Forms.Button();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnModifiar = new System.Windows.Forms.Button();
            this.lblActualizar = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(104)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(104)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvElementosCartuchera.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvElementosCartuchera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(157)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(102)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvElementosCartuchera.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvElementosCartuchera.EnableHeadersVisualStyles = false;
            this.dgvElementosCartuchera.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(205)))), ((int)(((byte)(235)))));
            this.dgvElementosCartuchera.Location = new System.Drawing.Point(21, 32);
            this.dgvElementosCartuchera.Name = "dgvElementosCartuchera";
            this.dgvElementosCartuchera.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(170)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(129)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvElementosCartuchera.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            this.btnQuitar.Location = new System.Drawing.Point(431, 243);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(93, 46);
            this.btnQuitar.TabIndex = 4;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
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
            this.btnExportarJson.Size = new System.Drawing.Size(87, 50);
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
            this.btnExpotarLapiz.Location = new System.Drawing.Point(126, 239);
            this.btnExpotarLapiz.Name = "btnExpotarLapiz";
            this.btnExpotarLapiz.Size = new System.Drawing.Size(85, 50);
            this.btnExpotarLapiz.TabIndex = 8;
            this.btnExpotarLapiz.Text = "Exportar Lapiz Xml";
            this.btnExpotarLapiz.UseVisualStyleBackColor = false;
            this.btnExpotarLapiz.Click += new System.EventHandler(this.btnExpotarLapiz_Click);
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
            this.btnSalir.Location = new System.Drawing.Point(693, 310);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(116, 27);
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
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
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
            this.lblEError.ForeColor = System.Drawing.Color.Red;
            this.lblEError.Location = new System.Drawing.Point(19, 129);
            this.lblEError.Name = "lblEError";
            this.lblEError.Size = new System.Drawing.Size(91, 15);
            this.lblEError.TabIndex = 22;
            this.lblEError.Text = "                            ";
            this.lblEError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLeerXml
            // 
            this.btnLeerXml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(157)))), ((int)(((byte)(216)))));
            this.btnLeerXml.FlatAppearance.BorderSize = 0;
            this.btnLeerXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeerXml.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLeerXml.Location = new System.Drawing.Point(331, 240);
            this.btnLeerXml.Name = "btnLeerXml";
            this.btnLeerXml.Size = new System.Drawing.Size(84, 49);
            this.btnLeerXml.TabIndex = 24;
            this.btnLeerXml.Text = "Leer Lapiz Xml";
            this.btnLeerXml.UseVisualStyleBackColor = false;
            this.btnLeerXml.Click += new System.EventHandler(this.btnLeerXml_Click);
            // 
            // btnLeerJson
            // 
            this.btnLeerJson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(157)))), ((int)(((byte)(216)))));
            this.btnLeerJson.FlatAppearance.BorderSize = 0;
            this.btnLeerJson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeerJson.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLeerJson.Location = new System.Drawing.Point(231, 239);
            this.btnLeerJson.Name = "btnLeerJson";
            this.btnLeerJson.Size = new System.Drawing.Size(79, 50);
            this.btnLeerJson.TabIndex = 23;
            this.btnLeerJson.Text = "Leer Lapiz JSon";
            this.btnLeerJson.UseVisualStyleBackColor = false;
            this.btnLeerJson.Click += new System.EventHandler(this.btnLeerJson_Click);
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
            // btnCargarDesdeDB
            // 
            this.btnCargarDesdeDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(157)))), ((int)(((byte)(216)))));
            this.btnCargarDesdeDB.FlatAppearance.BorderSize = 0;
            this.btnCargarDesdeDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarDesdeDB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCargarDesdeDB.Location = new System.Drawing.Point(21, 305);
            this.btnCargarDesdeDB.Name = "btnCargarDesdeDB";
            this.btnCargarDesdeDB.Size = new System.Drawing.Size(190, 27);
            this.btnCargarDesdeDB.TabIndex = 26;
            this.btnCargarDesdeDB.Text = "Cargar desde DB";
            this.btnCargarDesdeDB.UseVisualStyleBackColor = false;
            this.btnCargarDesdeDB.Click += new System.EventHandler(this.btnCargarDesdeDB_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(157)))), ((int)(((byte)(216)))));
            this.btnGuardarCambios.FlatAppearance.BorderSize = 0;
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarCambios.Location = new System.Drawing.Point(231, 305);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(184, 27);
            this.btnGuardarCambios.TabIndex = 27;
            this.btnGuardarCambios.Text = "Guardar cambios en DB";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCantidad.Location = new System.Drawing.Point(250, 14);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(107, 15);
            this.lblCantidad.TabIndex = 28;
            this.lblCantidad.Text = "Cantidad Actual : 3";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnModifiar
            // 
            this.btnModifiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(157)))), ((int)(((byte)(216)))));
            this.btnModifiar.FlatAppearance.BorderSize = 0;
            this.btnModifiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModifiar.Location = new System.Drawing.Point(431, 188);
            this.btnModifiar.Name = "btnModifiar";
            this.btnModifiar.Size = new System.Drawing.Size(93, 46);
            this.btnModifiar.TabIndex = 29;
            this.btnModifiar.Text = "Modificar";
            this.btnModifiar.UseVisualStyleBackColor = false;
            this.btnModifiar.Click += new System.EventHandler(this.btnModifiar_Click);
            // 
            // lblActualizar
            // 
            this.lblActualizar.AutoSize = true;
            this.lblActualizar.Location = new System.Drawing.Point(441, 310);
            this.lblActualizar.Name = "lblActualizar";
            this.lblActualizar.Size = new System.Drawing.Size(94, 15);
            this.lblActualizar.TabIndex = 30;
            this.lblActualizar.Text = "                             ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(157)))), ((int)(((byte)(216)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(567, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 40);
            this.button1.TabIndex = 23;
            this.button1.Text = "Leer Tickets";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmManenoCartuchera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(835, 356);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblActualizar);
            this.Controls.Add(this.btnModifiar);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.btnCargarDesdeDB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLeerXml);
            this.Controls.Add(this.btnLeerJson);
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
        private System.Windows.Forms.Button btnLeerXml;
        private System.Windows.Forms.Button btnLeerJson;
        private System.Windows.Forms.Label lblEError;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCargarDesdeDB;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnModifiar;
        private System.Windows.Forms.Label lblActualizar;
        public System.Windows.Forms.DataGridView dgvElementosCartuchera;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
