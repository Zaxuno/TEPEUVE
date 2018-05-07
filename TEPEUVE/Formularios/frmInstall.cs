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

//Esta clase corresponde al formulario de configuración para cuando se ejecuta el programa por primera vez.
namespace TEPEUVE.Formularios
{
    public partial class frmInstall : Form
    {
        //Este objeto corresponde a las operaciones y conexiones con la base de datos local (sqlite).
        private BaseDeDatos db;
        //Esta variable recoge el intervalo D,H,M (Dias, Horas y Minutos).
        char intervalo;

        //Constructor inicial
        public frmInstall()
        {
            InitializeComponent();
        }

        //Este evento se ejecuta cuando se hace click en el icono de la carpeta de la ruta de la base de datos.
        private void btnRutaDatos_Click(object sender, EventArgs e)
        {
            //Ejecutamos de la clase Dialogos el metodo GuardarArchivoDB() que devolverá un SaveFileDialog.
            SaveFileDialog sd = Dialogos.GuardarArchivoDB();

            //Cuando el usuario halla seleccionado la ruta la escribimos en el TextBox correspondiente.
            if (sd.ShowDialog() == DialogResult.OK) txbRutaDatos.Text = sd.FileName;
        }

        //Este evento se ejecuta cuando se hace click en el icono de la carpeta de la ruta para los backups.
        private void btnRutaBackup_Click(object sender, EventArgs e)
        {
            //Ejecutamos de la clase Dialogos el metodo GuardarArchivoBackup() que devolverá un FolderBrowserDialog.
            FolderBrowserDialog fd = Dialogos.GuardarArchivoBackup();

            //Cuando el usuario halla seleccionado la ruta la escribimos en el TextBox correspondiente.
            if (fd.ShowDialog() == DialogResult.OK) txbRutaBackup.Text = fd.SelectedPath;
        }

        //Este evento se ejecuta cuando se hace click en el botón de Siguiente.
        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            obtenerIntervalo();                                                 //Establecemos el intervalo
            guardarDatos();                                                     //Guardamos los datos en la configuración
            avanzarTab(tabPaso2);                                               //Avanzamos a la siguiente TAB
            db = new BaseDeDatos(txbRutaDatos.Text, txbRutaBackup.Text);        //Creamos en instalamos la base de datos
            db.InstalarNueva();

        }

        //Este método facilita el paso de página, recibe la nueva TabPage
        private void avanzarTab(TabPage pagina)
        {
            TabPage tp = tabControl.SelectedTab;        //Recuperamos la tab actual
            tp.Parent = null;                           //La hacemos desaparecer
            pagina.Parent = tabControl;                 //Avanzamos a la tab indicada
        }

        //Este método recoge las instrucciones para escribir en la configuración
        private void guardarDatos()
        {
            Settings.Default.rutaDB = txbRutaDatos.Text;                        //Escribimos la ruta del archivo sqlite
            Settings.Default.rutaBackup = txbRutaBackup.Text;                   //Escribimos la ruta del directorio para los backups
            Settings.Default.intervalo = Convert.ToInt16(nudIntervalo.Text);    //Establecemos el tiempo de intervalo
            Settings.Default.intervaloTipo = intervalo;                         //Establecemos el tipo de intervalo
            Settings.Default.Save();                                            //Guardamos los cambios
        }

        //Este método se encarga de almacenar el tipo de intervalo seleccionado
        private void obtenerIntervalo()
        {
            if (rdbMinutos.Checked) intervalo = 'M';
            else if (rdbHoras.Checked) intervalo = 'H';
            else intervalo = 'D';
        }

        //Este evento se produce cuando se carga el formulario
        private void frmInstall_Load(object sender, EventArgs e)
        {
            //Ocultamos los pasos siguientes
            tabPaso2.Parent = null;

            //En caso de existir datos en la configuración se cargan en el formulario
            if (Settings.Default.rutaDB.Length > 0) txbRutaDatos.Text = Settings.Default.rutaDB;
            if (Settings.Default.rutaBackup.Length > 0) txbRutaBackup.Text = Settings.Default.rutaBackup;
            nudIntervalo.Text = Settings.Default.intervalo.ToString();

            //Aquí marcamos el radiobutton correspondiente al tipo de intervalo guardado en la configuración
            if (Settings.Default.intervaloTipo == 'M') rdbMinutos.Checked = true;
            else if (Settings.Default.intervaloTipo == 'H') rdbHoras.Checked = true;
            else rdbDias.Checked = true;

        }
    }
}
