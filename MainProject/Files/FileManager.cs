using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using MainProject.Files;

namespace MainProject
{
    class FileManager
    {
        private List<Driver> drivers;
        private string filepath;
        public string Filepath
        {
            get
            {
                return filepath;
            }
            set
            {
                filepath = value;
            }
        }

        public FileManager(List<Driver> drivers)
        {
            this.drivers = drivers;
        }
        private IFileManager GetFileManager(string ext)
        {
            if (ext == ".txt")
            {
                return new TextFileManager(drivers);
            }
            else if (ext == ".xml")
            {
                return new XmlFileManager(drivers);
            }
            else
            {
                return new BinaryFileManager(drivers);
            }
        }
        public bool Load()
        {
            if (filepath.IndexOf(".") == -1)
            {
                MessageBox.Show("Неподдерживаемое расширение файла. Поддерживаются bin, xml, txt");
                return false;
            }
            IFileManager fileManager = GetFileManager(Path.GetExtension(filepath));
            return fileManager.Load(filepath);
        }
        public bool Save()
        {
            if (filepath.IndexOf(".") == -1)
            {
                MessageBox.Show("Неподдерживаемое расширение файла. Поддерживаются bin, xml, txt");
                return false;
            }
            IFileManager fileManager = GetFileManager(Path.GetExtension(filepath));
            return fileManager.Save(filepath);
        }
    }
}
