using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    public class Personal
    {
        public byte personalId;
        public string firstName;
        public string lastName;
        public string middleName;
        public string callNumber;
        public byte hourWorks;
        public decimal rate;
        public decimal prize;
        public byte pharmacyId;
        public string category;
        //Переменные для определения роли персонала
        public bool isPharmacist;
        public bool isAccountant;
        public bool isDirector;

        //Обычный конструктор создания персонала
        public Personal()
        {

        }

        //Конструктор инизиализация данных о персонале по входным данным
        public Personal(byte personalId, string lastName, string firstName, string middleName, string callNumber,
            byte hourWorks, decimal rate, decimal prize, byte pharmacyId, string category)
        {
            InputDateOfPersonal(personalId, lastName, firstName, middleName, callNumber,
            hourWorks, rate, prize, pharmacyId, category);
        }

        #region Публичные методы
        //Метод получения логина и пароля по Id
        public (string, string, string) GetLoginAndPassword()
        {
            string login = "";
            string password = "";
            string errorText = "";
            string query = $"SELECT login, password FROM v_personal WHERE personalID = {personalId}";
            SqlCommand command = Info.sql.CreateCommand(query);
            if (Info.sql.ConnectionOpen())
            {
                try
                {
                    SqlDataReader personalReader = command.ExecuteReader();
                    //Проверяем на всякий случай, есть ли данные о нем(хотя мы и делали это выше)
                    if (personalReader.HasRows)
                    {
                        //Если данные есть, то считываем их
                        personalReader.Read();
                        login = personalReader.GetString(0);
                        password = personalReader.GetString(1);
                        personalReader.Close();
                    }
                    else//Если при повторном разе данные не нашлись
                    {
                        errorText = "Что-то пошло не так";
                    }
                }
                catch
                {
                    errorText = "Не получилось выполнить комманду на получение данных о сотруднике\nОбратитесь к специалисту";
                }
                if (!Info.sql.ConnectionClose())
                {
                    errorText = "Не получилось закрыть соединение с сервером базы данных\nОбратитесь к специалисту";
                }
            }
            else
            {
                errorText = "Не получилось открыть соединения с базой данных\nОбратитесь к специалисту";
            }
            return (login, password, errorText);
        }
        //Метод создания сотрудника по id
        public string CreatePersonalById(byte personalId)
        {
            string errorText = "";
            string query = $"SELECT * FROM v_personal WHERE personalID = {personalId}";
            SqlCommand command = Info.sql.CreateCommand(query);
            if (Info.sql.ConnectionOpen())
            {
                try
                {
                    SqlDataReader personalReader = command.ExecuteReader();
                    //Проверяем на всякий случай, есть ли данные о нем(хотя мы и делали это выше)
                    if (personalReader.HasRows)
                    {
                        //Если данные есть, то считываем их
                        personalReader.Read();
                        //Создаем пользователя
                        InputDateOfPersonal(personalReader.GetByte(0), personalReader.GetString(1), personalReader.GetString(2),
                            personalReader.GetString(3), personalReader.GetString(4), personalReader.GetByte(5),
                            personalReader.GetDecimal(6), personalReader.GetDecimal(7), personalReader.GetByte(8), personalReader.GetString(9));
                        personalReader.Close();
                    }
                    else//Если при повторном разе данные не нашлись
                    {
                        errorText = "Что-то пошло не так";
                    }
                }
                catch
                {
                    errorText = "Не получилось найти сотрудника по Id\nОбратитесь к специалисту";
                }
                if (!Info.sql.ConnectionClose())
                {
                    errorText = "Не получилось закрыть соединение с сервером базы данных\nОбратитесь к специалисту";
                }
            }
            else
            {
                errorText = "Не получилось открыть соединения с базой данных\nОбратитесь к специалисту";
            }
            return errorText;
        }
        //Метод проверки логина и пароля, и взятие данных о человеке, в случае правильного ввода
        public string CheckLoginAndPassword(string login, string password)
        {
            string errorText = "";
            string query = "SELECT personalId, login,password FROM Personal WHERE login=@login AND password=@password";
            (SqlDataReader, string) InfoForConnectionToDataBase = ConnectionToDataBase(query, login, password);
            SqlDataReader reader = InfoForConnectionToDataBase.Item1;
            if (reader != null)//Если получилось открыть соединение
            {
                if (reader.HasRows)//Если есть строки, то человек с таким логином и паролем существует
                {
                    reader.Read();
                    byte id = reader.GetByte(0);
                    reader.Close();
                    //Так как такой сотрудник существует, то запращиваем данные о нем
                    query = $"SELECT * FROM v_personal WHERE personalID = {id}";
                    SqlCommand command = Info.sql.CreateCommand(query);
                    try
                    {
                        SqlDataReader personalReader = command.ExecuteReader();
                        //Проверяем на всякий случай, есть ли данные о нем(хотя мы и делали это выше)
                        if (personalReader.HasRows)
                        {
                            //Если данные есть, то считываем их
                            personalReader.Read();
                            //Создаем пользователя
                            InputDateOfPersonal(personalReader.GetByte(0), personalReader.GetString(1), personalReader.GetString(2),
                                personalReader.GetString(3), personalReader.GetString(4), personalReader.GetByte(5),
                                personalReader.GetDecimal(6), personalReader.GetDecimal(7), personalReader.GetByte(8), personalReader.GetString(9));
                            personalReader.Close();
                        }
                        else//Если при повторном разе данные не нашлись
                        {
                            errorText = "Что-то пошло не так";
                        }
                    }
                    catch
                    {
                        errorText = "Не получилось выполнить комманду на получение данных о сотруднике\nОбратитесь к специалисту";
                    }

                }
                else//Если введен не верный логин и пароль
                {
                    errorText = "Вы ввели неверный логин или пароль";
                }
            }
            else//Если произошла ошибка при открытии подключения
            {
                errorText = InfoForConnectionToDataBase.Item2;
            }

            if (!Info.sql.ConnectionClose())
            {
                errorText = "Не получилось закрыть соединение с сервером базы данных\nОбратитесь к специалисту";
            }
            return errorText;
        }

        // Метод добавления сотрудника в базу данных
        public (byte, string) AddPersonal(string login, string password)
        {
            string errorMessage = "";
            byte id = 0;
            SqlCommand command = CreateCommandWithAllPersonalParameter("AddPersonal", login, password);
            if (Info.sql.ConnectionOpen())
            {
                try
                {
                    command.ExecuteNonQuery();
                    errorMessage = command.Parameters["@errorMessage"].Value.ToString();
                    if (errorMessage == "OK")
                    {
                        errorMessage = "";
                        id = Convert.ToByte(command.Parameters["@id"].Value);
                    }
                    else
                    {
                        errorMessage += $"\nId пользователя: {id}";

                    }
                    personalId = id;
                }
                catch
                {
                    errorMessage = "Не получилось выполнить комманду на добавление сотрудника\nОбратитесь к специалисту";
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
            return (id, errorMessage);
        }

        //Метод увольнения(удаления) сотрудника
        public string DismissPersonal(byte personalId)
        {
            string errorMessage = "";
            SqlParameter personalIdParam = new SqlParameter("@personalId", personalId);
            SqlParameter errorMessageParam = new SqlParameter("@errorMessage", SqlDbType.NVarChar, 30)
            {
                Direction = ParameterDirection.Output
            };
            SqlCommand command = CreateCommandWithUnknowParameters("DismissPersonal", personalIdParam, errorMessageParam);
            command.CommandType = CommandType.StoredProcedure;
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
                    else
                    {
                        errorMessage += $"\nId пользователя {personalId}";
                    }
                }
                catch
                {
                    errorMessage = "Не получилось выполнить комманду на увольнение сотрудника\nОбратитесь к специалисту";
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
            return errorMessage;
        }

        //Метод изменения данных сотрудника
        public (byte, string) UpdatePersonal(string lastName, string firstName, string middleName, string callNumber,
            byte hourWorks, decimal rate, decimal prize, byte pharmacyId, string category, string login, string password)
        {
            InputDateOfPersonal(this.personalId, lastName, firstName, middleName, callNumber,
            hourWorks, rate, prize, pharmacyId, category);
            string errorMessage = "";
            byte id = 0;
            SqlCommand command = CreateCommandWithAllPersonalParameter("UpdatePersonal", login, password);
            SqlParameter personalIdParam = new SqlParameter("@personalId", personalId);
            SqlParameter prizeParam = new SqlParameter("@prize", prize);
            SqlParameter hourWorksParam = new SqlParameter("@hourWorks", hourWorks);
            command = AddUnknowParametersInCommand(command, personalIdParam, prizeParam, hourWorksParam);
            if (Info.sql.ConnectionOpen())
            {
                try
                {
                command.ExecuteNonQuery();
                errorMessage = command.Parameters["@errorMessage"].Value.ToString();
                if (errorMessage == "OK")
                {
                    errorMessage = "";
                    id = Convert.ToByte(command.Parameters["@id"].Value);
                }
                else
                {
                    errorMessage += $"\nId пользователя: {id}";

                }
                personalId = id;
                }
                catch
                {
                    errorMessage = "Не получилось выполнить комманду на обновление данных сотрудника\nОбратитесь к специалисту";
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
            return (id, errorMessage);
        }
        
        //Метод выдачи зарплаты сотруднику
        public (decimal,string) GetSalary(byte personalId)
        {
            string errorMessage = "";
            decimal totalSalary = 0;
            SqlCommand command = Info.sql.CreateCommand("GetSalary");
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter personalIdParam = new SqlParameter("@personalId", personalId);
            SqlParameter totalSalaryParam = new SqlParameter("@totalSalary", SqlDbType.Decimal);
            SqlParameter errorMessageParam = new SqlParameter("@errorMessage", SqlDbType.NVarChar, 50);
            totalSalaryParam.Direction = ParameterDirection.Output;
            errorMessageParam.Direction = ParameterDirection.Output;
            command = AddUnknowParametersInCommand(command, personalIdParam, totalSalaryParam, errorMessageParam);
            if (Info.sql.ConnectionOpen())
            {
                try
                {
                    command.ExecuteNonQuery();
                    errorMessage = command.Parameters["@errorMessage"].Value.ToString();
                    if (errorMessage == "OK")
                    {
                        errorMessage = "";
                        totalSalary = Convert.ToDecimal(command.Parameters["@totalSalary"].Value);
                    }
                    else
                    {
                        errorMessage += $"\nId пользователя: {personalId}";

                    }
                }
                catch
                {
                    errorMessage = "Не получилось выполнить комманду на выплату зарплаты сотруднику\nОбратитесь к специалисту";
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
            return (totalSalary, errorMessage);
        }
        #endregion


        #region Приватные методы
        //Инизиализация данных о персонале по входным данным
        private void InputDateOfPersonal(byte personalId, string lastName, string firstName, string middleName, string callNumber, 
            byte hourWorks, decimal rate, decimal prize, byte pharmacyId, string category)
        {
            this.personalId = personalId;
            this.firstName = FirstUpperLetter(firstName);
            this.lastName = FirstUpperLetter(lastName);
            this.middleName = FirstUpperLetter(middleName);
            this.callNumber = callNumber;
            this.hourWorks = hourWorks;
            this.rate = rate;
            this.prize = prize;
            this.pharmacyId = pharmacyId;
            this.category = FirstUpperLetter(category);
            isPharmacist = false;
            isAccountant = false;
            isDirector = false;
            InitializeRolePersonal(category);
    }


        //Метод инизиализации роли человека
        private void InitializeRolePersonal(string categoryName)
        {
            string category = FirstUpperLetter(categoryName);
            switch (category)
            {
                case "Аптекарь": 
                    isPharmacist = true;
                    break;
                case "Бухгалтер":
                    isAccountant = true;
                    break;
                case "Руководитель":
                    isDirector = true;
                    break;
            }
        }

        //Метод подюключение к БД и создание экземпляра класса SqlDataReader
        private (SqlDataReader, string) ConnectionToDataBase(string query, string login, string password)
        {
            string errorText = "";
            if (Info.sql.ConnectionOpen())
            {
                SqlParameter loginParam = new SqlParameter("@login", login);
                SqlParameter passwordParam = new SqlParameter("@password", password);
                SqlCommand command = CreateCommandWithUnknowParameters(query, loginParam, passwordParam);
                SqlDataReader reader = command.ExecuteReader();
                return (reader, errorText);

            }
            else
            {
                errorText = "Не получилось открыть соединения с базой данных\nОбратитесь к специалисту";
                return (null, errorText);
            }
        }

       

        //Метод создания команды команды для выполнения процедуры с параметрами персонала
        private SqlCommand CreateCommandWithAllPersonalParameter(string procedureName, string login, string password)
        {
            SqlParameter lastNameParam = new SqlParameter("@lastName", lastName);
            SqlParameter firstNameParam = new SqlParameter("@firstName", firstName);
            SqlParameter middleNameParam = new SqlParameter("@middleName", middleName);
            SqlParameter callNumberParam = new SqlParameter("@callNumber", callNumber);
            SqlParameter loginParam = new SqlParameter("@login", login);
            SqlParameter passwordParam = new SqlParameter("@password", password);
            SqlParameter rateParam = new SqlParameter("@rate", rate);
            SqlParameter pharmacyIdParam = new SqlParameter("@pharmacyId", pharmacyId);
            SqlParameter isPharmacistParam = new SqlParameter("@IsPharmacist", isPharmacist);
            SqlParameter isAccountantParam = new SqlParameter("@IsAccountant", isAccountant);
            SqlParameter isDirectorParam = new SqlParameter("@IsDirector", isDirector);
            SqlParameter personalIdParam = new SqlParameter("@id", SqlDbType.TinyInt);
            SqlParameter errorMessageParam = new SqlParameter("@errorMessage", SqlDbType.NVarChar, 51);
            personalIdParam.Direction = ParameterDirection.Output;
            errorMessageParam.Direction = ParameterDirection.Output;
            SqlCommand command = CreateCommandWithUnknowParameters(procedureName, lastNameParam, firstNameParam, middleNameParam, callNumberParam, loginParam, passwordParam,
                rateParam, pharmacyIdParam, isPharmacistParam, isAccountantParam, isDirectorParam, personalIdParam, errorMessageParam);
            command.CommandType = CommandType.StoredProcedure;
            return command;
        }
        //Метод создания команды с неизвестным числом параметров
        private SqlCommand CreateCommandWithUnknowParameters(string query, params SqlParameter[] param)
        {
            SqlCommand command = Info.sql.CreateCommand(query);
            AddUnknowParametersInCommand(command, param);
            return command;
        }
        //Метод добавления неизвестного числа параметров в команду SqlCommand
        private SqlCommand AddUnknowParametersInCommand(SqlCommand command, params SqlParameter[] param)
        {
            foreach (SqlParameter parameter in param)
            {
                command.Parameters.Add(parameter);
            }
            return command;
        }
        private string FirstUpperLetter(string str)
        {
            return str.Substring(0, 1).ToUpper() + (str.Length > 1 ? str.Substring(1).ToLower() : "");
        }
        #endregion
    }
}
