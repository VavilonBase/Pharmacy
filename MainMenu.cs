using System;
using System.Data;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            StartInitialize();
        }

        #region Начальная инициализация
        //Началья инициализация окна
        private void StartInitialize()
        {
            InitializeComponent();
            sideMenuPanel.Visible = false;
            rightArrowBtn.Visible = false;
            subMenuCatalog.Visible = false;
            RefreshIOETabControl();
            InitializeRolePersonal();
            InfoPerson();
        }

        //Вывод информации о работнике
        private void InfoPerson()
        {
            categoryLabel.Text = Info.personal.category;
            lastNameLabel.Text = "Фамилия: " + Info.personal.lastName;
            firstNameLabel.Text = "Имя: " + Info.personal.firstName;
            middleNameLabel.Text = "Отчество: " + Info.personal.middleName;
            hourWorksLabel.Text = "Время работы: " + Info.personal.hourWorks.ToString();
            rateLabel.Text = "Ставка: " + Info.personal.rate.ToString();
            prizeLabel.Text = "Премия: " + Info.personal.prize.ToString();
            pharmacyIdLabel.Text = "Аптека: " + Info.personal.pharmacyId.ToString();
        }

        //Вывод каталогов
        private void SubCatalogMenu()
        {
            subMenuCatalog.Controls.Clear();
            string query = "SELECT categoryName FROM Category";
            DataSet catalogs = Info.sql.CreateDataSet(query);
            for (int i = catalogs.Tables[0].Rows.Count - 1; i >= 0; i--)
            {
                Button btnCatalog = new Button();
                btnCatalog.Text = $"{(catalogs.Tables[0]).Rows[i][0].ToString()}";
                btnCatalog.Name = $"btnCatalog{i}";
                btnCatalog.Dock = DockStyle.Top;
                btnCatalog.Cursor = Cursors.Hand;
                btnCatalog.Click += new System.EventHandler(this.btnClick);
                subMenuCatalog.Controls.Add(btnCatalog);
            }
        }

        //Инициализация в зависимости от роли персонала
        private void InitializeRolePersonal()
        {
            if (Info.personal.isPharmacist)
            {
                personalBtn.Dispose();
            }
            else if (Info.personal.isAccountant)
            {

            }
            else if (Info.personal.isDirector)
            {

            }
        }
        #endregion

        #region Методы событий с формой
        //При закрытие главного окна
        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Открываем главную форму входа
            Form login = Application.OpenForms[0];
            login.Show();
        }

        //Открытие бокового меню
        private void menuPictureBtn_Click(object sender, EventArgs e)
        {
            if (sideMenuPanel.Visible)
            {
                sideMenuPanel.Visible = false;
            }
            else
            {
                sideMenuPanel.Visible = true;

            }
        }

        //Открытие окна с информацией
        private void rightArrowBtn_Click(object sender, EventArgs e)
        {
            infoPanel.Visible = true;
            rightArrowBtn.Visible = false;
        }

        //Закрытие окна с информацией
        private void leftArrowBtn_Click(object sender, EventArgs e)
        {
            infoPanel.Visible = false;
            rightArrowBtn.Visible = true;
        }

        //Открытие подменю каталога
        private void catalogBtn_Click(object sender, EventArgs e)
        {
            if (subMenuCatalog.Visible)
            {
                subMenuCatalog.Visible = false;
            }
            else
            {
                subMenuCatalog.Visible = true;
            }
        }

        //Метод клика по каталогу
        private void btnClick(object sender, EventArgs e)
        {
            refreshPictureBox.Visible = false;
            Medicament medicament = new Medicament(((Button)sender).Text);
            //Удаляем все контролы, которые принадлежали subMenuPanel, чтобы добавить новый контрол
            DisposeSubMenuPanel();
            subMenuPanel.Controls.Add(medicament);
            subMenuPanel.Tag = medicament;
            medicament.BringToFront();
            medicament.Show();
        }

        //Клик по кнопке главная
        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            refreshPictureBox.Visible = true;
            RefreshIOETabControl();
        }

        private void personalBtn_Click(object sender, EventArgs e)
        {
            refreshPictureBox.Visible = false;
            SubCatalogMenu();
            PersonalForm personalForm = new PersonalForm();
            //Удаляем все контролы, которые принадлежали subMenuPanel, чтобы добавить новый контрол
            DisposeSubMenuPanel();
            subMenuPanel.Controls.Add(personalForm);
            subMenuPanel.Tag = personalForm;
            personalForm.BringToFront();
            personalForm.Show();
        }

        #endregion

        #region Обновление данных TabControl

        //Обновление данных о доходе\расходе и о каталогах
        private void refreshPictureBox_Click(object sender, EventArgs e)
        {
            RefreshIOETabControl();
        }

        //Метод обновления данных TabControl(пересоздание формы ioeTabControl)
        private void RefreshIOETabControl()
        {
            SubCatalogMenu();
            ioeTablControl ioeTablControl = new ioeTablControl();
            //Удаляем все контролы, которые принадлежали subMenuPanel, чтобы добавить новый контрол
            DisposeSubMenuPanel();
            subMenuPanel.Controls.Add(ioeTablControl);
            subMenuPanel.Tag = ioeTablControl;
            ioeTablControl.BringToFront();
            ioeTablControl.Show();
        }

        #endregion

        //Метод очистки subMenuPanel
        private void DisposeSubMenuPanel()
        {
            //Вычисляю панель subMenuPanel, которая является родительской для текущей формы
            foreach (Control control in subMenuPanel.Controls)
            {
                control.Dispose();
            }
        }
    }
}
