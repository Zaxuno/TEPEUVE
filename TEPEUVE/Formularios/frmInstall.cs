using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TEPEUVE.Modelos;
using TEPEUVE.Properties;

namespace TEPEUVE.Formularios
{
    public partial class frmInstall : Form
    {
        BaseDeDatos db;
        public frmInstall()
        {
            InitializeComponent();
        }

        private void btnRutaDatos_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = Dialogos.GuardarArchivoDB();
            if (sd.ShowDialog() == DialogResult.OK)
            {
                txbRutaDatos.Text = sd.FileName;
            }
        }

        private void btnRutaBackup_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = Dialogos.GuardarArchivoBackup();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                txbRutaBackup.Text = fd.SelectedPath;
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            char intervalo = 'D';
            if (rdbMinutos.Checked) intervalo = 'M';
            else if (rdbHoras.Checked) intervalo = 'H';
            else if (rdbDias.Checked) intervalo = 'D';

            Settings.Default.rutaDB = txbRutaDatos.Text;
            Settings.Default.rutaBackup = txbRutaBackup.Text;
            Settings.Default.intervalo = Convert.ToInt16(nudIntervalo.Text);
            Settings.Default.intervaloTipo = intervalo;
            Settings.Default.Save();

            tabPaso1.Parent = null;
            tabPaso2.Parent = tabControl;
            /* db = new BaseDeDatos(txbRutaDatos.Text, txbRutaBackup.Text);
             db.Abrir();

             db.Crear("config", "rutaDB VARCHAR(255) NOT NULL PRIMARY KEY,rutaBackup VARCHAR(255) NOT NULL,intervalo INTEGER DEFAULT 1,tipoIntervalo CHAR DEFAULT 'D'");

             db.Cerrar();*/
        }

        private void frmInstall_Load(object sender, EventArgs e)
        {
            tabPaso2.Parent = null;

            if (Settings.Default.rutaDB.Length > 0)
                txbRutaDatos.Text = Settings.Default.rutaDB;

            if (Settings.Default.rutaBackup.Length > 0)
                txbRutaBackup.Text = Settings.Default.rutaBackup;

            nudIntervalo.Text = Settings.Default.intervalo.ToString();

            if (Settings.Default.intervaloTipo == 'M') rdbMinutos.Checked = true;
            else if (Settings.Default.intervaloTipo == 'H') rdbHoras.Checked = true;
            else rdbDias.Checked = true;

        }
    }
}
