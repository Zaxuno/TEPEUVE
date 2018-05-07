namespace TEPEUVE.Formularios
{
    partial class frmInstall1
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
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPT = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbIntervalo = new System.Windows.Forms.GroupBox();
            this.nudIntervalo = new System.Windows.Forms.NumericUpDown();
            this.rdbDias = new System.Windows.Forms.RadioButton();
            this.rdbHoras = new System.Windows.Forms.RadioButton();
            this.rdbMinutos = new System.Windows.Forms.RadioButton();
            this.grbBackups = new System.Windows.Forms.GroupBox();
            this.btnRutaBackup = new System.Windows.Forms.Button();
            this.txbRutaBackup = new System.Windows.Forms.TextBox();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.txbRutaDatos = new System.Windows.Forms.TextBox();
            this.btnRutaDatos = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.labTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPT)).BeginInit();
            this.grbIntervalo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervalo)).BeginInit();
            this.grbBackups.SuspendLayout();
            this.grbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // errPT
            // 
            this.errPT.ContainerControl = this;
            // 
            // grbIntervalo
            // 
            this.grbIntervalo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbIntervalo.Controls.Add(this.nudIntervalo);
            this.grbIntervalo.Controls.Add(this.rdbDias);
            this.grbIntervalo.Controls.Add(this.rdbHoras);
            this.grbIntervalo.Controls.Add(this.rdbMinutos);
            this.grbIntervalo.Location = new System.Drawing.Point(13, 374);
            this.grbIntervalo.Margin = new System.Windows.Forms.Padding(4);
            this.grbIntervalo.Name = "grbIntervalo";
            this.grbIntervalo.Padding = new System.Windows.Forms.Padding(4);
            this.grbIntervalo.Size = new System.Drawing.Size(760, 96);
            this.grbIntervalo.TabIndex = 15;
            this.grbIntervalo.TabStop = false;
            this.grbIntervalo.Text = "Intervalo del Backup";
            // 
            // nudIntervalo
            // 
            this.nudIntervalo.BackColor = System.Drawing.Color.White;
            this.nudIntervalo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudIntervalo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.nudIntervalo.Location = new System.Drawing.Point(140, 39);
            this.nudIntervalo.Margin = new System.Windows.Forms.Padding(4);
            this.nudIntervalo.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.nudIntervalo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudIntervalo.Name = "nudIntervalo";
            this.nudIntervalo.Size = new System.Drawing.Size(160, 39);
            this.nudIntervalo.TabIndex = 4;
            this.nudIntervalo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudIntervalo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rdbDias
            // 
            this.rdbDias.AutoSize = true;
            this.rdbDias.Checked = true;
            this.rdbDias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbDias.Location = new System.Drawing.Point(541, 40);
            this.rdbDias.Margin = new System.Windows.Forms.Padding(4);
            this.rdbDias.Name = "rdbDias";
            this.rdbDias.Size = new System.Drawing.Size(74, 35);
            this.rdbDias.TabIndex = 2;
            this.rdbDias.TabStop = true;
            this.rdbDias.Text = "Días";
            this.rdbDias.UseVisualStyleBackColor = true;
            // 
            // rdbHoras
            // 
            this.rdbHoras.AutoSize = true;
            this.rdbHoras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbHoras.Location = new System.Drawing.Point(440, 40);
            this.rdbHoras.Margin = new System.Windows.Forms.Padding(4);
            this.rdbHoras.Name = "rdbHoras";
            this.rdbHoras.Size = new System.Drawing.Size(90, 35);
            this.rdbHoras.TabIndex = 1;
            this.rdbHoras.Text = "Horas";
            this.rdbHoras.UseVisualStyleBackColor = true;
            // 
            // rdbMinutos
            // 
            this.rdbMinutos.AutoSize = true;
            this.rdbMinutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbMinutos.FlatAppearance.BorderSize = 0;
            this.rdbMinutos.Location = new System.Drawing.Point(321, 40);
            this.rdbMinutos.Margin = new System.Windows.Forms.Padding(4);
            this.rdbMinutos.Name = "rdbMinutos";
            this.rdbMinutos.Size = new System.Drawing.Size(112, 35);
            this.rdbMinutos.TabIndex = 0;
            this.rdbMinutos.Text = "Minutos";
            this.rdbMinutos.UseVisualStyleBackColor = true;
            // 
            // grbBackups
            // 
            this.grbBackups.AutoSize = true;
            this.grbBackups.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grbBackups.Controls.Add(this.btnRutaBackup);
            this.grbBackups.Controls.Add(this.txbRutaBackup);
            this.grbBackups.Location = new System.Drawing.Point(13, 237);
            this.grbBackups.Margin = new System.Windows.Forms.Padding(4);
            this.grbBackups.Name = "grbBackups";
            this.grbBackups.Padding = new System.Windows.Forms.Padding(4);
            this.grbBackups.Size = new System.Drawing.Size(760, 117);
            this.grbBackups.TabIndex = 14;
            this.grbBackups.TabStop = false;
            this.grbBackups.Text = "Carpeta para Backups";
            // 
            // btnRutaBackup
            // 
            this.btnRutaBackup.BackgroundImage = global::TEPEUVE.Properties.Resources.folder;
            this.btnRutaBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRutaBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRutaBackup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(153)))), ((int)(((byte)(2)))));
            this.btnRutaBackup.FlatAppearance.BorderSize = 0;
            this.btnRutaBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRutaBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRutaBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRutaBackup.Location = new System.Drawing.Point(712, 37);
            this.btnRutaBackup.Margin = new System.Windows.Forms.Padding(4);
            this.btnRutaBackup.Name = "btnRutaBackup";
            this.btnRutaBackup.Size = new System.Drawing.Size(40, 40);
            this.btnRutaBackup.TabIndex = 5;
            this.btnRutaBackup.UseCompatibleTextRendering = true;
            this.btnRutaBackup.UseVisualStyleBackColor = true;
            this.btnRutaBackup.Click += new System.EventHandler(this.btnRutaBackup_Click);
            // 
            // txbRutaBackup
            // 
            this.txbRutaBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txbRutaBackup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbRutaBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.txbRutaBackup.Location = new System.Drawing.Point(11, 38);
            this.txbRutaBackup.Margin = new System.Windows.Forms.Padding(4);
            this.txbRutaBackup.Name = "txbRutaBackup";
            this.txbRutaBackup.ReadOnly = true;
            this.txbRutaBackup.Size = new System.Drawing.Size(693, 39);
            this.txbRutaBackup.TabIndex = 4;
            this.txbRutaBackup.Tag = "0";
            // 
            // grbDatos
            // 
            this.grbDatos.AutoSize = true;
            this.grbDatos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grbDatos.Controls.Add(this.txbRutaDatos);
            this.grbDatos.Controls.Add(this.btnRutaDatos);
            this.grbDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.grbDatos.Location = new System.Drawing.Point(13, 100);
            this.grbDatos.Margin = new System.Windows.Forms.Padding(4);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Padding = new System.Windows.Forms.Padding(4);
            this.grbDatos.Size = new System.Drawing.Size(760, 117);
            this.grbDatos.TabIndex = 13;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Archivo para los datos";
            // 
            // txbRutaDatos
            // 
            this.txbRutaDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txbRutaDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbRutaDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.txbRutaDatos.Location = new System.Drawing.Point(11, 38);
            this.txbRutaDatos.Margin = new System.Windows.Forms.Padding(4);
            this.txbRutaDatos.Name = "txbRutaDatos";
            this.txbRutaDatos.ReadOnly = true;
            this.txbRutaDatos.Size = new System.Drawing.Size(693, 39);
            this.txbRutaDatos.TabIndex = 1;
            this.txbRutaDatos.Tag = "0";
            // 
            // btnRutaDatos
            // 
            this.btnRutaDatos.BackgroundImage = global::TEPEUVE.Properties.Resources.folder;
            this.btnRutaDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRutaDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRutaDatos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(153)))), ((int)(((byte)(2)))));
            this.btnRutaDatos.FlatAppearance.BorderSize = 0;
            this.btnRutaDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRutaDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRutaDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRutaDatos.Location = new System.Drawing.Point(712, 37);
            this.btnRutaDatos.Margin = new System.Windows.Forms.Padding(4);
            this.btnRutaDatos.Name = "btnRutaDatos";
            this.btnRutaDatos.Size = new System.Drawing.Size(40, 40);
            this.btnRutaDatos.TabIndex = 2;
            this.btnRutaDatos.UseCompatibleTextRendering = true;
            this.btnRutaDatos.UseVisualStyleBackColor = true;
            this.btnRutaDatos.Click += new System.EventHandler(this.btnRutaDatos_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(30)))), ((int)(((byte)(95)))));
            this.btnSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(233)))), ((int)(((byte)(212)))));
            this.btnSiguiente.Location = new System.Drawing.Point(0, 491);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(786, 75);
            this.btnSiguiente.TabIndex = 16;
            this.btnSiguiente.Text = "SIGUIENTE";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // labTitulo
            // 
            this.labTitulo.AutoSize = true;
            this.labTitulo.BackColor = System.Drawing.Color.Transparent;
            this.labTitulo.Font = new System.Drawing.Font("CuprumFFU", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(21)))), ((int)(((byte)(52)))));
            this.labTitulo.Location = new System.Drawing.Point(129, 9);
            this.labTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Size = new System.Drawing.Size(529, 71);
            this.labTitulo.TabIndex = 17;
            this.labTitulo.Text = "CONFIGURACIÓN (1/2)";
            // 
            // frmInstall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(153)))), ((int)(((byte)(2)))));
            this.ClientSize = new System.Drawing.Size(786, 566);
            this.Controls.Add(this.labTitulo);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.grbIntervalo);
            this.Controls.Add(this.grbBackups);
            this.Controls.Add(this.grbDatos);
            this.Font = new System.Drawing.Font("CuprumFFU", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.MaximizeBox = false;
            this.Name = "frmInstall";
            this.Text = "Configuración del entorno";
            this.Load += new System.EventHandler(this.frmInstall_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPT)).EndInit();
            this.grbIntervalo.ResumeLayout(false);
            this.grbIntervalo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervalo)).EndInit();
            this.grbBackups.ResumeLayout(false);
            this.grbBackups.PerformLayout();
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errP;
        private System.Windows.Forms.ErrorProvider errPT;
        private System.Windows.Forms.GroupBox grbIntervalo;
        private System.Windows.Forms.NumericUpDown nudIntervalo;
        private System.Windows.Forms.RadioButton rdbDias;
        private System.Windows.Forms.RadioButton rdbHoras;
        private System.Windows.Forms.RadioButton rdbMinutos;
        private System.Windows.Forms.GroupBox grbBackups;
        private System.Windows.Forms.Button btnRutaBackup;
        private System.Windows.Forms.TextBox txbRutaBackup;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.TextBox txbRutaDatos;
        private System.Windows.Forms.Button btnRutaDatos;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label labTitulo;
    }
}