using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainProject.Files
{
    public class TextFileManager : IFileManager
    {
        public List<Driver> drivers { get; set; }
        public TextFileManager(List<Driver> drivers)
        {
            this.drivers = drivers;
        }
        public bool Load(string filepath)
        {
            drivers.Clear();
            try
            {
                using (StreamReader sr = new StreamReader(filepath, Encoding.UTF8))
                {
                    while (!sr.EndOfStream)
                    {
                        Driver driver = new Driver();
                        string line;
                        line = sr.ReadLine();
                        line = line.Substring(line.IndexOf(":") + 1).Trim();
                        driver.fio = line;

                        line = sr.ReadLine();
                        line = line.Substring(line.IndexOf(":") + 1).Trim();
                        driver.licenseType = EnumUtils.StringToLicenseType(line);

                        line = sr.ReadLine();
                        line = line.Substring(line.IndexOf(":") + 1).Trim();
                        driver.model = line;

                        line = sr.ReadLine();
                        line = line.Substring(line.IndexOf(":") + 1).Trim();
                        driver.autoType = EnumUtils.StringToAutoType(line);

                        line = sr.ReadLine();
                        line = line.Substring(line.IndexOf(":") + 1).Trim();
                        driver.number = line;

                        line = sr.ReadLine();
                        line = line.Substring(line.IndexOf(":") + 1).Trim();
                        if (YearUtils.IsCorrectYear(line))
                        {
                            driver.year = Int32.Parse(line);
                        } else
                        {
                            throw new Exception();
                        }
                        drivers.Add(driver);
                    }
                }
            } catch
            {
                return false;
            }

            return true;
        }

        public bool Save(string filepath)
        {
            using (StreamWriter sw = new StreamWriter(filepath, false, Encoding.UTF8))
            {
                foreach (Driver driver in drivers)
                {
                    sw.WriteLine("ФИО: " + driver.fio);
                    sw.WriteLine("Лицензия: " + EnumUtils.LicenseTypeToString(driver.licenseType));
                    sw.WriteLine("Модель: " + driver.model);
                    sw.WriteLine("Тип авто: " + EnumUtils.AutoTypeToString(driver.autoType));
                    sw.WriteLine("Номер: " + driver.number);
                    sw.WriteLine("Год: " + driver.year);
                }
            }
            return true;
        }
    }
}
