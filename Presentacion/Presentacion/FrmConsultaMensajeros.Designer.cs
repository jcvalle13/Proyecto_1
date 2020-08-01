namespace Presentacion
{
    partial class FrmConsultaMensajeros
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
            this.btnmostrar = new System.Windows.Forms.Button();
            this.dgvmensajeros = new System.Windows.Forms.DataGridView();
            this.btnatras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmensajeros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(529, 12);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(93, 47);
            this.btnmostrar.TabIndex = 8;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // dgvmensajeros
            // 
            this.dgvmensajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmensajeros.Location = new System.Drawing.Point(12, 12);
            this.dgvmensajeros.Name = "dgvmensajeros";
            this.dgvmensajeros.Size = new System.Drawing.Size(478, 198);
            this.dgvmensajeros.TabIndex = 7;
            // 
            // btnatras
            // 
            this.btnatras.Location = new System.Drawing.Point(529, 163);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(93, 47);
            this.btnatras.TabIndex = 6;
            this.btnatras.Text = "Salir";
            this.btnatras.UseVisualStyleBackColor = true;
            this.btnatras.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // FrmConsultaMensajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 258);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.dgvmensajeros);
            this.Controls.Add(this.btnatras);
            this.Name = "FrmConsultaMensajeros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de la Línea de Mensajeros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvmensajeros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.DataGridView dgvmensajeros;
        private System.Windows.Forms.Button btnatras;
    }
}