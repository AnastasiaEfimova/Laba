namespace MainProject
{
    partial class InputDriverForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbYear = new System.Windows.Forms.TextBox();
            this.lbYear = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.lbNumber = new System.Windows.Forms.Label();
            this.tbAutoType = new System.Windows.Forms.TextBox();
            this.lbAutoType = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.lbModel = new System.Windows.Forms.Label();
            this.tbLicenseType = new System.Windows.Forms.TextBox();
            this.lbLicenseType = new System.Windows.Forms.Label();
            this.tbFio = new System.Windows.Forms.TextBox();
            this.lbFio = new System.Windows.Forms.Label();
            this.btAction = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(14, 255);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(258, 20);
            this.tbYear.TabIndex = 30;
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(11, 239);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(25, 13);
            this.lbYear.TabIndex = 29;
            this.lbYear.Text = "Год";
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(14, 206);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(258, 20);
            this.tbNumber.TabIndex = 28;
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Location = new System.Drawing.Point(11, 190);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(67, 13);
            this.lbNumber.TabIndex = 27;
            this.lbNumber.Text = "Номер авто";
            // 
            // tbAutoType
            // 
            this.tbAutoType.Location = new System.Drawing.Point(14, 158);
            this.tbAutoType.Name = "tbAutoType";
            this.tbAutoType.Size = new System.Drawing.Size(258, 20);
            this.tbAutoType.TabIndex = 26;
            // 
            // lbAutoType
            // 
            this.lbAutoType.AutoSize = true;
            this.lbAutoType.Location = new System.Drawing.Point(11, 142);
            this.lbAutoType.Name = "lbAutoType";
            this.lbAutoType.Size = new System.Drawing.Size(206, 13);
            this.lbAutoType.TabIndex = 25;
            this.lbAutoType.Text = "Тип авто (легковой, грузовой, автобус)";
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(14, 111);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(258, 20);
            this.tbModel.TabIndex = 24;
            // 
            // lbModel
            // 
            this.lbModel.AutoSize = true;
            this.lbModel.Location = new System.Drawing.Point(11, 95);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(46, 13);
            this.lbModel.TabIndex = 23;
            this.lbModel.Text = "Модель";
            this.lbModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbLicenseType
            // 
            this.tbLicenseType.Location = new System.Drawing.Point(14, 68);
            this.tbLicenseType.Name = "tbLicenseType";
            this.tbLicenseType.Size = new System.Drawing.Size(258, 20);
            this.tbLicenseType.TabIndex = 22;
            // 
            // lbLicenseType
            // 
            this.lbLicenseType.AutoSize = true;
            this.lbLicenseType.Location = new System.Drawing.Point(11, 52);
            this.lbLicenseType.Name = "lbLicenseType";
            this.lbLicenseType.Size = new System.Drawing.Size(116, 13);
            this.lbLicenseType.TabIndex = 21;
            this.lbLicenseType.Text = "Тип лицензии(A, B, C)";
            // 
            // tbFio
            // 
            this.tbFio.Location = new System.Drawing.Point(14, 21);
            this.tbFio.Name = "tbFio";
            this.tbFio.Size = new System.Drawing.Size(258, 20);
            this.tbFio.TabIndex = 20;
            // 
            // lbFio
            // 
            this.lbFio.AutoSize = true;
            this.lbFio.Location = new System.Drawing.Point(11, 5);
            this.lbFio.Name = "lbFio";
            this.lbFio.Size = new System.Drawing.Size(34, 13);
            this.lbFio.TabIndex = 19;
            this.lbFio.Text = "ФИО";
            // 
            // btAction
            // 
            this.btAction.Location = new System.Drawing.Point(14, 281);
            this.btAction.Name = "btAction";
            this.btAction.Size = new System.Drawing.Size(126, 55);
            this.btAction.TabIndex = 18;
            this.btAction.Text = "Добавить";
            this.btAction.UseVisualStyleBackColor = true;
            this.btAction.Click += new System.EventHandler(this.BtAction_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(148, 281);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(126, 55);
            this.btCancel.TabIndex = 17;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // InputDriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 341);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.lbNumber);
            this.Controls.Add(this.tbAutoType);
            this.Controls.Add(this.lbAutoType);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.lbModel);
            this.Controls.Add(this.tbLicenseType);
            this.Controls.Add(this.lbLicenseType);
            this.Controls.Add(this.tbFio);
            this.Controls.Add(this.lbFio);
            this.Controls.Add(this.btAction);
            this.Controls.Add(this.btCancel);
            this.Name = "InputDriverForm";
            this.Text = "Ввод водителя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.TextBox tbAutoType;
        private System.Windows.Forms.Label lbAutoType;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label lbModel;
        private System.Windows.Forms.TextBox tbLicenseType;
        private System.Windows.Forms.Label lbLicenseType;
        private System.Windows.Forms.TextBox tbFio;
        private System.Windows.Forms.Label lbFio;
        private System.Windows.Forms.Button btAction;
        private System.Windows.Forms.Button btCancel;
    }
}