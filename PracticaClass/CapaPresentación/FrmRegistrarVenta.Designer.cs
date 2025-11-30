namespace PracticaClass.CapaPresentación
{
    partial class FrmRegistrarVenta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblPago = new System.Windows.Forms.Label();
            this.cboPago = new System.Windows.Forms.ComboBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregarP = new System.Windows.Forms.Button();
            this.dvgProductosB = new System.Windows.Forms.DataGridView();
            this.txtBProducto = new System.Windows.Forms.TextBox();
            this.dvgDetalle = new System.Windows.Forms.DataGridView();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnLimpiarD = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProductosB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboPago);
            this.panel1.Controls.Add(this.lblPago);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Controls.Add(this.cboCliente);
            this.panel1.Controls.Add(this.lblCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAgregarP);
            this.panel2.Controls.Add(this.txtBProducto);
            this.panel2.Controls.Add(this.dvgProductosB);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.lblBuscar);
            this.panel2.Location = new System.Drawing.Point(0, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(509, 305);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnLimpiarD);
            this.panel3.Controls.Add(this.btnQuitar);
            this.panel3.Controls.Add(this.dvgDetalle);
            this.panel3.Location = new System.Drawing.Point(515, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(502, 305);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblTotal);
            this.panel4.Controls.Add(this.btnCancelar);
            this.panel4.Controls.Add(this.btnRegistrar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 417);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1017, 100);
            this.panel4.TabIndex = 3;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(31, 43);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(58, 21);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // cboCliente
            // 
            this.cboCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(95, 40);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(198, 29);
            this.cboCliente.TabIndex = 1;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(299, 35);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(91, 36);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Filtrar";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(789, 40);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 29);
            this.dtpFecha.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(730, 43);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(53, 21);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPago.Location = new System.Drawing.Point(443, 43);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(78, 21);
            this.lblPago.TabIndex = 5;
            this.lblPago.Text = "Tipo Pago";
            this.lblPago.Click += new System.EventHandler(this.lblPago_Click);
            // 
            // cboPago
            // 
            this.cboPago.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPago.FormattingEnabled = true;
            this.cboPago.Location = new System.Drawing.Point(527, 40);
            this.cboPago.Name = "cboPago";
            this.cboPago.Size = new System.Drawing.Size(157, 29);
            this.cboPago.TabIndex = 6;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(31, 35);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(123, 21);
            this.lblBuscar.TabIndex = 7;
            this.lblBuscar.Text = "Buscar Producto";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(374, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 36);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Filtrar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregarP
            // 
            this.btnAgregarP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarP.Location = new System.Drawing.Point(180, 251);
            this.btnAgregarP.Name = "btnAgregarP";
            this.btnAgregarP.Size = new System.Drawing.Size(142, 36);
            this.btnAgregarP.TabIndex = 8;
            this.btnAgregarP.Text = "Agregar Producto";
            this.btnAgregarP.UseVisualStyleBackColor = true;
            this.btnAgregarP.Click += new System.EventHandler(this.btnAgregarP_Click);
            // 
            // dvgProductosB
            // 
            this.dvgProductosB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProductosB.Location = new System.Drawing.Point(35, 83);
            this.dvgProductosB.Name = "dvgProductosB";
            this.dvgProductosB.ReadOnly = true;
            this.dvgProductosB.Size = new System.Drawing.Size(430, 150);
            this.dvgProductosB.TabIndex = 9;
            this.dvgProductosB.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgProductosB_CellDoubleClick);
            // 
            // txtBProducto
            // 
            this.txtBProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBProducto.Location = new System.Drawing.Point(180, 32);
            this.txtBProducto.Name = "txtBProducto";
            this.txtBProducto.Size = new System.Drawing.Size(157, 29);
            this.txtBProducto.TabIndex = 10;
            this.txtBProducto.TextChanged += new System.EventHandler(this.txtBProducto_TextChanged);
            this.txtBProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBProducto_KeyDown);
            // 
            // dvgDetalle
            // 
            this.dvgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDetalle.Location = new System.Drawing.Point(73, 45);
            this.dvgDetalle.Name = "dvgDetalle";
            this.dvgDetalle.ReadOnly = true;
            this.dvgDetalle.Size = new System.Drawing.Size(373, 174);
            this.dvgDetalle.TabIndex = 11;
            this.dvgDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgDetalle_CellContentClick);
            this.dvgDetalle.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgDetalle_CellEndEdit);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(99, 251);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(141, 36);
            this.btnQuitar.TabIndex = 11;
            this.btnQuitar.Text = "Eliminar una fila";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnLimpiarD
            // 
            this.btnLimpiarD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarD.Location = new System.Drawing.Point(290, 251);
            this.btnLimpiarD.Name = "btnLimpiarD";
            this.btnLimpiarD.Size = new System.Drawing.Size(125, 36);
            this.btnLimpiarD.TabIndex = 12;
            this.btnLimpiarD.Text = "Limpiar Campo";
            this.btnLimpiarD.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(543, 32);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(141, 36);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "Registrar Venta";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(771, 32);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(141, 36);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(74, 40);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(92, 21);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Monto Total";
            // 
            // FrmRegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 517);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmRegistrarVenta";
            this.Text = "FrmRegistrarVenta";
            this.Load += new System.EventHandler(this.FrmRegistrarVenta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProductosB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cboPago;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtBProducto;
        private System.Windows.Forms.DataGridView dvgProductosB;
        private System.Windows.Forms.Button btnAgregarP;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnLimpiarD;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.DataGridView dvgDetalle;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblTotal;
    }
}