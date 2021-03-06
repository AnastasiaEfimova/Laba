﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainProject.Files
{
    class BinaryFileManager : IFileManager
    {
        public List<Driver> drivers { get; set; }
        public BinaryFileManager(List<Driver> drivers)
        {
            this.drivers = drivers;
        }
        public bool Load(string filepath)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                List<object> objList = null;
                using (FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate))
                {
                    drivers = (List<Driver>)formatter.Deserialize(fs);
                }
                return true;
            } catch
            {
                return false;
            }

            
        }

        public bool Save(string filepath)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, drivers);
                }
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
