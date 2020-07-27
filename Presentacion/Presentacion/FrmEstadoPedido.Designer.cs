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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnescoger = new System.Windows.Forms.Button();
            this.btnatras = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btndecamino = new System.Windows.Forms.Button();
            this.btnentregado = new System.Windows.Forms.Button();
            this.btnenrestaurante = new System.Windows.Forms.Button();
            this.pbcarga2 = new System.Windows.Forms.ProgressBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbcarga
            // 
            this.pbcarga.Location = new System.Drawing.Point(74, 256);
            this.pbcarga.Name = "pbcarga";
            this.pbcarga.Size = new System.Drawing.Size(211, 32);
            this.pbcarga.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Estado del Pedido";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(492, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 20);
            this.textBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(417, 168);
            this.dataGridView1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(448, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese el número de cédula del cliente:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(492, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(217, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(492, 125);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(217, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(492, 99);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(217, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(492, 73);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(217, 20);
            this.textBox5.TabIndex = 9;
            // 
            // btnescoger
            // 
            this.btnescoger.Location = new System.Drawing.Point(492, 186);
            this.btnescoger.Name = "btnescoger";
            this.btnescoger.Size = new System.Drawing.Size(96, 36);
            this.btnescoger.TabIndex = 10;
            this.btnescoger.Text = "Escoger";
            this.btnescoger.UseVisualStyleBackColor = true;
            // 
            // btnatras
            // 
            this.btnatras.Location = new System.Drawing.Point(621, 327);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(88, 35);
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
            this.btndecamino.Location = new System.Drawing.Point(242, 326);
            this.btndecamino.Name = "btndecamino";
            this.btndecamino.Size = new System.Drawing.Size(96, 36);
            this.btndecamino.TabIndex = 12;
            this.btndecamino.Text = "De Camino";
            this.btndecamino.UseVisualStyleBackColor = true;
            this.btndecamino.Click += new System.EventHandler(this.btndecamino_Click);
            // 
            // btnentregado
            // 
            this.btnentregado.Location = new System.Drawing.Point(466, 326);
            this.btnentregado.Name = "btnentregado";
            this.btnentregado.Size = new System.Drawing.Size(96, 36);
            this.btnentregado.TabIndex = 13;
            this.btnentregado.Text = "Entregado";
            this.btnentregado.UseVisualStyleBackColor = true;
            this.btnentregado.Click += new System.EventHandler(this.btnentregado_Click);
            // 
            // btnenrestaurante
            // 
            this.btnenrestaurante.Location = new System.Drawing.Point(32, 327);
            this.btnenrestaurante.Name = "btnenrestaurante";
            this.btnenrestaurante.Size = new System.Drawing.Size(96, 36);
            this.btnenrestaurante.TabIndex = 14;
            this.btnenrestaurante.Text = "Inicio";
            this.btnenrestaurante.UseVisualStyleBackColor = true;
            this.btnenrestaurante.Click += new System.EventHandler(this.btnenrestaurante_Click);
            // 
            // pbcarga2
            // 
            this.pbcarga2.Location = new System.Drawing.Point(282, 256);
            this.pbcarga2.Name = "pbcarga2";
            this.pbcarga2.Size = new System.Drawing.Size(230, 32);
            this.pbcarga2.TabIndex = 15;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FrmEstadoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 392);
            this.Controls.Add(this.pbcarga2);
            this.Controls.Add(this.btnenrestaurante);
            this.Controls.Add(this.btnentregado);
            this.Controls.Add(this.btndecamino);
            this.Controls.Add(this.btnatras);
            this.Controls.Add(this.btnescoger);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbcarga);
            this.Name = "FrmEstadoPedido";
            this.Text = "Estado del Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbcarga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnescoger;
        private System.Windows.Forms.Button btnatras;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btndecamino;
        private System.Windows.Forms.Button btnentregado;
        private System.Windows.Forms.Button btnenrestaurante;
        private System.Windows.Forms.ProgressBar pbcarga2;
        private System.Windows.Forms.Timer timer2;
    }
}