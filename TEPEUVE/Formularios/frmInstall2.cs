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
    public partial class frmInstall2 : Form
    {
        //Este objeto corresponde a las operaciones y conexiones con la base de datos local (sqlite).
        private BaseDeDatos db;
        //Esta variable recoge el intervalo D,H,M (Dias, Horas y Minutos).
        char intervalo;

        //Constructor inicial
        public frmInstall2()
        {
            InitializeComponent();
        }
    }
}
