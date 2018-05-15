using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Scientific_Calculator
{
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
            
        }

        #endregion

        #region connectionHandling

        /// <summary>
        /// Opens a connection to the database
        /// </summary>
        private void OpenConnection()
        {

        }

        /// <summary>
        /// Closes a connection to the database
        /// </summary>
        private void CloseConnection()
        {

        }

        #endregion

        /// <summary>
        /// Gets a chosen constant from the database
        /// </summary>
        /// <param name="name">the name of the constant we want to retrieve</param>
        /// <returns>the numeric value of the constant</returns>
        public double GetConstant(string constantName)
        {
            return 0;
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
            return 0;
        }


        /// <summary>
        /// Gets the latest operations from the operation history
        /// </summary>
        /// <param name="amount">the amount of operations that need to be retrieved</param>
        /// <returns>a list of the last operations ordered by date</returns>
        public List<string> GetOperationHistory(int amount)
        {
            return null;
        }

        /// <summary>
        /// Inserts a new operation in the operation history dated to today
        /// </summary>
        /// <param name="OperationString">the operaiton string that will be stored in the database</param>
        public void InsertOperationInHistory(string OperationString)
        {

        }
    }
}
