using System;
using System.Data;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class PersonalForm : Form
    {
        public PersonalForm()
        {
            InitializeComponent();
            RefreshPersonalsData();
            SetSettings();
        }

        //Обновление данных данных о персонале по клику на картинку обновления
        private void refreshPictureBox_Click(object sender, EventArgs e)
        {
            RefreshPersonalsData();
        }

        //Начальные установки
        private void SetSettings()
        {
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        //Обновление данных о персонале
        private void RefreshPersonalsData()
        {
            string query = "SELECT * FROM v_personal";
            DataSet personalDataSet = Info.sql.CreateDataSet(query);
            personalDataGridView.DataSource = personalDataSet.Tables[0];
            personalDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        //Добавить сотрудника
        private void addPersonalBtn_Click(object sender, EventArgs e)
        {
            EditPersonal editPersonal = new EditPersonal();
            //Вычисляю панель subMenuPanel, которая является родительской для текущей формы
            Panel subMenuPanel = DisposeAndAddWindowsSubMenuPanel(editPersonal);
        }
        //Изменить данные о сотруднике
        private void changePersonlInfo_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection personalIdSelectedRow = personalDataGridView.SelectedRows;
            DataGridViewRow personalIdRow = personalIdSelectedRow[0];
            Personal personal = new Personal();
            personal.CreatePersonalById(Convert.ToByte(personalIdRow.Cells[0].Value));
            (string, string, string) loginAndPassword = personal.GetLoginAndPassword();
            string errorMessage = loginAndPassword.Item3;
            if (errorMessage != "")
            {
                MessageBox.Show("Не удалось получить данные о логине и пароле\nОбратитесь к специалисту");
            }
            else
            {
                string login = loginAndPassword.Item1;
                string password = loginAndPassword.Item2;
                EditPersonal editPersonal = new EditPersonal(personal, login, password);
                //Вычисляю панель subMenuPanel, которая является родительской для текущей формы
                Panel subMenuPanel = DisposeAndAddWindowsSubMenuPanel(editPersonal);
            }

            
        }
        //Уволить сотрудника
        private void dismissPersonal_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection personalIdSelectedRow = personalDataGridView.SelectedRows;
            string errorMessage = "";
            foreach (DataGridViewRow personalIdRow in personalIdSelectedRow)
            {
                DataGridViewCell personalIdCell = personalIdRow.Cells[0];
                if (personalIdCell.Value != DBNull.Value)
                {
                    byte personalId = Convert.ToByte(personalIdCell.Value);
                    errorMessage = Info.personal.DismissPersonal(personalId);
                    if (errorMessage != "")
                    {
                        MessageBox.Show(errorMessage);
                    }
                }
            }
            RefreshPersonalsData();
        }
        //Выплатить зарплату сотруднику
        private void salaryPerson_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection personalIdSelectedRow = personalDataGridView.SelectedRows;
            string errorMessage = "";
            DataGridViewRow personalIdRow = personalIdSelectedRow[0];
            DataGridViewCell personalIdCell = personalIdRow.Cells[0];
            if (personalIdCell.Value != DBNull.Value)
            {
                byte personalId = Convert.ToByte(personalIdCell.Value);
                (decimal, string) salaryAndError = Info.personal.GetSalary(personalId);
                errorMessage = salaryAndError.Item2;
                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage);
                }
                else
                {
                    decimal totalSalary = salaryAndError.Item1;
                    MessageBox.Show($"Сотруднику с ID {personalId} переведено {totalSalary}р");
                    RefreshPersonalsData();
                }
            }
        }
        //При изменение выбранного сотрудника
        private void personalDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection personalIdSelectedRow = ((DataGridView)sender).SelectedRows;
            bool check = true;
            foreach (DataGridViewRow personalIdRow in personalIdSelectedRow)
            {
                DataGridViewCell personalIdCell = personalIdRow.Cells[0];
                if (personalIdCell.Value != DBNull.Value)
                {
                    byte personalId = Convert.ToByte(personalIdCell.Value);
                    if (personalId == Info.personal.personalId)
                    {
                        check = false;
                    }
                    
                }
            }
            dismissPersonal.Enabled = check;
            changePersonlInfo.Enabled = check;
        }
        
        //Метод очистки subMenuPanel и добавления нового окна в панель
        private Panel DisposeAndAddWindowsSubMenuPanel(EditPersonal editPersonal)
        {
            //Вычисляю панель subMenuPanel, которая является родительской для текущей формы
            Panel subMenuPanel = (Panel)this.Parent;
            foreach (Control control in subMenuPanel.Controls)
            {
                control.Dispose();
            }
            subMenuPanel.Controls.Add(editPersonal);
            subMenuPanel.Tag = editPersonal;
            editPersonal.BringToFront();
            editPersonal.Show();
            return subMenuPanel;
        }
    }
}
