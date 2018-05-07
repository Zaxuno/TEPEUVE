using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using TEPEUVE.Properties;

namespace TEPEUVE.Modelos
{
    class BaseDeDatos
    {
        String rutaDB;
        String rutaBackup;
        SQLiteConnection conexion;
        SQLiteCommand comando;

        public BaseDeDatos(String rutaDB, String rutaBackup)
        {
            this.rutaDB = rutaDB;
            this.rutaBackup = rutaBackup;
            conexion = new SQLiteConnection(@"Data Source=" + rutaDB);
        }

        public void InstalarNueva()
        {
            Abrir();
            Crear("empleados", "id VARCHAR(11) NOT NULL PRIMARY KEY,rutaBackup VARCHAR(255) NOT NULL,intervalo INTEGER DEFAULT 1,tipoIntervalo CHAR DEFAULT 'D'");
            Cerrar();
        }

        internal static bool ComprobarExistencia()
        {
            if (File.Exists(Settings.Default.rutaDB)) return true;
            return false;
        }

        public BaseDeDatos(String rutaDB)
        {
            this.rutaDB = rutaDB;
            conexion = new SQLiteConnection(@"Data Source=" + rutaDB);
        }
        public void Abrir()
        {
            conexion.Open();
            comando = new SQLiteCommand();
            comando.Connection = conexion;
        }

        public void Cerrar()
        {
            conexion.Close();
        }

        public void Ejecutar(String sentenciaSQL)
        {
            comando.CommandText = sentenciaSQL;
            comando.ExecuteNonQuery();
        }

        public void Crear(String tabla, String valores)
        {
            comando.CommandText = $@"CREATE TABLE IF NOT EXISTS {tabla} ({valores}) ";
            comando.ExecuteNonQuery();
        }

        public void Insertar(String tabla, String valores)
        {
            comando.CommandText = $@"INSERT INTO {tabla} VALUES ({valores}) ";
            comando.ExecuteNonQuery();
        }

        public void Insertar(String tabla, String columnas, String valores)
        {
            comando.CommandText = $@"INSERT INTO {tabla} ({columnas}) VALUES ({valores}) ";
            comando.ExecuteNonQuery();
        }

        public void Eliminar(String tabla, String where)
        {
            comando.CommandText = $"DELETE FROM {tabla} WHERE {where} ";
            comando.ExecuteNonQuery();
        }

        public List<StringBuilder> Obtener(String tabla, String columnas)
        {
            comando.CommandText = $"SELECT {columnas} FROM {tabla}";
            SQLiteDataReader dr = comando.ExecuteReader();
            StringBuilder sb = new StringBuilder();
            List<StringBuilder> listaDatos = new List<StringBuilder>();

            while (dr.Read())
            {
                for(int x = 0; x < dr.FieldCount;x++)
                    sb.Append(dr[x].ToString()+";");
                listaDatos.Add(sb);
            }
            return listaDatos;
        }

        public List<StringBuilder> Obtener(String tabla, String columnas, String where)
        {
            comando.CommandText = $"SELECT {columnas} FROM {tabla} WHERE {where}";
            SQLiteDataReader dr = comando.ExecuteReader();
            StringBuilder sb = new StringBuilder();
            List<StringBuilder> listaDatos = new List<StringBuilder>();

            while (dr.Read())
            {
                for (int x = 0; x < dr.FieldCount; x++)
                    sb.Append(dr[x].ToString() + ";");
                listaDatos.Add(sb);
            }
            return listaDatos;
        }

        public String Formatear(String original)
        {
            return original.Replace(":","-").Replace("\\", "$/");
        }
    }
}
