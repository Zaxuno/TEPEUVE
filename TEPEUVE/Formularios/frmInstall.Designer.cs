namespace TEPEUVE.Formularios
{
    partial class frmInstall
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
            this.tabPaso2 = new System.Windows.Forms.TabPage();
            this.txbApellidos = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.labApellidos = new System.Windows.Forms.Label();
            this.labNombre = new System.Windows.Forms.Label();
            this.tabPaso1 = new System.Windows.Forms.TabPage();
            this.grbIntervalo = new System.Windows.Forms.GroupBox();
            this.rdbDias = new System.Windows.Forms.RadioButton();
            this.rdbHoras = new System.Windows.Forms.RadioButton();
            this.rdbMinutos = new System.Windows.Forms.RadioButton();
            this.grbBackups = new System.Windows.Forms.GroupBox();
            this.txbRutaBackup = new System.Windows.Forms.TextBox();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.txbRutaDatos = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnRutaBackup = new System.Windows.Forms.Button();
            this.btnRutaDatos = new System.Windows.Forms.Button();
            this.nudIntervalo = new System.Windows.Forms.NumericUpDown();
            this.tabPaso2.SuspendLayout();
            this.tabPaso1.SuspendLayout();
            this.grbIntervalo.SuspendLayout();
            this.grbBackups.SuspendLayout();
            this.grbDatos.SuspendLayout();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervalo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPaso2
            // 
            this.tabPaso2.Controls.Add(this.txbApellidos);
            this.tabPaso2.Controls.Add(this.txbNombre);
            this.tabPaso2.Controls.Add(this.labApellidos);
            this.tabPaso2.Controls.Add(this.labNombre);
            this.tabPaso2.Location = new System.Drawing.Point(4, 29);
            this.tabPaso2.Name = "tabPaso2";
            this.tabPaso2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPaso2.Size = new System.Drawing.Size(588, 332);
            this.tabPaso2.TabIndex = 2;
            this.tabPaso2.Text = "Paso 2: Administrador";
            this.tabPaso2.UseVisualStyleBackColor = true;
            // 
            // txbApellidos
            // 
            this.txbApellidos.Location = new System.Drawing.Point(257, 26);
            this.txbApellidos.Name = "txbApellidos";
            this.txbApellidos.Size = new System.Drawing.Size(321, 26);
            this.txbApellidos.TabIndex = 3;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(10, 26);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(241, 26);
            this.txbNombre.TabIndex = 1;
            // 
            // labApellidos
            // 
            this.labApellidos.AutoSize = true;
            this.labApellidos.Location = new System.Drawing.Point(257, 3);
            this.labApellidos.Name = "labApellidos";
            this.labApellidos.Size = new System.Drawing.Size(73, 20);
            this.labApellidos.TabIndex = 2;
            this.labApellidos.Text = "Apellidos";
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Location = new System.Drawing.Point(10, 3);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(65, 20);
            this.labNombre.TabIndex = 0;
            this.labNombre.Text = "Nombre";
            // 
            // tabPaso1
            // 
            this.tabPaso1.Controls.Add(this.grbIntervalo);
            this.tabPaso1.Controls.Add(this.grbBackups);
            this.tabPaso1.Controls.Add(this.grbDatos);
            this.tabPaso1.Location = new System.Drawing.Point(4, 29);
            this.tabPaso1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPaso1.Name = "tabPaso1";
            this.tabPaso1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPaso1.Size = new System.Drawing.Size(588, 332);
            this.tabPaso1.TabIndex = 0;
            this.tabPaso1.Text = "Paso 1: Rutas y Backup";
            this.tabPaso1.UseVisualStyleBackColor = true;
            // 
            // grbIntervalo
            // 
            this.grbIntervalo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbIntervalo.Controls.Add(this.nudIntervalo);
            this.grbIntervalo.Controls.Add(this.rdbDias);
            this.grbIntervalo.Controls.Add(this.rdbHoras);
            this.grbIntervalo.Controls.Add(this.rdbMinutos);
            this.grbIntervalo.Location = new System.Drawing.Point(7, 171);
            this.grbIntervalo.Name = "grbIntervalo";
            this.grbIntervalo.Size = new System.Drawing.Size(570, 62);
            this.grbIntervalo.TabIndex = 8;
            this.grbIntervalo.TabStop = false;
            this.grbIntervalo.Text = "Intervalo del Backup";
            // 
            // rdbDias
            // 
            this.rdbDias.AutoSize = true;
            this.rdbDias.Checked = true;
            this.rdbDias.Location = new System.Drawing.Point(406, 26);
            this.rdbDias.Name = "rdbDias";
            this.rdbDias.Size = new System.Drawing.Size(59, 24);
            this.rdbDias.TabIndex = 2;
            this.rdbDias.TabStop = true;
            this.rdbDias.Text = "Días";
            this.rdbDias.UseVisualStyleBackColor = true;
            // 
            // rdbHoras
            // 
            this.rdbHoras.AutoSize = true;
            this.rdbHoras.Location = new System.Drawing.Point(330, 26);
            this.rdbHoras.Name = "rdbHoras";
            this.rdbHoras.Size = new System.Drawing.Size(70, 24);
            this.rdbHoras.TabIndex = 1;
            this.rdbHoras.Text = "Horas";
            this.rdbHoras.UseVisualStyleBackColor = true;
            // 
            // rdbMinutos
            // 
            this.rdbMinutos.AutoSize = true;
            this.rdbMinutos.Location = new System.Drawing.Point(241, 26);
            this.rdbMinutos.Name = "rdbMinutos";
            this.rdbMinutos.Size = new System.Drawing.Size(83, 24);
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
            this.grbBackups.Location = new System.Drawing.Point(7, 89);
            this.grbBackups.Name = "grbBackups";
            this.grbBackups.Size = new System.Drawing.Size(570, 76);
            this.grbBackups.TabIndex = 7;
            this.grbBackups.TabStop = false;
            this.grbBackups.Text = "Carpeta para Backups";
            // 
            // txbRutaBackup
            // 
            this.txbRutaBackup.Location = new System.Drawing.Point(8, 25);
            this.txbRutaBackup.Name = "txbRutaBackup";
            this.txbRutaBackup.ReadOnly = true;
            this.txbRutaBackup.Size = new System.Drawing.Size(524, 26);
            this.txbRutaBackup.TabIndex = 4;
            // 
            // grbDatos
            // 
            this.grbDatos.AutoSize = true;
            this.grbDatos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grbDatos.Controls.Add(this.txbRutaDatos);
            this.grbDatos.Controls.Add(this.btnRutaDatos);
            this.grbDatos.Location = new System.Drawing.Point(7, 8);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(570, 75);
            this.grbDatos.TabIndex = 6;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Archivo para los datos";
            // 
            // txbRutaDatos
            // 
            this.txbRutaDatos.Location = new System.Drawing.Point(8, 24);
            this.txbRutaDatos.Name = "txbRutaDatos";
            this.txbRutaDatos.ReadOnly = true;
            this.txbRutaDatos.Size = new System.Drawing.Size(524, 26);
            this.txbRutaDatos.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPaso1);
            this.tabControl.Controls.Add(this.tabPaso2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(596, 365);
            this.tabControl.TabIndex = 0;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSiguiente.Location = new System.Drawing.Point(0, 317);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(596, 48);
            this.btnSiguiente.TabIndex = 8;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnRutaBackup
            // 
            this.btnRutaBackup.BackgroundImage = global::TEPEUVE.Properties.Resources.folder;
            this.btnRutaBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRutaBackup.Location = new System.Drawing.Point(538, 25);
            this.btnRutaBackup.Name = "btnRutaBackup";
            this.btnRutaBackup.Size = new System.Drawing.Size(26, 26);
            this.btnRutaBackup.TabIndex = 5;
            this.btnRutaBackup.UseCompatibleTextRendering = true;
            this.btnRutaBackup.UseVisualStyleBackColor = true;
            this.btnRutaBackup.Click += new System.EventHandler(this.btnRutaBackup_Click);
            // 
            // btnRutaDatos
            // 
            this.btnRutaDatos.BackgroundImage = global::TEPEUVE.Properties.Resources.folder;
            this.btnRutaDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRutaDatos.Location = new System.Drawing.Point(538, 24);
            this.btnRutaDatos.Name = "btnRutaDatos";
            this.btnRutaDatos.Size = new System.Drawing.Size(26, 26);
            this.btnRutaDatos.TabIndex = 2;
            this.btnRutaDatos.UseCompatibleTextRendering = true;
            this.btnRutaDatos.UseVisualStyleBackColor = true;
            this.btnRutaDatos.Click += new System.EventHandler(this.btnRutaDatos_Click);
            // 
            // nudIntervalo
            // 
            this.nudIntervalo.Location = new System.Drawing.Point(105, 25);
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
            this.nudIntervalo.Size = new System.Drawing.Size(120, 26);
            this.nudIntervalo.TabIndex = 4;
            this.nudIntervalo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmInstall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(596, 365);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmInstall";
            this.Text = "Configuración del entorno";
            this.Load += new System.EventHandler(this.frmInstall_Load);
            this.tabPaso2.ResumeLayout(false);
            this.tabPaso2.PerformLayout();
            this.tabPaso1.ResumeLayout(false);
            this.tabPaso1.PerformLayout();
            this.grbIntervalo.ResumeLayout(false);
            this.grbIntervalo.PerformLayout();
            this.grbBackups.ResumeLayout(false);
            this.grbBackups.PerformLayout();
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervalo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPaso2;
        private System.Windows.Forms.TabPage tabPaso1;
        private System.Windows.Forms.GroupBox grbIntervalo;
        private System.Windows.Forms.RadioButton rdbDias;
        private System.Windows.Forms.RadioButton rdbHoras;
        private System.Windows.Forms.RadioButton rdbMinutos;
        private System.Windows.Forms.GroupBox grbBackups;
        private System.Windows.Forms.Button btnRutaBackup;
        private System.Windows.Forms.TextBox txbRutaBackup;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.TextBox txbRutaDatos;
        private System.Windows.Forms.Button btnRutaDatos;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.TextBox txbApellidos;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label labApellidos;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.NumericUpDown nudIntervalo;
    }
}