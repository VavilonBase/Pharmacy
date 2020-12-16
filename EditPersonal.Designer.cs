namespace Pharmacy
{
    partial class EditPersonal
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
            this.AOUBtn = new System.Windows.Forms.Button();
            this.pharmacyLabel = new System.Windows.Forms.Label();
            this.rateLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.callNumberLabel = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.rolePharmacist = new System.Windows.Forms.RadioButton();
            this.roleAccountant = new System.Windows.Forms.RadioButton();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.rateTextBox = new System.Windows.Forms.TextBox();
            this.callNumberTextBox = new System.Windows.Forms.TextBox();
            this.roleDirector = new System.Windows.Forms.RadioButton();
            this.errorLastNameLabel = new System.Windows.Forms.Label();
            this.errorFirstNameLabel = new System.Windows.Forms.Label();
            this.errorMiddleNameLabel = new System.Windows.Forms.Label();
            this.errorCallNumberLabel = new System.Windows.Forms.Label();
            this.errorLoginLabel = new System.Windows.Forms.Label();
            this.errorPasswordLabel = new System.Windows.Forms.Label();
            this.errorRateLabel = new System.Windows.Forms.Label();
            this.errorPharmacyLabel = new System.Windows.Forms.Label();
            this.pharmacyComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hourWorksTextBox = new System.Windows.Forms.TextBox();
            this.hourWorksLabel = new System.Windows.Forms.Label();
            this.prizeTextBox = new System.Windows.Forms.TextBox();
            this.prizeLabel = new System.Windows.Forms.Label();
            this.errorHourWorks = new System.Windows.Forms.Label();
            this.errorPrizeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AOUBtn
            // 
            this.AOUBtn.Location = new System.Drawing.Point(576, 409);
            this.AOUBtn.Name = "AOUBtn";
            this.AOUBtn.Size = new System.Drawing.Size(211, 29);
            this.AOUBtn.TabIndex = 57;
            this.AOUBtn.Text = "Добавить сотрудника";
            this.AOUBtn.UseVisualStyleBackColor = true;
            this.AOUBtn.Click += new System.EventHandler(this.AOUBtn_Click);
            // 
            // pharmacyLabel
            // 
            this.pharmacyLabel.AutoSize = true;
            this.pharmacyLabel.Location = new System.Drawing.Point(14, 220);
            this.pharmacyLabel.Name = "pharmacyLabel";
            this.pharmacyLabel.Size = new System.Drawing.Size(55, 17);
            this.pharmacyLabel.TabIndex = 53;
            this.pharmacyLabel.Text = "Аптека";
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Location = new System.Drawing.Point(14, 192);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(225, 17);
            this.rateLabel.TabIndex = 51;
            this.rateLabel.Text = "Ставка(зарплата за час работы)";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(14, 164);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(331, 17);
            this.passwordLabel.TabIndex = 47;
            this.passwordLabel.Text = "Пароль(рекм.  Имя + Фамилия в транскриптции)";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(14, 132);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(321, 17);
            this.loginLabel.TabIndex = 45;
            this.loginLabel.Text = "Логин(рекм.  Фамилия + Имя в транскриптции)";
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Location = new System.Drawing.Point(14, 69);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(329, 17);
            this.middleNameLabel.TabIndex = 42;
            this.middleNameLabel.Text = "Отчество(не больше 20 и не меньше 1 символа)";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(14, 45);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(293, 17);
            this.firstNameLabel.TabIndex = 40;
            this.firstNameLabel.Text = "Имя(не больше 20 и не меньше 1 символа)";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(13, 18);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(328, 17);
            this.lastNameLabel.TabIndex = 38;
            this.lastNameLabel.Text = "Фамилия(не больше 20 и не меньше 1 символа)";
            // 
            // callNumberLabel
            // 
            this.callNumberLabel.AutoSize = true;
            this.callNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.callNumberLabel.Location = new System.Drawing.Point(12, 100);
            this.callNumberLabel.Name = "callNumberLabel";
            this.callNumberLabel.Size = new System.Drawing.Size(347, 15);
            this.callNumberLabel.TabIndex = 67;
            this.callNumberLabel.Text = "Номер телефона(+7XXXXXXXXXX или +7 XXX-XXX-XX-XX)";
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(14, 248);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(81, 17);
            this.roleLabel.TabIndex = 69;
            this.roleLabel.Text = "Должность";
            // 
            // rolePharmacist
            // 
            this.rolePharmacist.AutoSize = true;
            this.rolePharmacist.Location = new System.Drawing.Point(122, 248);
            this.rolePharmacist.Name = "rolePharmacist";
            this.rolePharmacist.Size = new System.Drawing.Size(91, 21);
            this.rolePharmacist.TabIndex = 70;
            this.rolePharmacist.TabStop = true;
            this.rolePharmacist.Text = "Аптекарь";
            this.rolePharmacist.UseVisualStyleBackColor = true;
            // 
            // roleAccountant
            // 
            this.roleAccountant.AutoSize = true;
            this.roleAccountant.Location = new System.Drawing.Point(238, 248);
            this.roleAccountant.Name = "roleAccountant";
            this.roleAccountant.Size = new System.Drawing.Size(95, 21);
            this.roleAccountant.TabIndex = 71;
            this.roleAccountant.TabStop = true;
            this.roleAccountant.Text = "Бухгалтер";
            this.roleAccountant.UseVisualStyleBackColor = true;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(432, 18);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(207, 22);
            this.lastNameTextBox.TabIndex = 39;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(432, 45);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(207, 22);
            this.firstNameTextBox.TabIndex = 41;
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Location = new System.Drawing.Point(432, 73);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(207, 22);
            this.middleNameTextBox.TabIndex = 43;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(432, 132);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(207, 22);
            this.loginTextBox.TabIndex = 46;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(432, 164);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(207, 22);
            this.passwordTextBox.TabIndex = 48;
            // 
            // rateTextBox
            // 
            this.rateTextBox.Location = new System.Drawing.Point(432, 192);
            this.rateTextBox.Name = "rateTextBox";
            this.rateTextBox.Size = new System.Drawing.Size(207, 22);
            this.rateTextBox.TabIndex = 52;
            // 
            // callNumberTextBox
            // 
            this.callNumberTextBox.Location = new System.Drawing.Point(432, 101);
            this.callNumberTextBox.Name = "callNumberTextBox";
            this.callNumberTextBox.Size = new System.Drawing.Size(207, 22);
            this.callNumberTextBox.TabIndex = 68;
            // 
            // roleDirector
            // 
            this.roleDirector.AutoSize = true;
            this.roleDirector.Location = new System.Drawing.Point(354, 248);
            this.roleDirector.Name = "roleDirector";
            this.roleDirector.Size = new System.Drawing.Size(94, 21);
            this.roleDirector.TabIndex = 72;
            this.roleDirector.TabStop = true;
            this.roleDirector.Text = "Директор";
            this.roleDirector.UseVisualStyleBackColor = true;
            // 
            // errorLastNameLabel
            // 
            this.errorLastNameLabel.AutoSize = true;
            this.errorLastNameLabel.Location = new System.Drawing.Point(646, 22);
            this.errorLastNameLabel.Name = "errorLastNameLabel";
            this.errorLastNameLabel.Size = new System.Drawing.Size(0, 17);
            this.errorLastNameLabel.TabIndex = 73;
            // 
            // errorFirstNameLabel
            // 
            this.errorFirstNameLabel.AutoSize = true;
            this.errorFirstNameLabel.Location = new System.Drawing.Point(646, 49);
            this.errorFirstNameLabel.Name = "errorFirstNameLabel";
            this.errorFirstNameLabel.Size = new System.Drawing.Size(0, 17);
            this.errorFirstNameLabel.TabIndex = 74;
            // 
            // errorMiddleNameLabel
            // 
            this.errorMiddleNameLabel.AutoSize = true;
            this.errorMiddleNameLabel.Location = new System.Drawing.Point(645, 76);
            this.errorMiddleNameLabel.Name = "errorMiddleNameLabel";
            this.errorMiddleNameLabel.Size = new System.Drawing.Size(0, 17);
            this.errorMiddleNameLabel.TabIndex = 75;
            // 
            // errorCallNumberLabel
            // 
            this.errorCallNumberLabel.AutoSize = true;
            this.errorCallNumberLabel.Location = new System.Drawing.Point(645, 104);
            this.errorCallNumberLabel.Name = "errorCallNumberLabel";
            this.errorCallNumberLabel.Size = new System.Drawing.Size(0, 17);
            this.errorCallNumberLabel.TabIndex = 76;
            // 
            // errorLoginLabel
            // 
            this.errorLoginLabel.AutoSize = true;
            this.errorLoginLabel.Location = new System.Drawing.Point(645, 135);
            this.errorLoginLabel.Name = "errorLoginLabel";
            this.errorLoginLabel.Size = new System.Drawing.Size(0, 17);
            this.errorLoginLabel.TabIndex = 77;
            // 
            // errorPasswordLabel
            // 
            this.errorPasswordLabel.AutoSize = true;
            this.errorPasswordLabel.Location = new System.Drawing.Point(645, 164);
            this.errorPasswordLabel.Name = "errorPasswordLabel";
            this.errorPasswordLabel.Size = new System.Drawing.Size(0, 17);
            this.errorPasswordLabel.TabIndex = 78;
            // 
            // errorRateLabel
            // 
            this.errorRateLabel.AutoSize = true;
            this.errorRateLabel.Location = new System.Drawing.Point(645, 195);
            this.errorRateLabel.Name = "errorRateLabel";
            this.errorRateLabel.Size = new System.Drawing.Size(0, 17);
            this.errorRateLabel.TabIndex = 79;
            // 
            // errorPharmacyLabel
            // 
            this.errorPharmacyLabel.AutoSize = true;
            this.errorPharmacyLabel.Location = new System.Drawing.Point(645, 220);
            this.errorPharmacyLabel.Name = "errorPharmacyLabel";
            this.errorPharmacyLabel.Size = new System.Drawing.Size(0, 17);
            this.errorPharmacyLabel.TabIndex = 80;
            // 
            // pharmacyComboBox
            // 
            this.pharmacyComboBox.FormattingEnabled = true;
            this.pharmacyComboBox.Location = new System.Drawing.Point(432, 220);
            this.pharmacyComboBox.Name = "pharmacyComboBox";
            this.pharmacyComboBox.Size = new System.Drawing.Size(207, 24);
            this.pharmacyComboBox.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(645, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 84;
            // 
            // hourWorksTextBox
            // 
            this.hourWorksTextBox.Location = new System.Drawing.Point(432, 285);
            this.hourWorksTextBox.Name = "hourWorksTextBox";
            this.hourWorksTextBox.Size = new System.Drawing.Size(207, 22);
            this.hourWorksTextBox.TabIndex = 83;
            // 
            // hourWorksLabel
            // 
            this.hourWorksLabel.AutoSize = true;
            this.hourWorksLabel.Location = new System.Drawing.Point(14, 285);
            this.hourWorksLabel.Name = "hourWorksLabel";
            this.hourWorksLabel.Size = new System.Drawing.Size(224, 17);
            this.hourWorksLabel.TabIndex = 82;
            this.hourWorksLabel.Text = "Время работы за месяц(в часах)";
            // 
            // prizeTextBox
            // 
            this.prizeTextBox.Location = new System.Drawing.Point(432, 313);
            this.prizeTextBox.Name = "prizeTextBox";
            this.prizeTextBox.Size = new System.Drawing.Size(207, 22);
            this.prizeTextBox.TabIndex = 86;
            // 
            // prizeLabel
            // 
            this.prizeLabel.AutoSize = true;
            this.prizeLabel.Location = new System.Drawing.Point(14, 313);
            this.prizeLabel.Name = "prizeLabel";
            this.prizeLabel.Size = new System.Drawing.Size(59, 17);
            this.prizeLabel.TabIndex = 85;
            this.prizeLabel.Text = "Премия";
            // 
            // errorHourWorks
            // 
            this.errorHourWorks.AutoSize = true;
            this.errorHourWorks.Location = new System.Drawing.Point(646, 289);
            this.errorHourWorks.Name = "errorHourWorks";
            this.errorHourWorks.Size = new System.Drawing.Size(0, 17);
            this.errorHourWorks.TabIndex = 87;
            // 
            // errorPrizeLabel
            // 
            this.errorPrizeLabel.AutoSize = true;
            this.errorPrizeLabel.Location = new System.Drawing.Point(646, 317);
            this.errorPrizeLabel.Name = "errorPrizeLabel";
            this.errorPrizeLabel.Size = new System.Drawing.Size(0, 17);
            this.errorPrizeLabel.TabIndex = 88;
            // 
            // EditPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorPrizeLabel);
            this.Controls.Add(this.errorHourWorks);
            this.Controls.Add(this.prizeTextBox);
            this.Controls.Add(this.prizeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hourWorksTextBox);
            this.Controls.Add(this.hourWorksLabel);
            this.Controls.Add(this.pharmacyComboBox);
            this.Controls.Add(this.errorPharmacyLabel);
            this.Controls.Add(this.errorRateLabel);
            this.Controls.Add(this.errorPasswordLabel);
            this.Controls.Add(this.errorLoginLabel);
            this.Controls.Add(this.errorCallNumberLabel);
            this.Controls.Add(this.errorMiddleNameLabel);
            this.Controls.Add(this.errorFirstNameLabel);
            this.Controls.Add(this.errorLastNameLabel);
            this.Controls.Add(this.roleDirector);
            this.Controls.Add(this.roleAccountant);
            this.Controls.Add(this.rolePharmacist);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.callNumberTextBox);
            this.Controls.Add(this.callNumberLabel);
            this.Controls.Add(this.AOUBtn);
            this.Controls.Add(this.pharmacyLabel);
            this.Controls.Add(this.rateTextBox);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(this.middleNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Name = "EditPersonal";
            this.Text = "EditPersonal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AOUBtn;
        private System.Windows.Forms.Label pharmacyLabel;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label middleNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label callNumberLabel;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.RadioButton rolePharmacist;
        private System.Windows.Forms.RadioButton roleAccountant;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox rateTextBox;
        private System.Windows.Forms.TextBox callNumberTextBox;
        private System.Windows.Forms.RadioButton roleDirector;
        private System.Windows.Forms.Label errorLastNameLabel;
        private System.Windows.Forms.Label errorFirstNameLabel;
        private System.Windows.Forms.Label errorMiddleNameLabel;
        private System.Windows.Forms.Label errorCallNumberLabel;
        private System.Windows.Forms.Label errorLoginLabel;
        private System.Windows.Forms.Label errorPasswordLabel;
        private System.Windows.Forms.Label errorRateLabel;
        private System.Windows.Forms.Label errorPharmacyLabel;
        private System.Windows.Forms.ComboBox pharmacyComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hourWorksTextBox;
        private System.Windows.Forms.Label hourWorksLabel;
        private System.Windows.Forms.TextBox prizeTextBox;
        private System.Windows.Forms.Label prizeLabel;
        private System.Windows.Forms.Label errorHourWorks;
        private System.Windows.Forms.Label errorPrizeLabel;
    }
}