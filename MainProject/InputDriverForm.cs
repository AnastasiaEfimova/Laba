using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainProject
{
    public partial class InputDriverForm : Form
    {
        public Driver driver = null;
        public InputDriverForm(Driver driver = null)
        {
            InitializeComponent();
            if (driver != null)
            {
                tbFio.Text = driver.fio;
                tbLicenseType.Text = EnumUtils.LicenseTypeToString(driver.licenseType);
                tbModel.Text = driver.model;
                tbAutoType.Text = EnumUtils.AutoTypeToString(driver.autoType);
                tbNumber.Text = driver.number;
                tbYear.Text = driver.year.ToString();
            }
        }

        public void EditOrFind()
        {
            btAction.Text = "Изменить";
        }

        private void BtAction_Click(object sender, EventArgs e)
        {
            if (tbFio.Text.Trim() == "")
            {
                MessageBox.Show("Введите ФИО");
                return;
            }
            if (tbModel.Text.Trim() == "")
            {
                MessageBox.Show("Введите модель");
                return;
            }
            if (tbNumber.Text.Trim() == "")
            {
                MessageBox.Show("Введите номер");
                return;
            }
            if (!YearUtils.IsCorrectYear(tbYear.Text))
            {
                MessageBox.Show("Введите корректный год");
                return;
            }
            driver = new Driver(tbFio.Text, EnumUtils.StringToLicenseType(tbLicenseType.Text), tbModel.Text, EnumUtils.StringToAutoType(tbAutoType.Text), tbNumber.Text, Int32.Parse(tbYear.Text));
            DialogResult = DialogResult.OK;
        }
    }
}
