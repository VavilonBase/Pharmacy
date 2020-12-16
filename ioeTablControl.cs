using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class ioeTablControl : Form
    {
        public ioeTablControl()
        {
            InitializeComponent();
            InitializeIOETabControl();
            InitializeRolePersonal();
            SetSettings();
        }

        //Инициализация ioeTabCOntrol
        private void InitializeIOETabControl()
        {
            ioeTabControl.TabPages[0].Text = "Доход";
            ioeTabControl.TabPages[1].Text = "Расход";
            ioeTabControl.SelectTab(0);//Делаем вкладу с доходом текущей
            RefreshIncome();
        }

        //Начальные настройки
        private void SetSettings()
        {
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        //Инициализация в зависимости от роли персонала
        private void InitializeRolePersonal()
        {
            if (Info.personal.isPharmacist)
            {
                tabPage2.Dispose();
            }
            else if (Info.personal.isAccountant)
            {

            }
            else if (Info.personal.isDirector)
            {

            }
        }

        #region Обновление данных TabControl
        //Обновление данных о доходе
        private void RefreshIncome()
        {
            //Обновляем доход
            string queryIncome = "SELECT * FROM v_income";
            DataSet incomeDataSet = Info.sql.CreateDataSet(queryIncome);
            dataGridViewIncome.DataSource = incomeDataSet.Tables[0];
            dataGridViewIncome.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        //Обновление данных о расходе
        private void RefreshExpenditure()
        {
            //Обновляем расход
            string queryExpenditure = "SELECT * FROM v_expenditure";
            DataSet ExpenditureDataSet = Info.sql.CreateDataSet(queryExpenditure);
            dataGridViewExpenditure.DataSource = ExpenditureDataSet.Tables[0];
            dataGridViewExpenditure.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        //Обновление данных при переключение между доходом и расходом
        private void ioeTabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (ioeTabControl.SelectedTab.Text == "Доход")
            {
                RefreshIncome();
            }
            else
            {
                RefreshExpenditure();
            }
        }
        #endregion


    }
}
