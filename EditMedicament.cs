using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class EditMedicament : Form
    {
        private BaseMedicament editMedicament;
        private bool _edit = false;
        public EditMedicament(BaseMedicament medicament)
        {
            InitializeComponent();
            editMedicament = medicament;
            InitializeTextBox();
        }
        public EditMedicament()
        {
            _edit = true;
            InitializeComponent();
            InitializeTextBox();
        }
        //Метод инициализации текстбоксов
        private void InitializeTextBox()
        {
            if (!_edit)
            {
                medicamentNameTextBox.Text = editMedicament.MedicamentName;
                brandNameTextBox.Text = editMedicament.BrandName;
                countryNameTextBox.Text = editMedicament.Country;
                withRecipeYes.Checked = editMedicament.WithRecipe;
                withRecipeNo.Checked = !editMedicament.WithRecipe;
                categoryNameTextBox.Text = editMedicament.CategoryName;
                dateProducingTextBox.Text = editMedicament.DateProducing;
                dateStorageLifeTextBox.Text = editMedicament.DateStorageLife;
                priceTextBox.Text = editMedicament.Price.ToString();
                descriptionTextBox.Text = editMedicament.MedicamentDescription;
            }
            
        }

        //Метод отправки измененных данных
        private void editMedicamentData_Click(object sender, EventArgs e)
        {
            if (checkTextBox())
            {
                if (!_edit)
                {
                    editMedicament.Update(medicamentNameTextBox.Text, withRecipeYes.Checked, categoryNameTextBox.Text, dateProducingTextBox.Text, dateStorageLifeTextBox.Text,
                      Convert.ToDecimal(priceTextBox.Text), brandNameTextBox.Text, countryNameTextBox.Text, descriptionTextBox.Text);
                    BaseMedicament medicament = new BaseMedicament(editMedicament.MedicamentId);
                    MedicamentDescription medicamentDescription = new MedicamentDescription(medicament);
                    medicamentDescription.TopLevel = false;
                    medicamentDescription.Dock = DockStyle.Fill;
                    medicamentDescription.FormBorderStyle = FormBorderStyle.None;
                    //Вычисляю панель subMenuPanel, которая является родительской для текущей формы
                    Panel subMenuPanel = (Panel)this.Parent;
                    foreach (Control control in subMenuPanel.Controls)
                    {
                        control.Dispose();
                    }
                    subMenuPanel.Controls.Add(medicamentDescription);
                    subMenuPanel.Tag = medicamentDescription;
                    medicamentDescription.BringToFront();
                    medicamentDescription.Show();

                }
                else
                {

                }
            }
            
            
        }

        //Метод проверки измененных данных
        private bool checkTextBox()
        {
            bool check = true;
            //Длина названия медикамента должна быть меньше или равна 30 символам и должен быть хотя бы 1 символ
            if (medicamentNameTextBox.Text.Length ==0 || medicamentNameTextBox.Text.Length >= 30)
            {
                check = false;
                errorMedicamentNameLabel.Text = "Длина больше 30 символов или равна нулю";
            }
            else
            {
                errorMedicamentNameLabel.Text = "";
            }
            //Длина названия бренда должна быть меньше или равна 30 символам и должен быть хотя бы 1 символ
            if (brandNameTextBox.Text.Length == 0 || brandNameTextBox.Text.Length >= 30)
            {
                check = false;
                errorBrandNameLabel.Text = "Длина больше 30 символов или равна нулю";
            }
            else
            {
                errorBrandNameLabel.Text = "";
            }
            //Длина названия страны должна быть меньше или равна 30 символам и должен быть хотя бы 1 символ
            if (countryNameTextBox.Text.Length == 0 || countryNameTextBox.Text.Length >= 30)
            {
                check = false;
                errorCountryNameLabel.Text = "Длина больше 30 символов или равна нулю";
            }
            else
            {
                errorCountryNameLabel.Text = "";
            }
            //Длина названия категории должна быть меньше или равна 20 символам и должен быть хотя бы 1 символ
            if (categoryNameTextBox.Text.Length == 0 || categoryNameTextBox.Text.Length >= 20)
            {
                check = false;
                errorCategoryNameLabel.Text = "Длина больше 30 символов или равна нулю";
            }
            else
            {
                errorCategoryNameLabel.Text = "";
            }
            //Дата производства и срок годности должны иметь определенный формат(при этом срока годности может не быть)
            //Дата производства
            DateTime dt1;
            if (!DateTime.TryParse(dateProducingTextBox.Text, out dt1))
            {
                check = false;
                errorDateProducingLabel.Text = "Неверная дата производства";
            }
            else
            {
                errorDateProducingLabel.Text = "";
            }
            //Срок годности
            if (!(dateStorageLifeTextBox.Text == ""))
            {
                DateTime dt2;
                if (!DateTime.TryParse(dateStorageLifeTextBox.Text, out dt2))
                {
                    check = false;
                    errorDateStorageLifeLabel.Text = "Неверный срок годности";
                }
            }
            else
            {
                errorDateStorageLifeLabel.Text = "";
            }
            //Проверка цены на ввод цифр и количетсво цифр
            Regex regex = new Regex(@"^[0-9]{1,4}(.[0-9][0-9]?)?$");
            MatchCollection matches = regex.Matches(priceTextBox.Text);
            if (matches.Count == 0)
            {
                check = false;
                errorPriceLabel.Text = "Неверная цена";
            }
            else
            {
                errorPriceLabel.Text = "";
            }
            //Проверка поисания(должно быть не более 1000 символом, если длина равна 0 символам, то нет описания)
            if (descriptionTextBox.Text.Length == 0)
            {
                descriptionTextBox.Text = "Нет описания";
            }
            else if (descriptionTextBox.Text.Length > 1000)
            {
                check = false;
                errorDescriptionLabel.Text = "Длина больше 1000 символов";
            }
            else
            {
                errorDescriptionLabel.Text = "";
            }
            //Возвращаем результат
            return check;
        }
    }
}
