
namespace útiles
{
    partial class FrmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNuevaCartuchera = new System.Windows.Forms.Button();
            this.btnCartuchera = new System.Windows.Forms.Button();
            this.dgvCartucheras = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarCartuchera = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartucheras)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevaCartuchera
            // 
            this.btnNuevaCartuchera.Location = new System.Drawing.Point(26, 35);
            this.btnNuevaCartuchera.Name = "btnNuevaCartuchera";
            this.btnNuevaCartuchera.Size = new System.Drawing.Size(143, 38);
            this.btnNuevaCartuchera.TabIndex = 0;
            this.btnNuevaCartuchera.Text = "Nuevo";
            this.btnNuevaCartuchera.UseVisualStyleBackColor = true;
            this.btnNuevaCartuchera.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCartuchera
            // 
            this.btnCartuchera.Location = new System.Drawing.Point(26, 79);
            this.btnCartuchera.Name = "btnCartuchera";
            this.btnCartuchera.Size = new System.Drawing.Size(143, 36);
            this.btnCartuchera.TabIndex = 1;
            this.btnCartuchera.Text = "Ver";
            this.btnCartuchera.UseVisualStyleBackColor = true;
            // 
            // dgvCartucheras
            // 
            this.dgvCartucheras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCartucheras.Location = new System.Drawing.Point(189, 35);
            this.dgvCartucheras.Name = "dgvCartucheras";
            this.dgvCartucheras.RowTemplate.Height = 25;
            this.dgvCartucheras.Size = new System.Drawing.Size(372, 126);
            this.dgvCartucheras.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mi cartucheras";
            // 
            // btnEliminarCartuchera
            // 
            this.btnEliminarCartuchera.Location = new System.Drawing.Point(26, 121);
            this.btnEliminarCartuchera.Name = "btnEliminarCartuchera";
            this.btnEliminarCartuchera.Size = new System.Drawing.Size(143, 36);
            this.btnEliminarCartuchera.TabIndex = 15;
            this.btnEliminarCartuchera.Text = "Eliminar";
            this.btnEliminarCartuchera.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 25);
            this.button1.TabIndex = 16;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 214);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEliminarCartuchera);
            this.Controls.Add(this.dgvCartucheras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCartuchera);
            this.Controls.Add(this.btnNuevaCartuchera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInicio";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartucheras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevaCartuchera;
        private System.Windows.Forms.Button btnCartuchera;
        private System.Windows.Forms.DataGridView dgvCartucheras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarCartuchera;
        private System.Windows.Forms.Button button1;
    }
}