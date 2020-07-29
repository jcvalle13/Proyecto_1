namespace Presentacion
{
    partial class FrmConsultaPedido
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
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvpedidos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(132, 65);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(204, 20);
            this.txtcedula.TabIndex = 0;
            //this.txtcedula.TextChanged += new System.EventHandler(this.txtcedula_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cédula:";
            // 
            // dgvpedidos
            // 
            this.dgvpedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpedidos.Location = new System.Drawing.Point(40, 101);
            this.dgvpedidos.Name = "dgvpedidos";
            this.dgvpedidos.Size = new System.Drawing.Size(513, 134);
            this.dgvpedidos.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(687, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese su número de cédula para ver el progreso de su pedido.";
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(578, 101);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(89, 50);
            this.btnsalir.TabIndex = 4;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmConsultaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 275);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvpedidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcedula);
            this.Name = "FrmConsultaPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta del Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.dgvpedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvpedidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsalir;
    }
}