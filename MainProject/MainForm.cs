using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MainProject.Driver;

namespace MainProject
{
    public partial class MainForm : Form
    {
        // Класс для работы с файлами
        FileManager fm = null;
        List<Driver> drivers;
        public MainForm()
        {
            InitializeComponent();
            dgv.TopLeftHeaderCell.Value = "№";
            drivers = new List<Driver>();
            fm = new FileManager(drivers);
        }
        public void UpdateDgv()
        {
            if (drivers.Count > 0)
            {
                dgv.DataSource = null;
                dgv.DataSource = drivers;
                dgv.Columns["fio"].HeaderText = "ФИО";
                dgv.Columns["licenseType"].HeaderText = "Лицензия";
                dgv.Columns["model"].HeaderText = "Модель";
                dgv.Columns["autoType"].HeaderText = "Тип авто";
                dgv.Columns["number"].HeaderText = "Номер";
                dgv.Columns["year"].HeaderText = "Год";
            } else
            {
                dgv.DataSource = null;
            }
        }
        private void BtAdd_Click(object sender, EventArgs e)
        {
            using (InputDriverForm inForm = new InputDriverForm())
            {
                if (inForm.ShowDialog() == DialogResult.OK)
                {
                    drivers.Add(inForm.driver);
                    UpdateDgv();
                }
            }
        }
        private void ChangeRow(DataGridViewRow row)
        {
            using (InputDriverForm inForm = new InputDriverForm((Driver)row.DataBoundItem))
            {
                inForm.EditOrFind();
                if (inForm.DialogResult == DialogResult.OK)
                {
                    drivers.Add(inForm.driver);
                    UpdateDgv();
                }
            }
        }
        private void Dgv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ChangeRow(dgv.SelectedRows[0]);
        }
        private void BtDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                drivers.Remove((Driver)dgv.SelectedRows[0].DataBoundItem);
                UpdateDgv();
            }
        }

        private void BtTask_Click(object sender, EventArgs e)
        {
            List<Driver> driverList = new List<Driver>();
            foreach (Driver driver in drivers)
            {
                if (((int)driver.licenseType) != ((int)driver.autoType))
                {
                    driverList.Add(driver);
                }
            }
            driverList.Sort(new MyComparer());

            if (driverList.Count > 0)
            {
                string message = "Водители, не имеющие права управлять своим ТС: \n";
                foreach (Driver driver in driverList)
                {
                    message += driver.fio + "\n";
                }
                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("Все водители имеют право управлять своим ТС");
                return;
            }
        }

        private void Dgv_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            stripLabel.Text = "Количество элементов: " + dgv.Rows.Count;
        }

        private void Dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            stripLabel.Text = "Количество элементов: " + dgv.Rows.Count;
        }

        private void MenuClear_Click(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
        }

        private void MenuCreate_Click(object sender, EventArgs e)
        {
            drivers.Clear();
            UpdateDgv();
        }

        private void MenuSave_Click(object sender, EventArgs e)
        {
            if (fm.Filepath != "")
            {
                fm.Save();
            }
            UpdateDgv();
        }

        private void BtEdit_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку");
                return;
            }
            int rowIndex = dgv.SelectedRows[0].Index;
            Driver driver = (Driver) dgv.SelectedRows[0].DataBoundItem;
            using (InputDriverForm inputBookForm = new InputDriverForm(driver))
            {
                inputBookForm.EditOrFind();
                if (inputBookForm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                driver = inputBookForm.driver;
                drivers.Add(driver);
                UpdateDgv();
            }
        }

        private void MenuOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fm.Filepath = openFileDialog.FileName;
                if (!fm.Load())
                {
                    MessageBox.Show("Не удалось загрузить файл");
                }
                UpdateDgv();
            }
        }

        private void MenuSaveAs_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fm.Filepath = saveFileDialog.FileName;
                if (!fm.Save())
                {
                    MessageBox.Show("Не удалось сохранить файл");
                }
                UpdateDgv();
            }
        }
    }
}
