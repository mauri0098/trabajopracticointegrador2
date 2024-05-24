namespace trabajopracticointegrador2
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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblReservaciondeAsientos = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cbPerfil = new System.Windows.Forms.ComboBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(104, 61);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(227, 28);
            this.txtUsuario.TabIndex = 34;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(104, 103);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(142, 28);
            this.txtContraseña.TabIndex = 33;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // lblReservaciondeAsientos
            // 
            this.lblReservaciondeAsientos.AutoSize = true;
            this.lblReservaciondeAsientos.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservaciondeAsientos.Location = new System.Drawing.Point(99, 9);
            this.lblReservaciondeAsientos.Name = "lblReservaciondeAsientos";
            this.lblReservaciondeAsientos.Size = new System.Drawing.Size(152, 25);
            this.lblReservaciondeAsientos.TabIndex = 32;
            this.lblReservaciondeAsientos.Text = "Inicio de Sesion";
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.White;
            this.btnEntrar.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.Black;
            this.btnEntrar.Location = new System.Drawing.Point(33, 218);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(101, 35);
            this.btnEntrar.TabIndex = 1;
            this.btnEntrar.Text = "entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(12, 106);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(78, 17);
            this.lblContraseña.TabIndex = 38;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(12, 61);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(55, 17);
            this.lblUsuario.TabIndex = 36;
            this.lblUsuario.Text = "Usuario";
            // 
            // cbPerfil
            // 
            this.cbPerfil.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPerfil.FormattingEnabled = true;
            this.cbPerfil.Items.AddRange(new object[] {
            "ventas",
            "secretarios",
            "compras"});
            this.cbPerfil.Location = new System.Drawing.Point(104, 157);
            this.cbPerfil.Name = "cbPerfil";
            this.cbPerfil.Size = new System.Drawing.Size(142, 25);
            this.cbPerfil.TabIndex = 39;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(12, 157);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(40, 17);
            this.lblPerfil.TabIndex = 40;
            this.lblPerfil.Text = "Perfil";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(353, 300);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.cbPerfil);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblReservaciondeAsientos);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblReservaciondeAsientos;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cbPerfil;
        private System.Windows.Forms.Label lblPerfil;
    }
}