using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TEPEUVE.Formularios;
using TEPEUVE.Modelos;

namespace TEPEUVE
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            /*if (!BaseDeDatos.ComprobarExistencia())
            { */
            frmInstall1 instalacion = new frmInstall1();
            instalacion.ShowDialog();
            //}
            InitializeComponent();
        }
    }
}
