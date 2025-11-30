namespace PracticaClass
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarRecetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verRecetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.másVendidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cierreDeCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.bynCorteCaja = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnVentaRapida = new System.Windows.Forms.Button();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.LogoPOs = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panelIzquierdo.SuspendLayout();
            this.panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPOs)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "MenuSuperior ";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // gestiónToolStripMenuItem
            // 
            this.gestiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.recetasToolStripMenuItem});
            this.gestiónToolStripMenuItem.Name = "gestiónToolStripMenuItem";
            this.gestiónToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.gestiónToolStripMenuItem.Text = "Gestión";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarClienteToolStripMenuItem,
            this.verClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // agregarClienteToolStripMenuItem
            // 
            this.agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            this.agregarClienteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.agregarClienteToolStripMenuItem.Text = "Agregar Cliente";
            // 
            // verClientesToolStripMenuItem
            // 
            this.verClientesToolStripMenuItem.Name = "verClientesToolStripMenuItem";
            this.verClientesToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.verClientesToolStripMenuItem.Text = "Ver Clientes";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProductoToolStripMenuItem,
            this.verProductoToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // agregarProductoToolStripMenuItem
            // 
            this.agregarProductoToolStripMenuItem.Name = "agregarProductoToolStripMenuItem";
            this.agregarProductoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.agregarProductoToolStripMenuItem.Text = "Agregar Producto";
            // 
            // verProductoToolStripMenuItem
            // 
            this.verProductoToolStripMenuItem.Name = "verProductoToolStripMenuItem";
            this.verProductoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.verProductoToolStripMenuItem.Text = "Ver Producto";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCategoriaToolStripMenuItem,
            this.verCategoriaToolStripMenuItem});
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            // 
            // agregarCategoriaToolStripMenuItem
            // 
            this.agregarCategoriaToolStripMenuItem.Name = "agregarCategoriaToolStripMenuItem";
            this.agregarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.agregarCategoriaToolStripMenuItem.Text = "Agregar Categoria";
            // 
            // verCategoriaToolStripMenuItem
            // 
            this.verCategoriaToolStripMenuItem.Name = "verCategoriaToolStripMenuItem";
            this.verCategoriaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.verCategoriaToolStripMenuItem.Text = "Ver Categoria";
            // 
            // recetasToolStripMenuItem
            // 
            this.recetasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarRecetaToolStripMenuItem,
            this.verRecetaToolStripMenuItem});
            this.recetasToolStripMenuItem.Name = "recetasToolStripMenuItem";
            this.recetasToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.recetasToolStripMenuItem.Text = "Recetas";
            // 
            // agregarRecetaToolStripMenuItem
            // 
            this.agregarRecetaToolStripMenuItem.Name = "agregarRecetaToolStripMenuItem";
            this.agregarRecetaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.agregarRecetaToolStripMenuItem.Text = "Agregar Receta";
            // 
            // verRecetaToolStripMenuItem
            // 
            this.verRecetaToolStripMenuItem.Name = "verRecetaToolStripMenuItem";
            this.verRecetaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.verRecetaToolStripMenuItem.Text = "Ver Receta";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarVentaToolStripMenuItem,
            this.historialDeVentasToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // registrarVentaToolStripMenuItem
            // 
            this.registrarVentaToolStripMenuItem.Name = "registrarVentaToolStripMenuItem";
            this.registrarVentaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.registrarVentaToolStripMenuItem.Text = "Registrar Venta";
            // 
            // historialDeVentasToolStripMenuItem
            // 
            this.historialDeVentasToolStripMenuItem.Name = "historialDeVentasToolStripMenuItem";
            this.historialDeVentasToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.historialDeVentasToolStripMenuItem.Text = "Historial de Ventas";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reToolStripMenuItem,
            this.másVendidoToolStripMenuItem,
            this.cierreDeCajaToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reToolStripMenuItem
            // 
            this.reToolStripMenuItem.Name = "reToolStripMenuItem";
            this.reToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.reToolStripMenuItem.Text = "Reporte Diario";
            this.reToolStripMenuItem.Click += new System.EventHandler(this.reToolStripMenuItem_Click);
            // 
            // másVendidoToolStripMenuItem
            // 
            this.másVendidoToolStripMenuItem.Name = "másVendidoToolStripMenuItem";
            this.másVendidoToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.másVendidoToolStripMenuItem.Text = "Más Vendido";
            // 
            // cierreDeCajaToolStripMenuItem
            // 
            this.cierreDeCajaToolStripMenuItem.Name = "cierreDeCajaToolStripMenuItem";
            this.cierreDeCajaToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.cierreDeCajaToolStripMenuItem.Text = "Cierre de Caja";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.BackColor = System.Drawing.Color.Wheat;
            this.panelIzquierdo.Controls.Add(this.btnSalir);
            this.panelIzquierdo.Controls.Add(this.bynCorteCaja);
            this.panelIzquierdo.Controls.Add(this.btnInventario);
            this.panelIzquierdo.Controls.Add(this.btnClientes);
            this.panelIzquierdo.Controls.Add(this.btnProductos);
            this.panelIzquierdo.Controls.Add(this.btnVentaRapida);
            this.panelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzquierdo.Location = new System.Drawing.Point(0, 24);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(200, 725);
            this.panelIzquierdo.TabIndex = 1;
            this.panelIzquierdo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelIzquierdo_Paint);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(12, 606);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(180, 55);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // bynCorteCaja
            // 
            this.bynCorteCaja.BackColor = System.Drawing.Color.Transparent;
            this.bynCorteCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bynCorteCaja.ForeColor = System.Drawing.Color.SaddleBrown;
            this.bynCorteCaja.Image = ((System.Drawing.Image)(resources.GetObject("bynCorteCaja.Image")));
            this.bynCorteCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bynCorteCaja.Location = new System.Drawing.Point(12, 495);
            this.bynCorteCaja.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.bynCorteCaja.Name = "bynCorteCaja";
            this.bynCorteCaja.Size = new System.Drawing.Size(180, 55);
            this.bynCorteCaja.TabIndex = 3;
            this.bynCorteCaja.Text = "Corte Caja";
            this.bynCorteCaja.UseVisualStyleBackColor = false;
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.Transparent;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnInventario.Image = ((System.Drawing.Image)(resources.GetObject("btnInventario.Image")));
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(12, 380);
            this.btnInventario.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(180, 55);
            this.btnInventario.TabIndex = 4;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(12, 269);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(180, 55);
            this.btnClientes.TabIndex = 5;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.Transparent;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(12, 160);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(180, 55);
            this.btnProductos.TabIndex = 6;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnVentaRapida
            // 
            this.btnVentaRapida.BackColor = System.Drawing.Color.Transparent;
            this.btnVentaRapida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentaRapida.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnVentaRapida.Image = ((System.Drawing.Image)(resources.GetObject("btnVentaRapida.Image")));
            this.btnVentaRapida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentaRapida.Location = new System.Drawing.Point(12, 52);
            this.btnVentaRapida.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnVentaRapida.Name = "btnVentaRapida";
            this.btnVentaRapida.Size = new System.Drawing.Size(180, 55);
            this.btnVentaRapida.TabIndex = 2;
            this.btnVentaRapida.Text = "Venta Rapida";
            this.btnVentaRapida.UseVisualStyleBackColor = false;
            this.btnVentaRapida.Click += new System.EventHandler(this.btnVentaRapida_Click);
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.Color.SaddleBrown;
            this.panelCentral.Controls.Add(this.LogoPOs);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(200, 24);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(734, 725);
            this.panelCentral.TabIndex = 2;
            // 
            // LogoPOs
            // 
            this.LogoPOs.BackColor = System.Drawing.Color.Transparent;
            this.LogoPOs.Image = ((System.Drawing.Image)(resources.GetObject("LogoPOs.Image")));
            this.LogoPOs.Location = new System.Drawing.Point(3, 3);
            this.LogoPOs.Name = "LogoPOs";
            this.LogoPOs.Size = new System.Drawing.Size(726, 718);
            this.LogoPOs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPOs.TabIndex = 0;
            this.LogoPOs.TabStop = false;
            this.LogoPOs.Click += new System.EventHandler(this.LogoPOs_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 749);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelIzquierdo);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema POS: Cafeteria Dulce Aroma";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.txt1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelIzquierdo.ResumeLayout(false);
            this.panelCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPOs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recetasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarRecetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verRecetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem másVendidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cierreDeCajaToolStripMenuItem;
        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Button btnVentaRapida;
        private System.Windows.Forms.Button bynCorteCaja;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.PictureBox LogoPOs;
    }
}

