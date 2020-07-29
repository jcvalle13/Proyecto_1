namespace Presentacion
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mensajeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoHistóricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDePaquetesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoCantidadDePaquetesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.mantenimientosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.pedidosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogoffToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // LogoffToolStripMenuItem
            // 
            this.LogoffToolStripMenuItem.Name = "LogoffToolStripMenuItem";
            this.LogoffToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.LogoffToolStripMenuItem.Text = "Log off";
            this.LogoffToolStripMenuItem.Click += new System.EventHandler(this.LogoffToolStripMenuItem_Click);
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.perfilesToolStripMenuItem,
            this.mensajeroToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // perfilesToolStripMenuItem
            // 
            this.perfilesToolStripMenuItem.Name = "perfilesToolStripMenuItem";
            this.perfilesToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.perfilesToolStripMenuItem.Text = "Perfiles";
            this.perfilesToolStripMenuItem.Click += new System.EventHandler(this.perfilesToolStripMenuItem_Click);
            // 
            // mensajeroToolStripMenuItem
            // 
            this.mensajeroToolStripMenuItem.Name = "mensajeroToolStripMenuItem";
            this.mensajeroToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.mensajeroToolStripMenuItem.Text = "Mensajero";
            this.mensajeroToolStripMenuItem.Click += new System.EventHandler(this.mensajeroToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeUsuariosToolStripMenuItem,
            this.listadoHistóricoToolStripMenuItem,
            this.listadoDePaquetesToolStripMenuItem,
            this.listadoCantidadDePaquetesToolStripMenuItem,
            this.listarMToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // listadoDeUsuariosToolStripMenuItem
            // 
            this.listadoDeUsuariosToolStripMenuItem.Name = "listadoDeUsuariosToolStripMenuItem";
            this.listadoDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.listadoDeUsuariosToolStripMenuItem.Text = "Listado de Usuarios";
            // 
            // listadoHistóricoToolStripMenuItem
            // 
            this.listadoHistóricoToolStripMenuItem.Name = "listadoHistóricoToolStripMenuItem";
            this.listadoHistóricoToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.listadoHistóricoToolStripMenuItem.Text = "Listado Histórico";
            // 
            // listadoDePaquetesToolStripMenuItem
            // 
            this.listadoDePaquetesToolStripMenuItem.Name = "listadoDePaquetesToolStripMenuItem";
            this.listadoDePaquetesToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.listadoDePaquetesToolStripMenuItem.Text = "Listado de Paquetes";
            // 
            // listadoCantidadDePaquetesToolStripMenuItem
            // 
            this.listadoCantidadDePaquetesToolStripMenuItem.Name = "listadoCantidadDePaquetesToolStripMenuItem";
            this.listadoCantidadDePaquetesToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.listadoCantidadDePaquetesToolStripMenuItem.Text = "Listado Cantidad de Paquetes";
            // 
            // listarMToolStripMenuItem
            // 
            this.listarMToolStripMenuItem.Name = "listarMToolStripMenuItem";
            this.listarMToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.listarMToolStripMenuItem.Text = "Listar Monto Percibido";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadoPedidosToolStripMenuItem,
            this.estadoPedidoToolStripMenuItem});
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // estadoPedidosToolStripMenuItem
            // 
            this.estadoPedidosToolStripMenuItem.Name = "estadoPedidosToolStripMenuItem";
            this.estadoPedidosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.estadoPedidosToolStripMenuItem.Text = "Consulta de pedidos";
            this.estadoPedidosToolStripMenuItem.Click += new System.EventHandler(this.estadoPedidosToolStripMenuItem_Click);
            // 
            // estadoPedidoToolStripMenuItem
            // 
            this.estadoPedidoToolStripMenuItem.Name = "estadoPedidoToolStripMenuItem";
            this.estadoPedidoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.estadoPedidoToolStripMenuItem.Text = "Estado Pedido";
            this.estadoPedidoToolStripMenuItem.Click += new System.EventHandler(this.estadoPedidoToolStripMenuItem_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA==";
            this.skinEngine1.SkinFile = "C:\\Users\\jcval\\source\\repos\\Proyecto_1\\Presentacion\\Presentacion\\Recursos\\SkinVS." +
    "NET\\Wave\\Wave.ssk";
            this.skinEngine1.SkinStreamMain = ((System.IO.Stream)(resources.GetObject("skinEngine1.SkinStreamMain")));
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENÚ PRINCIPAL";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogoffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoHistóricoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDePaquetesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoCantidadDePaquetesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mensajeroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoPedidoToolStripMenuItem;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}