﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TEPEUVE.Formularios;

namespace TEPEUVE
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            frmInstall instalacion = new frmInstall();
            instalacion.ShowDialog();
            InitializeComponent();
        }
    }
}
