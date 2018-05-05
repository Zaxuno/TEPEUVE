using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TEPEUVE.Modelos
{
    class Dialogos
    {

        public static SaveFileDialog GuardarArchivoDB()
        {
            SaveFileDialog dialogoGuardado = new SaveFileDialog();
            dialogoGuardado.Filter = "SQLite|*.db";
            dialogoGuardado.DefaultExt = ".db";
            dialogoGuardado.AddExtension = true;
            return dialogoGuardado;
        }


        public static FolderBrowserDialog GuardarArchivoBackup()
        {
            FolderBrowserDialog dialogoGuardado = new FolderBrowserDialog();
            return dialogoGuardado;
        }
    }
}
