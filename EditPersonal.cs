using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class EditPersonal : Form
    {
        private bool edit; //true - изменение, false - добавление
        private Personal personal;
        public EditPersonal()//Метод для добавления сотрудника
        {
            StartInitialize();
        }
        public EditPersonal(Personal personal, string login, string password)
        {
            StartInitialize();
            InitializeForUpdatePersonal(personal, login, password);
            edit = true;
        }

        //Начальная инициализация
        private void StartInitialize()
        {
            InitializeComponent();
            GetPharmacy();
            rolePharmacist.Checked = true;
            edit = false;
            hourWorksLabel.Visible = false;
            hourWorksTextBox.Visible = false;
            prizeLabel.Visible = false;
            prizeTextBox.Visible = false;
            SetSettings();
        }

        //Начальные настройки
        private void SetSettings()
        {
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        //Инициаизация при обновлении данных о сотруднике
        private void InitializeForUpdatePersonal(Personal personal, string login, string password)
        {
            lastNameTextBox.Text = personal.lastName;
            firstNameTextBox.Text = personal.firstName;
            middleNameTextBox.Text = personal.middleName;
            callNumberTextBox.Text = personal.callNumber;
            loginTextBox.Text = login;
            passwordTextBox.Text = password;
            rateTextBox.Text = personal.rate.ToString();
            pharmacyComboBox.SelectedItem = personal.pharmacyId;
            CheckRolePersonal(personal.category);
            hourWorksLabel.Visible = true;
            hourWorksTextBox.Visible = true;
            prizeLabel.Visible = true;
            prizeTextBox.Visible = true;
            AOUBtn.Text = "Изменить данные";
            this.personal = personal;
        }

        //Получение данных о аптеках
        private void GetPharmacy()
        {
            string query = "SELECT pharmacyId FROM Pharmacy WHERE pharmacyId > 1";
            SqlCommand command = Info.sql.CreateCommand(query);
            Info.sql.ConnectionOpen();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    pharmacyComboBox.Items.Add(reader.GetByte(0));
                }
            }
            Info.sql.ConnectionClose();
        }
        //Добавление или обновление сотрудника
        private void AOUBtn_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                UpdatePersonal();
            }
            else
            {
                AddPersonal();
            }
        }

        //Метод добавления сотрудника
        private void AddPersonal()
        {
            if (checkTextBox())
            {
                Personal personal = new Personal(0, lastNameTextBox.Text, firstNameTextBox.Text, middleNameTextBox.Text, callNumberTextBox.Text, 0,
                    Convert.ToDecimal(rateTextBox.Text), 0, (byte)pharmacyComboBox.SelectedItem, GetRolePersonal());
                string errorMessage = personal.AddPersonal(loginTextBox.Text, passwordTextBox.Text).Item2;
                if (errorMessage == "")
                {
                    MessageBox.Show($"Добавлен сотрудник с Id: {personal.personalId}");
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
                OpenPersonalForm();
            }
        }

        //Метод обновления сотрудника
        private void UpdatePersonal()
        {
            if (checkTextBox())
            {
                (byte, string) personalUpdateOutput = personal.UpdatePersonal(lastNameTextBox.Text, firstNameTextBox.Text, middleNameTextBox.Text, callNumberTextBox.Text, Convert.ToByte(hourWorksTextBox.Text),
                   Convert.ToDecimal(rateTextBox.Text), Convert.ToDecimal(prizeTextBox.Text), Convert.ToByte(pharmacyComboBox.SelectedItem), GetRolePersonal(), loginTextBox.Text, passwordTextBox.Text);
                string errorMessage = personalUpdateOutput.Item2;
                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage);
                }
                else
                {
                    byte personalId = personalUpdateOutput.Item1;
                    MessageBox.Show($"Данные о сотруднике с ID: {personalId} были изменены");
                }
                OpenPersonalForm();
            }
        }

        //Метод открытия формы с персоналом
        private void OpenPersonalForm()
        {
            PersonalForm personalForm = new PersonalForm();
            //Вычисляю панель subMenuPanel, которая является родительской для текущей формы
            Panel subMenuPanel = (Panel)this.Parent;
            foreach (Control control in subMenuPanel.Controls)
            {
                control.Dispose();
            }
            subMenuPanel.Controls.Add(personalForm);
            subMenuPanel.Tag = personalForm;
            personalForm.BringToFront();
            personalForm.Show();
        }
        


        //Метод определения роли сотрудника
        private string GetRolePersonal()
        {
            string category = "";
            if (rolePharmacist.Checked)
            {
                category = "Аптекарь";
            }
            else if (roleAccountant.Checked)
            {
                category = "Бухгалтер";
            }
            else if (roleDirector.Checked)
            {
                category = "Руководитель";
            }
            return category;
        }
        //Метод отметки роли сотрудника(при изменении)
        private void CheckRolePersonal(string category)
        {
            switch (category)
            {
                case "Аптекарь":
                    rolePharmacist.Checked = true;
                    break;
                case "Бухгалтер":
                    roleAccountant.Checked = true;
                    break;
                case "Руководитель":
                    roleDirector.Checked = true;
                    break;
            }
        }
        //Метод проверки измененных данных
        private bool checkTextBox()
        {
            bool check = true;
            //Длина фамилии >0 и <20
            if (lastNameTextBox.Text.Length == 0 || lastNameTextBox.Text.Length >= 20)
            {
                check = false;
                errorLastNameLabel.Text = "Длина больше 20 символов или равна нулю";
            }
            else
            {
                errorLastNameLabel.Text = "";
            }
            //Длина имени >0 и <20
            if (firstNameTextBox.Text.Length == 0 || firstNameTextBox.Text.Length >= 20)
            {
                check = false;
                errorFirstNameLabel.Text = "Длина больше 20 символов или равна нулю";
            }
            else
            {
                errorFirstNameLabel.Text = "";
            }
            //Длина отчества >0 и <20
            if (middleNameTextBox.Text.Length == 0 || middleNameTextBox.Text.Length >= 20)
            {
                check = false;
                errorMiddleNameLabel.Text = "Длина больше 20 символов или равна нулю";
            }
            else
            {
                errorMiddleNameLabel.Text = "";
            }
            //Проверка телефона
            Regex regex = new Regex(@"^\+7( )?[0-9]{3}-?[0-9]{3}-?[0-9]{2}-?[0-9]{2}$");
            MatchCollection matches = regex.Matches(callNumberTextBox.Text);
            if (matches.Count == 0)
            {
                check = false;
                errorCallNumberLabel.Text = "Неверный телефон";
            }
            else
            {
                errorCallNumberLabel.Text = "";
            }

            errorLoginLabel.Text = "";
            errorPasswordLabel.Text = "";

            //Длина логина >0 и <20 и только латинские буквы
            regex = new Regex(@"^([a-zA-Z]?[0-9]?)+$");
            matches = regex.Matches(loginTextBox.Text);
            if (matches.Count == 0)
            {
                check = false;
                errorLoginLabel.Text = "Используйте только цифры и латинские символы";
            }
            else if (loginTextBox.Text.Length == 0 || loginTextBox.Text.Length >= 20)
            {
                check = false;
                errorLoginLabel.Text = "Длина больше 20 символов или равна нулю";
            }

            //Длина пароля >0 и <20 и только латинские буквы
            regex = new Regex(@"^([a-zA-Z]?[0-9]?)+$");
            matches = regex.Matches(passwordTextBox.Text);
            if (matches.Count == 0)
            {
                check = false;
                errorPasswordLabel.Text = "Используйте только цифры и латинские символы";
            }
            else if (passwordTextBox.Text.Length == 0 || passwordTextBox.Text.Length >= 20)
            {
                check = false;
                errorPasswordLabel.Text = "Длина больше 20 символов или равна нулю";
            }

            if (edit)
            {
                //Проверка времени работы на ввод цифр и количество цифр
                regex = new Regex(@"^[0-9]+$");
                matches = regex.Matches(hourWorksTextBox.Text);
                if (matches.Count == 0)
                {
                    check = false;
                    errorHourWorks.Text = "Не верное время работы";
                }
                else
                {
                    errorHourWorks.Text = "";
                }

                //Проверка премии на ввод цифр и количество цифр
                regex = new Regex(@"^[0-9]{1,5}(.[0-9][0-9]?)?$");
                matches = regex.Matches(prizeTextBox.Text);
                if (matches.Count == 0)
                {
                    check = false;
                    errorPrizeLabel.Text = "Неверный формат ввода премии";
                }
                else
                {
                    errorPrizeLabel.Text = "";
                }
            }
            
            //Проверка ставки на ввод цифр и количество цифр
            regex = new Regex(@"^[0-9]{1,4}(.[0-9][0-9]?)?$");
            matches = regex.Matches(rateTextBox.Text);
            if (matches.Count == 0)
            {
                check = false;
                errorRateLabel.Text = "Неверная цена";
            }
            else
            {
                errorRateLabel.Text = "";
            }





            //Возвращаем результат
            return check;
        }


    }
}
