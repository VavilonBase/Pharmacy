using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class MedicamentDescription : Form
    {
        private BaseMedicament _medicament;
        private int _quantity;

        public BaseMedicament Medicament { get => _medicament; set => _medicament = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }

        public MedicamentDescription(BaseMedicament medicament)
        {
            InitializeComponent();
            Medicament = medicament;
            medicamentBuy.Tag = medicament.MedicamentId;
            medicamentName.Text = medicament.MedicamentName;
            medicamentDescriptoin.Text = $"Описание: {medicament.MedicamentDescription}";
            medicamentPrice.Text = $"Цена: {medicament.Price}р";
            medicamentPrice.Tag = medicament.Price;
            countryLabel.Text = $"Страна: {medicament.Country}";
            brandLabel.Text = $"Бренд: {medicament.BrandName}";
            withRecipeLabel.Text = medicament.WithRecipe ? "Только после констультации с врачом" : "Нет необходимости консультироваться с врачом";
            dateProducingLabel.Text = $"Дата производства: {medicament.DateProducing}";
            dateStorageLifeLabel.Text = $"Срок годности: {medicament.DateStorageLife}";
            categoryNameLabel.Text = $"Категория: {medicament.CategoryName}";
            (int, string) quantityAndError = medicament.SearchQuantityMedicament(medicament.MedicamentId, Info.personal.pharmacyId);
            string errorText = quantityAndError.Item2;
            if (errorText != "")
            {
                MessageBox.Show(errorText);
            }
            else
            {
                Quantity = quantityAndError.Item1;
                labelHaveMedicament.Text = $"Есть в наличии: {Quantity}ш.";
                if (Quantity == 0)
                {
                    medicamentBuy.Enabled = false;
                    labelHaveMedicament.Text = $"Нет в наличии";
                    pictureBoxHaveMedicament.Image = global::Pharmacy.Resource1.redCircle;
                }
            }
            SetSettings();
            InitializeRolePersonal();
        }

        //Начальные установки
        private void SetSettings()
        {
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.FormBorderStyle = FormBorderStyle.None;
        }
        //Инициализация по ролям
        //Инициализация в зависимости от роли персонала
        private void InitializeRolePersonal()
        {
            if (Info.personal.isPharmacist)
            {
            }
            else if (Info.personal.isAccountant)
            {
                editInfo.Visible = false;
            }
            else if (Info.personal.isDirector)
            {

            }
        }

        //Метод изменения количества лекарств
        private void medicamentQuantity_TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxQuantity = (TextBox)sender;
            if (textBoxQuantity.Text != "")
            {
                Regex regex = new Regex(@"^[1-9][0-9]{0,5}$");
                MatchCollection matches = regex.Matches(textBoxQuantity.Text);
                if (matches.Count > 0)
                {
                    int quantity = Convert.ToInt32(textBoxQuantity.Text);
                    decimal startPrice = (decimal)medicamentPrice.Tag;
                    decimal newPrice = startPrice * quantity;
                    medicamentPrice.Text = $"{newPrice}р";
                }
                else
                {
                    textBoxQuantity.Text = "1";
                }
            }
        }

        //Метод клика по кнопке Buy
        private void medicamentBuy_Click(object sender, EventArgs e)
        { 
            int quantity = Int32.Parse(medicamentQuantity.Text);
            if (Quantity >= quantity)
            {
                Info.sql.ConnectionOpen();
                string query = "BuyMedicament";
                SqlCommand command = Info.sql.CreateCommand(query);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@personalId", SqlDbType.TinyInt).Value = Info.personal.personalId;
                command.Parameters.AddWithValue("@medicamentId", Medicament.MedicamentId);
                command.Parameters.AddWithValue("@quantity", quantity);
                command.ExecuteNonQuery();
                Info.sql.ConnectionClose();
                MessageBox.Show("Вы совершили покупку");
                RefreshMedicaments();
            }
            else
            {
                MessageBox.Show("Недостаточно товара в наличии");
            }
        }

        //Метод клика по кнопке Заказать
        private void ClickBtnOrder(object sender, EventArgs e)
        {

            int quantity = Int32.Parse(medicamentQuantity.Text);
            //Заказ лекарства
            SqlCommand command = Info.sql.CreateCommand("OrderMedicament");
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter medicamentIdParam = new SqlParameter("@medicamentId", (byte)medicamentBuy.Tag);
            SqlParameter pharmacyIdParam = new SqlParameter("@pharmacyId", Info.personal.pharmacyId);
            SqlParameter quantityParam = new SqlParameter("@quantity", quantity);
            SqlParameter errorMessageParam = new SqlParameter("@errorMessage", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.Output
            };
            command.Parameters.Add(medicamentIdParam);
            command.Parameters.Add(pharmacyIdParam);
            command.Parameters.Add(quantityParam);
            command.Parameters.Add(errorMessageParam);
            string errorMessage = "";
            if (Info.sql.ConnectionOpen())
            {
                try
                {
                    command.ExecuteNonQuery();
                    errorMessage = command.Parameters["@errorMessage"].Value.ToString();
                    if (errorMessage == "OK")
                    {
                        errorMessage = "";
                    }

                }
                catch
                {
                    errorMessage = "Не получилось выполнить комманду на заказ лекарства\nОбратитесь к специалисту";
                }
                if (!Info.sql.ConnectionClose())
                {
                    errorMessage = "Не получилось закрыть соединение с сервером базы данных\nОбратитесь к специалисту";
                }
            }
            else
            {
                errorMessage = "Не получилось открыть соединения с базой данных\nОбратитесь к специалисту";
            }
            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage);
            }
            else
            {
                MessageBox.Show("Товар успешно заказан");
                RefreshMedicaments();
            }

        }
        private void RefreshMedicaments()
        {
            MedicamentDescription medicamentDescription = new MedicamentDescription(Medicament);
            //Удаляем все контролы, которые принадлежали subMenuPanel, чтобы добавить новый контрол
            Panel subMenuPanel = (Panel)this.Parent;
            DisposeSubMenuPanel(subMenuPanel);
            subMenuPanel.Controls.Add(medicamentDescription);
            subMenuPanel.Tag = medicamentDescription;
            medicamentDescription.BringToFront();
            medicamentDescription.Show();
        }
        //Метод очистки subMenuPanel
        private void DisposeSubMenuPanel(Panel subMenuPanel)
        {
            //Вычисляю панель subMenuPanel, которая является родительской для текущей формы
            foreach (Control control in subMenuPanel.Controls)
            {
                control.Dispose();
            }
        }
        //Редактирование информации
        private void editInfo_Click(object sender, EventArgs e)
        {
            BaseMedicament medicament = new BaseMedicament((byte)medicamentBuy.Tag);
            EditMedicament editMedicament = new EditMedicament(medicament);
            editMedicament.TopLevel = false;
            editMedicament.Dock = DockStyle.Fill;
            editMedicament.FormBorderStyle = FormBorderStyle.None;
            //Вычисляю панель subMenuPanel, которая является родительской для текущей формы
            Panel subMenuPanel = (Panel)this.Parent;
            foreach (Control control in subMenuPanel.Controls)
            {
                control.Dispose();
            }
            subMenuPanel.Controls.Add(editMedicament);
            subMenuPanel.Tag = editMedicament;
            editMedicament.BringToFront();
            editMedicament.Show();
        }
    }
}
