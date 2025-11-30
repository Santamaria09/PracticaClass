namespace PracticaClass
{
    partial class FrmProductos
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
            this.lblControl = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.grBProducto = new System.Windows.Forms.GroupBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.grBProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblControl
            // 
            this.lblControl.AutoSize = true;
            this.lblControl.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblControl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControl.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblControl.Location = new System.Drawing.Point(314, 21);
            this.lblControl.Name = "lblControl";
            this.lblControl.Size = new System.Drawing.Size(191, 25);
            this.lblControl.TabIndex = 0;
            this.lblControl.Text = "Control de Productos";
            // 
            // dgvProductos
            // 
            this.dgvProductos.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(75, 67);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(689, 166);
            this.dgvProductos.TabIndex = 1;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // grBProducto
            // 
            this.grBProducto.Controls.Add(this.btnVolver);
            this.grBProducto.Controls.Add(this.btnModificar);
            this.grBProducto.Controls.Add(this.btnEliminar);
            this.grBProducto.Controls.Add(this.btnLimpiar);
            this.grBProducto.Controls.Add(this.txtStock);
            this.grBProducto.Controls.Add(this.txtPrecio);
            this.grBProducto.Controls.Add(this.btnAgregar);
            this.grBProducto.Controls.Add(this.checkBox1);
            this.grBProducto.Controls.Add(this.lblEstado);
            this.grBProducto.Controls.Add(this.lblPrecio);
            this.grBProducto.Controls.Add(this.lblStock);
            this.grBProducto.Controls.Add(this.txtDescripcion);
            this.grBProducto.Controls.Add(this.txtNombre);
            this.grBProducto.Controls.Add(this.lblNombre);
            this.grBProducto.Controls.Add(this.lblDescripcion);
            this.grBProducto.Controls.Add(this.TxtCodigo);
            this.grBProducto.Controls.Add(this.lblCodigo);
            this.grBProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBProducto.Location = new System.Drawing.Point(75, 251);
            this.grBProducto.Name = "grBProducto";
            this.grBProducto.Size = new System.Drawing.Size(689, 318);
            this.grBProducto.TabIndex = 2;
            this.grBProducto.TabStop = false;
            this.grBProducto.Text = "Producto";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnVolver.Location = new System.Drawing.Point(523, 256);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(141, 42);
            this.btnVolver.TabIndex = 16;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnModificar.Location = new System.Drawing.Point(523, 89);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(141, 42);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnEliminar.Location = new System.Drawing.Point(523, 144);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(141, 42);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnLimpiar.Location = new System.Drawing.Point(523, 198);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(141, 42);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtStock.Location = new System.Drawing.Point(376, 182);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(100, 29);
            this.txtStock.TabIndex = 12;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtPrecio.Location = new System.Drawing.Point(138, 182);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(100, 29);
            this.txtPrecio.TabIndex = 11;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnAgregar.Location = new System.Drawing.Point(523, 32);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(141, 42);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar Producto";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(140, 252);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(132, 25);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Activo/Inactivo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(47, 256);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(56, 21);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Estado";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(47, 185);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(53, 21);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(272, 185);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(47, 21);
            this.lblStock.TabIndex = 6;
            this.lblStock.Text = "Stock";
            this.lblStock.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtDescripcion.Location = new System.Drawing.Point(140, 117);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(290, 29);
            this.txtDescripcion.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtNombre.Location = new System.Drawing.Point(376, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(100, 29);
            this.txtNombre.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(272, 53);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 21);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(43, 120);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(91, 21);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción";
            this.lblDescripcion.Click += new System.EventHandler(this.label3_Click);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TxtCodigo.Location = new System.Drawing.Point(138, 45);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.ReadOnly = true;
            this.TxtCodigo.Size = new System.Drawing.Size(100, 29);
            this.TxtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(47, 53);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(60, 21);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(844, 598);
            this.Controls.Add(this.grBProducto);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.lblControl);
            this.Name = "FrmProductos";
            this.Text = "Formulario Principal de Productos ";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.grBProducto.ResumeLayout(false);
            this.grBProducto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblControl;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.GroupBox grBProducto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}