namespace PracticaClass.CapaPresentación
{
    partial class FrmUsuarios
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
            this.dvgUsuarios = new System.Windows.Forms.DataGridView();
            this.btnGuardarU = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bbtnRefresU = new System.Windows.Forms.Button();
            this.btnEliminarU = new System.Windows.Forms.Button();
            this.btnActualzar = new System.Windows.Forms.Button();
            this.txtClaveGU = new System.Windows.Forms.TextBox();
            this.ChKEstadoGU = new System.Windows.Forms.CheckBox();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgUsuarios
            // 
            this.dvgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgUsuarios.Location = new System.Drawing.Point(64, 77);
            this.dvgUsuarios.Name = "dvgUsuarios";
            this.dvgUsuarios.Size = new System.Drawing.Size(574, 150);
            this.dvgUsuarios.TabIndex = 0;
            this.dvgUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgUsuarios_CellClick);
            // 
            // btnGuardarU
            // 
            this.btnGuardarU.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarU.Location = new System.Drawing.Point(80, 408);
            this.btnGuardarU.Name = "btnGuardarU";
            this.btnGuardarU.Size = new System.Drawing.Size(101, 36);
            this.btnGuardarU.TabIndex = 1;
            this.btnGuardarU.Text = "Guardar";
            this.btnGuardarU.UseVisualStyleBackColor = true;
            this.btnGuardarU.Click += new System.EventHandler(this.btnGuardarU_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            // 
            // txtNUsuario
            // 
            this.txtNUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNUsuario.Location = new System.Drawing.Point(141, 260);
            this.txtNUsuario.Name = "txtNUsuario";
            this.txtNUsuario.Size = new System.Drawing.Size(195, 29);
            this.txtNUsuario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gestion De Usuarios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(393, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(393, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rol:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Clave:";
            // 
            // bbtnRefresU
            // 
            this.bbtnRefresU.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbtnRefresU.Location = new System.Drawing.Point(521, 408);
            this.bbtnRefresU.Name = "bbtnRefresU";
            this.bbtnRefresU.Size = new System.Drawing.Size(101, 36);
            this.bbtnRefresU.TabIndex = 8;
            this.bbtnRefresU.Text = "Refrescar";
            this.bbtnRefresU.UseVisualStyleBackColor = true;
            this.bbtnRefresU.Click += new System.EventHandler(this.bbtnRefresU_Click);
            // 
            // btnEliminarU
            // 
            this.btnEliminarU.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarU.Location = new System.Drawing.Point(386, 408);
            this.btnEliminarU.Name = "btnEliminarU";
            this.btnEliminarU.Size = new System.Drawing.Size(101, 36);
            this.btnEliminarU.TabIndex = 9;
            this.btnEliminarU.Text = "Eliminar";
            this.btnEliminarU.UseVisualStyleBackColor = true;
            this.btnEliminarU.Click += new System.EventHandler(this.btnEliminarU_Click);
            // 
            // btnActualzar
            // 
            this.btnActualzar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualzar.Location = new System.Drawing.Point(235, 408);
            this.btnActualzar.Name = "btnActualzar";
            this.btnActualzar.Size = new System.Drawing.Size(101, 36);
            this.btnActualzar.TabIndex = 10;
            this.btnActualzar.Text = "Actualizar";
            this.btnActualzar.UseVisualStyleBackColor = true;
            this.btnActualzar.Click += new System.EventHandler(this.btnActualzar_Click);
            // 
            // txtClaveGU
            // 
            this.txtClaveGU.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveGU.Location = new System.Drawing.Point(141, 348);
            this.txtClaveGU.Name = "txtClaveGU";
            this.txtClaveGU.Size = new System.Drawing.Size(195, 29);
            this.txtClaveGU.TabIndex = 12;
            // 
            // ChKEstadoGU
            // 
            this.ChKEstadoGU.AutoSize = true;
            this.ChKEstadoGU.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChKEstadoGU.Location = new System.Drawing.Point(473, 351);
            this.ChKEstadoGU.Name = "ChKEstadoGU";
            this.ChKEstadoGU.Size = new System.Drawing.Size(72, 25);
            this.ChKEstadoGU.TabIndex = 13;
            this.ChKEstadoGU.Text = "Activo";
            this.ChKEstadoGU.UseVisualStyleBackColor = true;
            // 
            // cmbRol
            // 
            this.cmbRol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(446, 260);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(135, 29);
            this.cmbRol.TabIndex = 14;
            this.cmbRol.SelectedIndexChanged += new System.EventHandler(this.cmbRol_SelectedIndexChanged);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(12, 189);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(30, 29);
            this.txtId.TabIndex = 15;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 485);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.ChKEstadoGU);
            this.Controls.Add(this.txtClaveGU);
            this.Controls.Add(this.btnActualzar);
            this.Controls.Add(this.btnEliminarU);
            this.Controls.Add(this.bbtnRefresU);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardarU);
            this.Controls.Add(this.dvgUsuarios);
            this.Name = "FrmUsuarios";
            this.Text = "FrmUsuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgUsuarios;
        private System.Windows.Forms.Button btnGuardarU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bbtnRefresU;
        private System.Windows.Forms.Button btnEliminarU;
        private System.Windows.Forms.Button btnActualzar;
        private System.Windows.Forms.TextBox txtClaveGU;
        private System.Windows.Forms.CheckBox ChKEstadoGU;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.TextBox txtId;
    }
}