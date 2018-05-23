using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Scientific_Calculator
{
    /// <summary>
    /// Class that handles all the database operations
    /// </summary>
    class DBAccess
    {
        #region Private Attributes

        private MySqlConnection _connection;
        private string _database;
        private string _user;
        private string _server;
        private string _password;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor that creates the connection to the database
        /// </summary>
        public DBAccess()
        {
            //Initializing values for the connection string
            this._database = "Scientific_Calculator";
            this._server = "localhost";
            this._user = "root";
            this._password = "";
            string connectionString = "";

            // Building connection string and creating connection
            connectionString = "SERVER=" + this._server + ";" + "DATABASE=" +
            this._database + ";" + "UID=" + this._user + ";" + "PASSWORD=" + this._password + ";";
            this._connection = new MySqlConnection(connectionString);
        }

        #endregion

        #region connectionHandling

        /// <summary>
        /// Opens a connection to the database
        /// </summary>
        private void OpenConnection()
        {
            try
            {
                _connection.Open();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Impossible de se connecter à la base de données");
            }
        }

        /// <summary>
        /// Closes a connection to the database
        /// </summary>
        private void CloseConnection()
        {
            try
            {
                _connection.Close();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Un problème est survenu avec la base de donnée. Message : " + e.Message);
            }
        }

        #endregion

        /// <summary>
        /// Gets a chosen constant from the database
        /// </summary>
        /// <param name="name">the name of the constant we want to retrieve</param>
        /// <returns>the numeric value of the constant</returns>
        public double GetConstant(string constantName)
        {
            string query = "SELECT value FROM constant WHERE `name` = '" + constantName + "' LIMIT 1;";

            OpenConnection();
            MySqlCommand q = new MySqlCommand(query, _connection);
            MySqlDataReader dataReader = q.ExecuteReader();
            string valueString = "0";
            while (dataReader.Read())
            {
                valueString = dataReader["value"] + "";
            }
            dataReader.Close();
            CloseConnection();
            double value = double.Parse(valueString);
            return value;
        }

        /// <summary>
        /// Gets the default value of a chosen setting from the database
        /// </summary>
        /// <param name="settingName">the name of the setting</param>
        /// <returns>the numeric value of the setting</returns>
        public int GetDefaultSetting(string settingName)
        {
            return 0;
        }

        /// <summary>
        /// Updates the value of a chosen setting in the database
        /// </summary>
        /// <param name="settingName">the name of the setting</param>
        /// <param name="newValue">the new value given to the setting</param>
        public void UpdateSetting(string settingName, int newValue)
        {

        }

        /// <summary>
        /// Gets the current value of a chosen setting from the database
        /// </summary>
        /// <param name="settingName">the name of the setting</param>
        /// <returns>the value of the setting</returns>
        public int GetSettingValue(string settingName)
        {
            string query = "SELECT value FROM setting WHERE `name` = '" + settingName +"' LIMIT 1;";

            OpenConnection();
            MySqlCommand q = new MySqlCommand(query, _connection);
            MySqlDataReader dataReader = q.ExecuteReader();
            string valueString = "1";
            while (dataReader.Read())
            {
                valueString = dataReader["value"] + "";
            }
            dataReader.Close();
            CloseConnection();
            int value = int.Parse(valueString);
            return value;
        }


        /// <summary>
        /// Gets the latest operations from the operation history
        /// </summary>
        /// <param name="amount">the amount of operations that need to be retrieved</param>
        /// <returns>a list of the last operations ordered by date</returns>
        public List<string>[] GetOperationHistory(int amount)
        {
            string query = "SELECT `date`, operationString FROM archivedoperation ORDER BY `date` DESC LIMIT " + amount + ";";

            //Initializing results lists
            List<string>[] results = new List<string>[2];
            results[0] = new List<string>();
            results[1] = new List<string>();

            try
            {
                OpenConnection();
                MySqlCommand q = new MySqlCommand(query, _connection);
                MySqlDataReader dataReader = q.ExecuteReader();

                //Reading the results, converting them to strings and storing them in lists
                while (dataReader.Read())
                {
                    results[0].Add(dataReader["date"] + "");
                    results[1].Add(dataReader["operationString"] + "");
                }

                dataReader.Close();
                CloseConnection();

                return results;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Un problème est survenu avec la base de donnée. Message : " + e.Message);
                CloseConnection();
                return null;
            }
        }

        /// <summary>
        /// Inserts a new operation in the operation history dated to today
        /// </summary>
        /// <param name="OperationString">the operaiton string that will be stored in the database</param>
        public void InsertOperationInHistory(string OperationString)
        {
            DateTime t = DateTime.Now;
            string today = t.Year + "-" + t.Month + "-" + t.Day + " " + t.Hour + ":" + t.Minute + ":" + t.Second;
            string query = "INSERT INTO archivedoperation (date, operationString) VALUES ('" + today + "', '" + OperationString + "');";

            OpenConnection();
            try
            {
                MySqlCommand q = new MySqlCommand(query, _connection);
                q.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Un problème est survenu avec la base de donnée. Message : " + e.Message);
            }
        }
    }
}
