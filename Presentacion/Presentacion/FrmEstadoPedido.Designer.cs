namespace Presentacion
{
    partial class FrmEstadoPedido
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
            this.components = new System.ComponentModel.Container();
            this.pbcarga = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtidentificacion = new System.Windows.Forms.TextBox();
            this.dgvestado = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnatras = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btndecamino = new System.Windows.Forms.Button();
            this.btnentregado = new System.Windows.Forms.Button();
            this.btnenrestaurante = new System.Windows.Forms.Button();
            this.pbcarga2 = new System.Windows.Forms.ProgressBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.pbcarga3 = new System.Windows.Forms.ProgressBar();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvestado)).BeginInit();
            this.SuspendLayout();
            // 
            // pbcarga
            // 
            this.pbcarga.Location = new System.Drawing.Point(96, 303);
            this.pbcarga.Name = "pbcarga";
            this.pbcarga.Size = new System.Drawing.Size(201, 32);
            this.pbcarga.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Estado del Pedido";
            // 
            // txtidentificacion
            // 
            this.txtidentificacion.Location = new System.Drawing.Point(314, 207);
            this.txtidentificacion.Name = "txtidentificacion";
            this.txtidentificacion.Size = new System.Drawing.Size(217, 20);
            this.txtidentificacion.TabIndex = 3;
            // 
            // dgvestado
            // 
            this.dgvestado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvestado.Location = new System.Drawing.Point(12, 12);
            this.dgvestado.Name = "dgvestado";
            this.dgvestado.Size = new System.Drawing.Size(417, 168);
            this.dgvestado.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese el número de cédula del cliente:";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(435, 12);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(96, 36);
            this.btnbuscar.TabIndex = 10;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnatras
            // 
            this.btnatras.Location = new System.Drawing.Point(435, 93);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(96, 35);
            this.btnatras.TabIndex = 11;
            this.btnatras.Text = "Atras";
            this.btnatras.UseVisualStyleBackColor = true;
            this.btnatras.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btndecamino
            // 
            this.btndecamino.Location = new System.Drawing.Point(246, 373);
            this.btndecamino.Name = "btndecamino";
            this.btndecamino.Size = new System.Drawing.Size(96, 36);
            this.btndecamino.TabIndex = 12;
            this.btndecamino.Text = "De Camino";
            this.btndecamino.UseVisualStyleBackColor = true;
            this.btndecamino.Click += new System.EventHandler(this.btndecamino_Click);
            // 
            // btnentregado
            // 
            this.btnentregado.Location = new System.Drawing.Point(435, 373);
            this.btnentregado.Name = "btnentregado";
            this.btnentregado.Size = new System.Drawing.Size(96, 36);
            this.btnentregado.TabIndex = 13;
            this.btnentregado.Text = "Entregado";
            this.btnentregado.UseVisualStyleBackColor = true;
            this.btnentregado.Click += new System.EventHandler(this.btnentregado_Click);
            // 
            // btnenrestaurante
            // 
            this.btnenrestaurante.Location = new System.Drawing.Point(32, 374);
            this.btnenrestaurante.Name = "btnenrestaurante";
            this.btnenrestaurante.Size = new System.Drawing.Size(96, 36);
            this.btnenrestaurante.TabIndex = 14;
            this.btnenrestaurante.Text = "Inicio";
            this.btnenrestaurante.UseVisualStyleBackColor = true;
            this.btnenrestaurante.Click += new System.EventHandler(this.btnenrestaurante_Click);
            // 
            // pbcarga2
            // 
            this.pbcarga2.Location = new System.Drawing.Point(296, 303);
            this.pbcarga2.Name = "pbcarga2";
            this.pbcarga2.Size = new System.Drawing.Size(188, 32);
            this.pbcarga2.TabIndex = 15;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // cboestado
            // 
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Items.AddRange(new object[] {
            "Iniciando",
            "De Camino",
            "Entregado"});
            this.cboestado.Location = new System.Drawing.Point(314, 233);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(217, 21);
            this.cboestado.TabIndex = 16;
            // 
            // pbcarga3
            // 
            this.pbcarga3.Location = new System.Drawing.Point(70, 303);
            this.pbcarga3.Name = "pbcarga3";
            this.pbcarga3.Size = new System.Drawing.Size(28, 32);
            this.pbcarga3.TabIndex = 17;
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // FrmEstadoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 426);
            this.Controls.Add(this.pbcarga3);
            this.Controls.Add(this.cboestado);
            this.Controls.Add(this.pbcarga2);
            this.Controls.Add(this.btnenrestaurante);
            this.Controls.Add(this.btnentregado);
            this.Controls.Add(this.btndecamino);
            this.Controls.Add(this.btnatras);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvestado);
            this.Controls.Add(this.txtidentificacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbcarga);
            this.Name = "FrmEstadoPedido";
            this.Text = "Estado del Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.dgvestado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbcarga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtidentificacion;
        private System.Windows.Forms.DataGridView dgvestado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnatras;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btndecamino;
        private System.Windows.Forms.Button btnentregado;
        private System.Windows.Forms.Button btnenrestaurante;
        private System.Windows.Forms.ProgressBar pbcarga2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.ProgressBar pbcarga3;
        private System.Windows.Forms.Timer timer3;
    }
}