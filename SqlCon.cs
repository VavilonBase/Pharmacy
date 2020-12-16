using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Pharmacy
{
    internal class SqlCon
    {
        private string _connectionString;
        public string ConnectionString { get => _connectionString; set => _connectionString = value; }

        private SqlConnection connection;

        
        //Начальное подключение
        public SqlCon()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            connection = new SqlConnection(ConnectionString);
        }


        //Создание датасета по команде(испульзуется для вставки параметров)
        public DataSet CreateDataSet(SqlCommand command)
        {
            if (ConnectionOpen())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                if (!ConnectionClose())
                {
                    return new DataSet();
                }
                return dataSet;
            }
            else
            {
                return new DataSet();
            }
        }
        
        //Создание датасета по query-запросу
        public DataSet CreateDataSet(string query)
        {
            if (ConnectionOpen())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                if (!ConnectionClose())
                {
                    return new DataSet();
                }
                return dataSet;
            }
            else
            {
                return new DataSet();
            }
        }

        public bool ConnectionOpen()
        {
            bool open = true;
            try
            {
                connection.Open();
            }
            catch
            {
                open = false;
            }
            return open;

        }
        public bool ConnectionClose()
        {
            bool close = true;
            try
            {
                connection.Close();
            }
            catch
            {
                close = false;
            }
            return close;
        }
        public SqlCommand CreateCommand(string query)
        {
            SqlCommand command = new SqlCommand(query, connection);
            return command;

        }
    }
}
