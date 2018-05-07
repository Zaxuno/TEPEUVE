namespace TEPEUVE
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            this.labUsuario = new System.Windows.Forms.Label();
            this.labPassword = new System.Windows.Forms.Label();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.labTitulo = new System.Windows.Forms.Label();
            this.erpUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpPassword = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erpUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // labUsuario
            // 
            this.labUsuario.AutoSize = true;
            this.labUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.labUsuario.Location = new System.Drawing.Point(142, 93);
            this.labUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labUsuario.Name = "labUsuario";
            this.labUsuario.Size = new System.Drawing.Size(101, 31);
            this.labUsuario.TabIndex = 0;
            this.labUsuario.Text = "USUARIO";
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.labPassword.Location = new System.Drawing.Point(120, 189);
            this.labPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(145, 31);
            this.labPassword.TabIndex = 1;
            this.labPassword.Text = "CONTRASEÑA";
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.btnAcceder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAcceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcceder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAcceder.FlatAppearance.BorderSize = 0;
            this.btnAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(30)))), ((int)(((byte)(95)))));
            this.btnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(233)))), ((int)(((byte)(212)))));
            this.btnAcceder.Location = new System.Drawing.Point(0, 285);
            this.btnAcceder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(384, 75);
            this.btnAcceder.TabIndex = 2;
            this.btnAcceder.Text = "ACCEDER";
            this.btnAcceder.UseVisualStyleBackColor = false;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.BackColor = System.Drawing.Color.White;
            this.cmbUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cmbUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(17, 137);
            this.cmbUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(351, 39);
            this.cmbUsuario.TabIndex = 3;
            // 
            // txbPassword
            // 
            this.txbPassword.BackColor = System.Drawing.Color.White;
            this.txbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.txbPassword.Location = new System.Drawing.Point(17, 233);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '⊙';
            this.txbPassword.Size = new System.Drawing.Size(351, 39);
            this.txbPassword.TabIndex = 4;
            // 
            // labTitulo
            // 
            this.labTitulo.AutoSize = true;
            this.labTitulo.BackColor = System.Drawing.Color.Transparent;
            this.labTitulo.Font = new System.Drawing.Font("CuprumFFU", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(21)))), ((int)(((byte)(52)))));
            this.labTitulo.Location = new System.Drawing.Point(74, 9);
            this.labTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Size = new System.Drawing.Size(237, 71);
            this.labTitulo.TabIndex = 5;
            this.labTitulo.Text = "TEPEUVE";
            // 
            // erpUsuario
            // 
            this.erpUsuario.ContainerControl = this;
            // 
            // erpPassword
            // 
            this.erpPassword.ContainerControl = this;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(153)))), ((int)(((byte)(2)))));
            this.ClientSize = new System.Drawing.Size(384, 360);
            this.Controls.Add(this.labTitulo);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.labPassword);
            this.Controls.Add(this.labUsuario);
            this.Font = new System.Drawing.Font("CuprumFFU", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.Text = "Iniciar sesión";
            ((System.ComponentModel.ISupportInitialize)(this.erpUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labUsuario;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label labTitulo;
        private System.Windows.Forms.ErrorProvider erpUsuario;
        private System.Windows.Forms.ErrorProvider erpPassword;
        private System.Windows.Forms.TextBox txbPassword;
    }
}

