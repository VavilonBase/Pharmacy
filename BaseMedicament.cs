using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    public class BaseMedicament
    {
        #region Переменные
        private byte _medicamentId;
        public byte MedicamentId { get => _medicamentId; set => _medicamentId = value; }

        private string _medicamentName;
        public string MedicamentName { get => _medicamentName; set => _medicamentName = value; }

        private bool _withRecipe;
        public bool WithRecipe { get => _withRecipe; set => _withRecipe = value; }

        private string _brandName;
        public string BrandName { get => _brandName; set => _brandName = value; }

        private string _country;
        public string Country { get => _country; set => _country = value; }

        private string _categoryName;
        public string CategoryName { get => _categoryName; set => _categoryName = value; }

        private string _dateProducing;
        public string DateProducing { get => _dateProducing; set => _dateProducing = value; }

        private string _dateStorageLife;
        public string DateStorageLife
        {
            get => _dateStorageLife; 
            set
            {
                _dateStorageLife = value == null ? "Не известно" : value;
            }
        }

        private decimal _price;
        public decimal Price { get => _price; set => _price = value; }

        private string _medicamentDescription;
        public string MedicamentDescription
        {
            get => _medicamentDescription; 
            set
            {
                _medicamentDescription = value == "" ? "Нет описания" : value;
            }
        }

        #endregion

        #region Конструкторы
        //Конструктор для создания экземпляра класса медикамента для страницы с медикаментомами
        public BaseMedicament(DataRow medicamentDataRow)
        {
            MedicamentId = Convert.ToByte(medicamentDataRow[0]);
            MedicamentName = FirstUpperLetter(medicamentDataRow[1].ToString());
            Price = Convert.ToDecimal(medicamentDataRow[2]);
        }

        //Конструктор для создания экземпляра класса медикамента для страницы с медикаментом
        public BaseMedicament(byte id)
        {
            string query = "SELECT * FROM SearchOnMedicamentId(@id);";
            SqlCommand command = Info.sql.CreateCommand(query);
            SqlParameter idParam = new SqlParameter("@id", id);
            command.Parameters.Add(idParam);
            DataSet medicamentDataSet = Info.sql.CreateDataSet(command);
            if (medicamentDataSet.Tables[0].Rows.Count != 0)
            {
                DataRow medicamentDataRow = medicamentDataSet.Tables[0].Rows[0];
                MedicamentId = Convert.ToByte(medicamentDataRow[0]);
                MedicamentName = FirstUpperLetter(medicamentDataRow[1].ToString());
                WithRecipe = Convert.ToBoolean(medicamentDataRow[2]);
                CategoryName = FirstUpperLetter(medicamentDataRow[3].ToString());
                DateProducing = medicamentDataRow[4].ToString();
                DateStorageLife = medicamentDataRow[5].ToString();
                Price = Convert.ToDecimal(medicamentDataRow[6]);
                BrandName = FirstUpperLetter(medicamentDataRow[7].ToString());
                Country = FirstUpperLetter(medicamentDataRow[8].ToString());
                MedicamentDescription = medicamentDataRow[9].ToString();
            }
            else
            {
                MedicamentId = id;
                MedicamentName = "Ошибка. Данные не найдены";
                WithRecipe = false;
                CategoryName = "Ошибка. Данные не найдены";
                DateProducing = "Ошибка. Данные не найдены";
                DateStorageLife = "Ошибка. Данные не найдены";
                Price = 0;
                BrandName = "Ошибка. Данные не найдены";
                Country = "Ошибка. Данные не найдены";
                MedicamentDescription = "Ошибка. Данные не найдены";
            }
        }
        #endregion

        #region Методы
        //Метод поиска количества лекарства по id лекарства и id аптеки
        public (int, string) SearchQuantityMedicament(byte medicamentId, byte pharmacyId)
        {
            int quantity = 0;
            string query = "SELECT quantity FROM MedicamentPharmacyQuantity WHERE pharmacyId = @pharmacyId AND medicamentId = @medicamentId";
            SqlCommand command = Info.sql.CreateCommand(query);
            SqlParameter medicamentIdParam = new SqlParameter("@medicamentId", medicamentId);
            SqlParameter pharmacyIdParam = new SqlParameter("@pharmacyId", pharmacyId);
            command.Parameters.Add(medicamentIdParam);
            command.Parameters.Add(pharmacyIdParam);
            string errorText = "";
            if (Info.sql.ConnectionOpen())
            {
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        quantity = reader.GetInt32(0);
                    }
                    else
                    {
                        errorText = "Либо такого медикамента не существует, либо нет такой аптеки\nОбратитесь к специалисту";
                    }
                }
                catch
                {
                    errorText = "Не получилось выполнить команду на поиск количества медикамента\nОбратитесь к специалисту";
                }
            }
            else
            {
                errorText = "Не получилось открыть соединения с базой данных\nОбратитесь к специалисту";
            }
            if (!Info.sql.ConnectionClose())
            {
                errorText = "Не получилось закрыть соединения с базой данных\nОбратитесь к специалисту";
            }
            return (quantity, errorText);
        }
        private string FirstUpperLetter(string str)
        {
            return str.Substring(0, 1).ToUpper() + (str.Length > 1 ? str.Substring(1).ToLower() : "");
        }
        
        //Метод обновления данных
        public void Update(string medicamentName, bool withRecipe, string categoryName, string dateProducing, string dateStorageLife,
            decimal price, string brandName, string country, string description)
        {
            MedicamentName = medicamentName;
            WithRecipe = withRecipe;
            CategoryName = categoryName;
            DateProducing = dateProducing;
            DateStorageLife = dateStorageLife;
            Price = price;
            BrandName = brandName;
            Country = country;
            MedicamentDescription = description;
            Info.sql.ConnectionOpen();
            string query = "UpdateMedicament";
            SqlCommand command = Info.sql.CreateCommand(query);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@medicamentId", MedicamentId);
            command.Parameters.AddWithValue("@medicamentName", MedicamentName);
            command.Parameters.AddWithValue("@brandName", BrandName);
            command.Parameters.AddWithValue("@countryName", Country);
            command.Parameters.AddWithValue("@withRecipe", WithRecipe);
            command.Parameters.AddWithValue("@categoryName", CategoryName);
            command.Parameters.AddWithValue("@dateProducing", DateProducing);
            command.Parameters.AddWithValue("@dateStorageLife", DateStorageLife);
            command.Parameters.AddWithValue("@price", Price);
            command.Parameters.AddWithValue("@description", MedicamentDescription);
            command.ExecuteNonQuery();
            Info.sql.ConnectionClose();
        }
        #endregion
    }
}
