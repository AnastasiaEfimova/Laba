using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainProject
{
    [Serializable]
    public class Driver
    {
        public string fio { get; set; }
        public LicenseType licenseType { get; set; }
        public string model { get; set; }
        public AutoType autoType { get; set; }
        public string number { get; set; }
        public int year { get; set; }

        public Driver()
        {}
        public Driver(string fio, LicenseType licenseType, string model, AutoType autoType, string number, int year)
        {
            this.fio = fio;
            this.licenseType = licenseType;
            this.model = model;
            this.autoType = autoType;
            this.number = number;
            this.year = year;
        }

        public class MyComparer : IComparer<Driver>
        {
            public int Compare(Driver x, Driver y)
            {
                return x.fio.ToUpper().CompareTo(y.fio.ToUpper());
            }
        }
    }
}
