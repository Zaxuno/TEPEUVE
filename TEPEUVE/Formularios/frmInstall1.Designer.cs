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
            this.nudIntervalo = new System.Windows.Forms.NumericUpDown();
            this.rdbDias = new System.Windows.Forms.RadioButton();
            this.rdbHoras = new System.Windows.Forms.RadioButton();
            this.rdbMinutos = new System.Windows.Forms.RadioButton();
            this.txbRutaBackup = new System.Windows.Forms.TextBox();
            this.txbRutaDatos = new System.Windows.Forms.TextBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.labTitulo = new System.Windows.Forms.Label();
            this.btnRutaBackup = new System.Windows.Forms.Button();
            this.btnRutaDatos = new System.Windows.Forms.Button();
            this.grbRutaDatos = new GroupBoxEx.GroupBoxEx();
            this.grbRutaBackup = new GroupBoxEx.GroupBoxEx();
            this.grbIntervaloBackup = new GroupBoxEx.GroupBoxEx();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervalo)).BeginInit();
            this.grbRutaDatos.SuspendLayout();
            this.grbRutaBackup.SuspendLayout();
            this.grbIntervaloBackup.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudIntervalo
            // 
            this.nudIntervalo.BackColor = System.Drawing.Color.White;
            this.nudIntervalo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudIntervalo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.nudIntervalo.Location = new System.Drawing.Point(143, 43);
            this.nudIntervalo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.rdbDias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(21)))), ((int)(((byte)(52)))));
            this.rdbDias.Location = new System.Drawing.Point(544, 45);
            this.rdbDias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.rdbHoras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(21)))), ((int)(((byte)(52)))));
            this.rdbHoras.Location = new System.Drawing.Point(443, 45);
            this.rdbHoras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.rdbMinutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(21)))), ((int)(((byte)(52)))));
            this.rdbMinutos.Location = new System.Drawing.Point(324, 45);
            this.rdbMinutos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbMinutos.Name = "rdbMinutos";
            this.rdbMinutos.Size = new System.Drawing.Size(112, 35);
            this.rdbMinutos.TabIndex = 0;
            this.rdbMinutos.Text = "Minutos";
            this.rdbMinutos.UseVisualStyleBackColor = true;
            // 
            // txbRutaBackup
            // 
            this.txbRutaBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txbRutaBackup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbRutaBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.txbRutaBackup.Location = new System.Drawing.Point(8, 43);
            this.txbRutaBackup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbRutaBackup.Name = "txbRutaBackup";
            this.txbRutaBackup.ReadOnly = true;
            this.txbRutaBackup.Size = new System.Drawing.Size(698, 39);
            this.txbRutaBackup.TabIndex = 4;
            this.txbRutaBackup.Tag = "0";
            // 
            // txbRutaDatos
            // 
            this.txbRutaDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txbRutaDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbRutaDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.txbRutaDatos.Location = new System.Drawing.Point(8, 43);
            this.txbRutaDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbRutaDatos.Name = "txbRutaDatos";
            this.txbRutaDatos.ReadOnly = true;
            this.txbRutaDatos.Size = new System.Drawing.Size(697, 39);
            this.txbRutaDatos.TabIndex = 1;
            this.txbRutaDatos.Tag = "0";
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
            this.labTitulo.Location = new System.Drawing.Point(188, 9);
            this.labTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Size = new System.Drawing.Size(410, 71);
            this.labTitulo.TabIndex = 17;
            this.labTitulo.Text = "CONFIGURACIÓN";
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
            this.btnRutaBackup.Location = new System.Drawing.Point(713, 42);
            this.btnRutaBackup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRutaBackup.Name = "btnRutaBackup";
            this.btnRutaBackup.Size = new System.Drawing.Size(40, 40);
            this.btnRutaBackup.TabIndex = 5;
            this.btnRutaBackup.UseCompatibleTextRendering = true;
            this.btnRutaBackup.UseVisualStyleBackColor = true;
            this.btnRutaBackup.Click += new System.EventHandler(this.btnRutaBackup_Click);
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
            this.btnRutaDatos.Location = new System.Drawing.Point(713, 43);
            this.btnRutaDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRutaDatos.Name = "btnRutaDatos";
            this.btnRutaDatos.Size = new System.Drawing.Size(40, 39);
            this.btnRutaDatos.TabIndex = 2;
            this.btnRutaDatos.UseCompatibleTextRendering = true;
            this.btnRutaDatos.UseVisualStyleBackColor = true;
            this.btnRutaDatos.Click += new System.EventHandler(this.btnRutaDatos_Click);
            // 
            // grbRutaDatos
            // 
            this.grbRutaDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbRutaDatos.BackgroundPanelImage = null;
            this.grbRutaDatos.Controls.Add(this.txbRutaDatos);
            this.grbRutaDatos.Controls.Add(this.btnRutaDatos);
            this.grbRutaDatos.DrawGroupBorder = true;
            this.grbRutaDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbRutaDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(233)))), ((int)(((byte)(212)))));
            this.grbRutaDatos.GroupBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(113)))), ((int)(((byte)(0)))));
            this.grbRutaDatos.GroupPanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.grbRutaDatos.GroupPanelShape = GroupBoxEx.GroupBoxEx.PanelType.Squared;
            this.grbRutaDatos.Location = new System.Drawing.Point(13, 116);
            this.grbRutaDatos.Name = "grbRutaDatos";
            this.grbRutaDatos.Size = new System.Drawing.Size(761, 89);
            this.grbRutaDatos.TabIndex = 18;
            this.grbRutaDatos.TabStop = false;
            this.grbRutaDatos.Text = "ARCHIVO PARA LA BASE DE DATOS";
            this.grbRutaDatos.TextBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.grbRutaDatos.TextBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            // 
            // grbRutaBackup
            // 
            this.grbRutaBackup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbRutaBackup.BackgroundPanelImage = null;
            this.grbRutaBackup.Controls.Add(this.txbRutaBackup);
            this.grbRutaBackup.Controls.Add(this.btnRutaBackup);
            this.grbRutaBackup.DrawGroupBorder = true;
            this.grbRutaBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbRutaBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(233)))), ((int)(((byte)(212)))));
            this.grbRutaBackup.GroupBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(113)))), ((int)(((byte)(0)))));
            this.grbRutaBackup.GroupPanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.grbRutaBackup.GroupPanelShape = GroupBoxEx.GroupBoxEx.PanelType.Squared;
            this.grbRutaBackup.Location = new System.Drawing.Point(12, 241);
            this.grbRutaBackup.Name = "grbRutaBackup";
            this.grbRutaBackup.Size = new System.Drawing.Size(761, 89);
            this.grbRutaBackup.TabIndex = 19;
            this.grbRutaBackup.TabStop = false;
            this.grbRutaBackup.Text = "CARPETA PARA BACKUPS";
            this.grbRutaBackup.TextBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.grbRutaBackup.TextBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            // 
            // grbIntervaloBackup
            // 
            this.grbIntervaloBackup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbIntervaloBackup.BackgroundPanelImage = null;
            this.grbIntervaloBackup.Controls.Add(this.nudIntervalo);
            this.grbIntervaloBackup.Controls.Add(this.rdbDias);
            this.grbIntervaloBackup.Controls.Add(this.rdbMinutos);
            this.grbIntervaloBackup.Controls.Add(this.rdbHoras);
            this.grbIntervaloBackup.DrawGroupBorder = true;
            this.grbIntervaloBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbIntervaloBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(233)))), ((int)(((byte)(212)))));
            this.grbIntervaloBackup.GroupBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(113)))), ((int)(((byte)(0)))));
            this.grbIntervaloBackup.GroupPanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.grbIntervaloBackup.GroupPanelShape = GroupBoxEx.GroupBoxEx.PanelType.Squared;
            this.grbIntervaloBackup.Location = new System.Drawing.Point(12, 366);
            this.grbIntervaloBackup.Name = "grbIntervaloBackup";
            this.grbIntervaloBackup.Size = new System.Drawing.Size(761, 89);
            this.grbIntervaloBackup.TabIndex = 20;
            this.grbIntervaloBackup.TabStop = false;
            this.grbIntervaloBackup.Text = "INTERVALO DEL BACKUP";
            this.grbIntervaloBackup.TextBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.grbIntervaloBackup.TextBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            // 
            // frmInstall2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(153)))), ((int)(((byte)(2)))));
            this.ClientSize = new System.Drawing.Size(786, 566);
            this.Controls.Add(this.grbIntervaloBackup);
            this.Controls.Add(this.grbRutaBackup);
            this.Controls.Add(this.grbRutaDatos);
            this.Controls.Add(this.labTitulo);
            this.Controls.Add(this.btnSiguiente);
            this.Font = new System.Drawing.Font("CuprumFFU", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.MaximizeBox = false;
            this.Name = "frmInstall2";
            this.Text = "Configuración del entorno";
            this.Load += new System.EventHandler(this.frmInstall_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervalo)).EndInit();
            this.grbRutaDatos.ResumeLayout(false);
            this.grbRutaDatos.PerformLayout();
            this.grbRutaBackup.ResumeLayout(false);
            this.grbRutaBackup.PerformLayout();
            this.grbIntervaloBackup.ResumeLayout(false);
            this.grbIntervaloBackup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nudIntervalo;
        private System.Windows.Forms.RadioButton rdbDias;
        private System.Windows.Forms.RadioButton rdbHoras;
        private System.Windows.Forms.RadioButton rdbMinutos;
        private System.Windows.Forms.Button btnRutaBackup;
        private System.Windows.Forms.TextBox txbRutaBackup;
        private System.Windows.Forms.TextBox txbRutaDatos;
        private System.Windows.Forms.Button btnRutaDatos;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label labTitulo;
        private GroupBoxEx.GroupBoxEx grbIntervaloBackup;
        private GroupBoxEx.GroupBoxEx grbRutaBackup;
        private GroupBoxEx.GroupBoxEx grbRutaDatos;
    }
}