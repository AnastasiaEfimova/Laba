using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MainProject.Files
{
    class XmlFileManager : IFileManager
    {
        public List<Driver> drivers { get; set; }
        public XmlFileManager(List<Driver> drivers)
        {
            this.drivers = drivers;
        }
        public bool Load(string filepath)
        {
            try
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<Driver>));
                using (FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate))
                {
                    drivers = (List<Driver>)formatter.Deserialize(fs);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Save(string filepath)
        {
            try
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<Driver>));
                using (FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, drivers);
                }
                return true;
            } catch
            {
                return false;
            }
        }
    }
}
