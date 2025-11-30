namespace PracticaClass.CapaPresentación
{
    partial class FrmClienteBase
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
            this.dvgCliente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDui = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.ChkEstado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgCliente
            // 
            this.dvgCliente.BackgroundColor = System.Drawing.Color.White;
            this.dvgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCliente.Location = new System.Drawing.Point(58, 107);
            this.dvgCliente.Name = "dvgCliente";
            this.dvgCliente.Size = new System.Drawing.Size(690, 150);
            this.dvgCliente.TabIndex = 0;
            this.dvgCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCliente_CellClick);
            this.dvgCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCliente_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "CONTROL DE CLIENTES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOMBRE/TELÉFONO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "DUI";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(245, 64);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(420, 29);
            this.txtBuscar.TabIndex = 5;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(147, 292);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(208, 29);
            this.txtNombre.TabIndex = 6;
            // 
            // txtDui
            // 
            this.txtDui.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDui.Location = new System.Drawing.Point(147, 363);
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(176, 29);
            this.txtDui.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(407, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Teléfono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(407, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Estado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Correo";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(65, 477);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(137, 38);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(234, 477);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(136, 38);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(412, 477);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(136, 38);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(581, 477);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(136, 38);
            this.btnVolver.TabIndex = 14;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(147, 426);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(176, 29);
            this.txtCorreo.TabIndex = 15;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(512, 292);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(176, 29);
            this.txtTelefono.TabIndex = 16;
            // 
            // ChkEstado
            // 
            this.ChkEstado.AutoSize = true;
            this.ChkEstado.Checked = true;
            this.ChkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkEstado.Location = new System.Drawing.Point(512, 347);
            this.ChkEstado.Name = "ChkEstado";
            this.ChkEstado.Size = new System.Drawing.Size(159, 25);
            this.ChkEstado.TabIndex = 17;
            this.ChkEstado.Text = "ACTIVO/INACTIVO";
            this.ChkEstado.UseVisualStyleBackColor = true;
            // 
            // FrmClienteBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(795, 537);
            this.Controls.Add(this.ChkEstado);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDui);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvgCliente);
            this.Name = "FrmClienteBase";
            this.Text = "FrmClienteBase";
            this.Load += new System.EventHandler(this.FrmClienteBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDui;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.CheckBox ChkEstado;
    }
}