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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPaso1 = new System.Windows.Forms.TabPage();
            this.btnRutaDatos = new System.Windows.Forms.Button();
            this.txbRutaDatos = new System.Windows.Forms.TextBox();
            this.tabPaso2 = new System.Windows.Forms.TabPage();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grbIntervalo = new System.Windows.Forms.GroupBox();
            this.rdbMinutos = new System.Windows.Forms.RadioButton();
            this.rdbHoras = new System.Windows.Forms.RadioButton();
            this.rdbDias = new System.Windows.Forms.RadioButton();
            this.grbBackups = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txbIntervalo = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabPaso1.SuspendLayout();
            this.tabPaso2.SuspendLayout();
            this.grbDatos.SuspendLayout();
            this.grbIntervalo.SuspendLayout();
            this.grbBackups.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPaso1);
            this.tabControl.Controls.Add(this.tabPaso2);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(596, 465);
            this.tabControl.TabIndex = 0;
            // 
            // tabPaso1
            // 
            this.tabPaso1.Controls.Add(this.grbBackups);
            this.tabPaso1.Controls.Add(this.btnSiguiente);
            this.tabPaso1.Controls.Add(this.grbDatos);
            this.tabPaso1.Location = new System.Drawing.Point(4, 29);
            this.tabPaso1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPaso1.Name = "tabPaso1";
            this.tabPaso1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPaso1.Size = new System.Drawing.Size(588, 432);
            this.tabPaso1.TabIndex = 0;
            this.tabPaso1.Text = "Paso 1: Rutas";
            this.tabPaso1.UseVisualStyleBackColor = true;
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
            // 
            // txbRutaDatos
            // 
            this.txbRutaDatos.Location = new System.Drawing.Point(8, 24);
            this.txbRutaDatos.Name = "txbRutaDatos";
            this.txbRutaDatos.ReadOnly = true;
            this.txbRutaDatos.Size = new System.Drawing.Size(524, 26);
            this.txbRutaDatos.TabIndex = 1;
            // 
            // tabPaso2
            // 
            this.tabPaso2.Controls.Add(this.grbIntervalo);
            this.tabPaso2.Location = new System.Drawing.Point(4, 29);
            this.tabPaso2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPaso2.Name = "tabPaso2";
            this.tabPaso2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPaso2.Size = new System.Drawing.Size(588, 432);
            this.tabPaso2.TabIndex = 1;
            this.tabPaso2.Text = "Paso 2: Backup";
            this.tabPaso2.UseVisualStyleBackColor = true;
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
            // btnSiguiente
            // 
            this.btnSiguiente.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSiguiente.Location = new System.Drawing.Point(4, 379);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(580, 48);
            this.btnSiguiente.TabIndex = 7;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(588, 432);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Paso 3: Administrador";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grbIntervalo
            // 
            this.grbIntervalo.AutoSize = true;
            this.grbIntervalo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grbIntervalo.Controls.Add(this.txbIntervalo);
            this.grbIntervalo.Controls.Add(this.rdbDias);
            this.grbIntervalo.Controls.Add(this.rdbHoras);
            this.grbIntervalo.Controls.Add(this.rdbMinutos);
            this.grbIntervalo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbIntervalo.Location = new System.Drawing.Point(4, 5);
            this.grbIntervalo.Name = "grbIntervalo";
            this.grbIntervalo.Size = new System.Drawing.Size(580, 76);
            this.grbIntervalo.TabIndex = 0;
            this.grbIntervalo.TabStop = false;
            this.grbIntervalo.Text = "Intervalo";
            // 
            // rdbMinutos
            // 
            this.rdbMinutos.AutoSize = true;
            this.rdbMinutos.Location = new System.Drawing.Point(208, 25);
            this.rdbMinutos.Name = "rdbMinutos";
            this.rdbMinutos.Size = new System.Drawing.Size(83, 24);
            this.rdbMinutos.TabIndex = 0;
            this.rdbMinutos.TabStop = true;
            this.rdbMinutos.Text = "Minutos";
            this.rdbMinutos.UseVisualStyleBackColor = true;
            // 
            // rdbHoras
            // 
            this.rdbHoras.AutoSize = true;
            this.rdbHoras.Location = new System.Drawing.Point(297, 25);
            this.rdbHoras.Name = "rdbHoras";
            this.rdbHoras.Size = new System.Drawing.Size(70, 24);
            this.rdbHoras.TabIndex = 1;
            this.rdbHoras.TabStop = true;
            this.rdbHoras.Text = "Horas";
            this.rdbHoras.UseVisualStyleBackColor = true;
            // 
            // rdbDias
            // 
            this.rdbDias.AutoSize = true;
            this.rdbDias.Location = new System.Drawing.Point(373, 25);
            this.rdbDias.Name = "rdbDias";
            this.rdbDias.Size = new System.Drawing.Size(59, 24);
            this.rdbDias.TabIndex = 2;
            this.rdbDias.TabStop = true;
            this.rdbDias.Text = "Días";
            this.rdbDias.UseVisualStyleBackColor = true;
            // 
            // grbBackups
            // 
            this.grbBackups.AutoSize = true;
            this.grbBackups.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grbBackups.Controls.Add(this.button1);
            this.grbBackups.Controls.Add(this.textBox2);
            this.grbBackups.Location = new System.Drawing.Point(7, 89);
            this.grbBackups.Name = "grbBackups";
            this.grbBackups.Size = new System.Drawing.Size(570, 76);
            this.grbBackups.TabIndex = 7;
            this.grbBackups.TabStop = false;
            this.grbBackups.Text = "Carpeta para backups";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::TEPEUVE.Properties.Resources.folder;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(538, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 26);
            this.button1.TabIndex = 5;
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(524, 26);
            this.textBox2.TabIndex = 4;
            // 
            // txbIntervalo
            // 
            this.txbIntervalo.Location = new System.Drawing.Point(149, 25);
            this.txbIntervalo.Name = "txbIntervalo";
            this.txbIntervalo.Size = new System.Drawing.Size(53, 26);
            this.txbIntervalo.TabIndex = 3;
            // 
            // frmInstall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(596, 465);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmInstall";
            this.Text = "Configuración del entorno";
            this.tabControl.ResumeLayout(false);
            this.tabPaso1.ResumeLayout(false);
            this.tabPaso1.PerformLayout();
            this.tabPaso2.ResumeLayout(false);
            this.tabPaso2.PerformLayout();
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.grbIntervalo.ResumeLayout(false);
            this.grbIntervalo.PerformLayout();
            this.grbBackups.ResumeLayout(false);
            this.grbBackups.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPaso1;
        private System.Windows.Forms.TabPage tabPaso2;
        private System.Windows.Forms.Button btnRutaDatos;
        private System.Windows.Forms.TextBox txbRutaDatos;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.GroupBox grbBackups;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox grbIntervalo;
        private System.Windows.Forms.RadioButton rdbDias;
        private System.Windows.Forms.RadioButton rdbHoras;
        private System.Windows.Forms.RadioButton rdbMinutos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txbIntervalo;
    }
}