using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    [Serializable]
    public enum LicenseType { A, B, C, Null = -1 }
    [Serializable]
    public enum AutoType { Passanger, Truck, Bus, Null = -1 }
    public class EnumUtils
    {
        public static AutoType StringToAutoType(string autoType)
        {
            autoType = autoType.Trim();
            if (autoType.ToLower() == "легковой")
            {
                return AutoType.Passanger;
            }
            if (autoType.ToLower() == "грузовой")
            {
                return AutoType.Truck;
            }
            if (autoType.ToLower() == "автобус")
            {
                return AutoType.Bus;
            }
            return AutoType.Null;
        }
        public static string AutoTypeToString(AutoType autoType)
        {
            if (autoType == AutoType.Passanger)
            {
                return "Легковой";
            }
            if (autoType == AutoType.Truck)
            {
                return "Грузовой";
            }
            if (autoType == AutoType.Bus)
            {
                return "Автобус";
            }
            return "Неизвестно";
        }

        public static LicenseType StringToLicenseType(string licenseType)
        {
            licenseType = licenseType.Trim();
            if (licenseType.ToLower() == "a")
            {
                return LicenseType.A;
            }
            if (licenseType.ToLower() == "b")
            {
                return LicenseType.B;
            }
            if (licenseType.ToLower() == "c")
            {
                return LicenseType.C;
            }
            return LicenseType.Null;
        }
        public static string LicenseTypeToString(LicenseType licenseType)
        {
            if (licenseType == LicenseType.A)
            {
                return "A";
            }
            if (licenseType == LicenseType.B)
            {
                return "B";
            }
            if (licenseType == LicenseType.C)
            {
                return "C";
            }
            return "Неизвестно";
        }
    }
}
