namespace PracticaClass
{
    partial class FrmClientes
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
            this.lblRegistro = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNombreC = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtNombreC = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.gpbCliente = new System.Windows.Forms.GroupBox();
            this.btnVolverC = new System.Windows.Forms.Button();
            this.btnEliminarC = new System.Windows.Forms.Button();
            this.btnCampo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.gpbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.BackColor = System.Drawing.Color.BurlyWood;
            this.lblRegistro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(28, 9);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(0, 25);
            this.lblRegistro.TabIndex = 0;
            this.lblRegistro.Click += new System.EventHandler(this.lblRegistro_Click);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.BurlyWood;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(49, 139);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(92, 25);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.BurlyWood;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(373, 232);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(84, 25);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblNombreC
            // 
            this.lblNombreC.AutoSize = true;
            this.lblNombreC.BackColor = System.Drawing.Color.BurlyWood;
            this.lblNombreC.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreC.Location = new System.Drawing.Point(49, 70);
            this.lblNombreC.Name = "lblNombreC";
            this.lblNombreC.Size = new System.Drawing.Size(81, 25);
            this.lblNombreC.TabIndex = 3;
            this.lblNombreC.Text = "Nombre";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.BurlyWood;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(439, 70);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(30, 25);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "ID";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.BurlyWood;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(373, 139);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(169, 25);
            this.lblCorreo.TabIndex = 5;
            this.lblCorreo.Text = "Correo Electronico";
            this.lblCorreo.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.BackColor = System.Drawing.Color.BurlyWood;
            this.lblGenero.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(49, 232);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(74, 25);
            this.lblGenero.TabIndex = 6;
            this.lblGenero.Text = "Genero";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(54, 171);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(241, 29);
            this.txtDireccion.TabIndex = 7;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(479, 232);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(140, 29);
            this.txtTelefono.TabIndex = 8;
            // 
            // txtGenero
            // 
            this.txtGenero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenero.Location = new System.Drawing.Point(153, 232);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(150, 29);
            this.txtGenero.TabIndex = 9;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(378, 171);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(241, 29);
            this.txtCorreo.TabIndex = 10;
            // 
            // txtNombreC
            // 
            this.txtNombreC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreC.Location = new System.Drawing.Point(153, 70);
            this.txtNombreC.Name = "txtNombreC";
            this.txtNombreC.Size = new System.Drawing.Size(241, 29);
            this.txtNombreC.TabIndex = 11;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(491, 70);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(128, 29);
            this.txtID.TabIndex = 12;
            // 
            // dgvClientes
            // 
            this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(44, 360);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(691, 195);
            this.dgvClientes.TabIndex = 13;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // gpbCliente
            // 
            this.gpbCliente.Controls.Add(this.btnVolverC);
            this.gpbCliente.Controls.Add(this.btnEliminarC);
            this.gpbCliente.Controls.Add(this.btnCampo);
            this.gpbCliente.Controls.Add(this.btnEditar);
            this.gpbCliente.Controls.Add(this.btnUsuario);
            this.gpbCliente.Controls.Add(this.lblNombreC);
            this.gpbCliente.Controls.Add(this.txtNombreC);
            this.gpbCliente.Controls.Add(this.lblGenero);
            this.gpbCliente.Controls.Add(this.txtID);
            this.gpbCliente.Controls.Add(this.lblTelefono);
            this.gpbCliente.Controls.Add(this.lblDireccion);
            this.gpbCliente.Controls.Add(this.txtCorreo);
            this.gpbCliente.Controls.Add(this.txtGenero);
            this.gpbCliente.Controls.Add(this.txtTelefono);
            this.gpbCliente.Controls.Add(this.txtDireccion);
            this.gpbCliente.Controls.Add(this.lblCorreo);
            this.gpbCliente.Controls.Add(this.lblID);
            this.gpbCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCliente.Location = new System.Drawing.Point(44, 9);
            this.gpbCliente.Name = "gpbCliente";
            this.gpbCliente.Size = new System.Drawing.Size(691, 345);
            this.gpbCliente.TabIndex = 14;
            this.gpbCliente.TabStop = false;
            this.gpbCliente.Text = "REGISTRO DE CLIENTES";
            this.gpbCliente.Enter += new System.EventHandler(this.gpbCliente_Enter);
            // 
            // btnVolverC
            // 
            this.btnVolverC.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnVolverC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVolverC.Location = new System.Drawing.Point(587, 16);
            this.btnVolverC.Name = "btnVolverC";
            this.btnVolverC.Size = new System.Drawing.Size(89, 30);
            this.btnVolverC.TabIndex = 19;
            this.btnVolverC.Text = "Volver";
            this.btnVolverC.UseVisualStyleBackColor = false;
            this.btnVolverC.Click += new System.EventHandler(this.btnVolverC_Click);
            // 
            // btnEliminarC
            // 
            this.btnEliminarC.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnEliminarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarC.Location = new System.Drawing.Point(519, 304);
            this.btnEliminarC.Name = "btnEliminarC";
            this.btnEliminarC.Size = new System.Drawing.Size(135, 30);
            this.btnEliminarC.TabIndex = 18;
            this.btnEliminarC.Text = "Eliminar";
            this.btnEliminarC.UseVisualStyleBackColor = false;
            this.btnEliminarC.Click += new System.EventHandler(this.btnEliminarC_Click);
            // 
            // btnCampo
            // 
            this.btnCampo.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnCampo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCampo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCampo.Location = new System.Drawing.Point(354, 304);
            this.btnCampo.Name = "btnCampo";
            this.btnCampo.Size = new System.Drawing.Size(135, 30);
            this.btnCampo.TabIndex = 17;
            this.btnCampo.Text = "Limpiar Campo";
            this.btnCampo.UseVisualStyleBackColor = false;
            this.btnCampo.Click += new System.EventHandler(this.btnCampo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditar.Location = new System.Drawing.Point(188, 304);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(135, 30);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Modifcar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUsuario.Location = new System.Drawing.Point(25, 304);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(135, 30);
            this.btnUsuario.TabIndex = 15;
            this.btnUsuario.Text = "Agregar Usuario";
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(776, 571);
            this.Controls.Add(this.gpbCliente);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.lblRegistro);
            this.Name = "FrmClientes";
            this.Text = "Registro de Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.gpbCliente.ResumeLayout(false);
            this.gpbCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNombreC;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNombreC;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.GroupBox gpbCliente;
        private System.Windows.Forms.Button btnEliminarC;
        private System.Windows.Forms.Button btnCampo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnVolverC;
    }
}