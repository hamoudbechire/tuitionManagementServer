using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.IO;
using EntityLayer;

namespace BusinessLayer
{
    public class DatabaseConnection
    {
        //private static object log;

        public static string Directory { get { return DataLayer.DatabaseConnection.Directory; } }
        public static string DbName { get { return DataLayer.DatabaseConnection.DbName; } }

        public static DatabaseConnectionMode Mode
        {
            get
            {
                return DataLayer.DatabaseConnection.Mode;
            }
        }
        private static string _baseDir
        {
            get
            {
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                if (!baseDir.EndsWith("\\"))
                    baseDir += "\\";
                return baseDir;
            }
        }
        private static string _dbSettingFile { get { return _baseDir + "DatabaseSettings.txt"; } }

        public object ConfigurationManager { get; private set; }

        private static void ReadDbSettings(ref string directory, ref string dbname)
        {
            //Open the stream and read it back.
            using (StreamReader sr = new StreamReader(_dbSettingFile))
            {
                string line = "";
                if ((line = sr.ReadLine()) != null)
                {
                    directory = line;
                }
                if ((line = sr.ReadLine()) != null)
                {
                    dbname = line;
                }
            }
        }

        private static void WriteDbSettings(string directory, string dbname)
        {
            // Delete the file if it exists.
            if (File.Exists(_dbSettingFile))
            {
                File.Delete(_dbSettingFile);
            }
            //Create the file.
            using (StreamWriter sw = new StreamWriter(_dbSettingFile))
            {
                sw.WriteLine(directory);
                sw.WriteLine(dbname);
            }
        }
        public static bool CreateIfNotExists()
        {

            return DataLayer.DatabaseConnection.CreateIfNotExists();


        }
        public static bool TestConnection()
        {
            if (DataLayer.DatabaseConnection.Mode == DatabaseConnectionMode.LocalDb && (string.IsNullOrWhiteSpace(Directory) || string.IsNullOrWhiteSpace(DbName)))
            {
                string dirName = _baseDir;
                string dbName = "Database";
                if (File.Exists(_dbSettingFile))
                    ReadDbSettings(ref dirName, ref dbName);
                ChangeDatabase(dirName, dbName);
            }
            return DataLayer.DatabaseConnection.Test();
        }
        public static bool ChangeDatabase(string directory, string database)
        {
            if (DataLayer.DatabaseConnection.InitializeConnection(directory, database))
            {
                WriteDbSettings(directory, database);
                return true;
            }
            return false;
        }

        public static bool CreateDatabase(string directory, string database)
        {
            if (DataLayer.DatabaseConnection.CreateDatabase(directory, database))
            {
                WriteDbSettings(directory, database);
                return true;
            }
            return false;
        }


    }
}
