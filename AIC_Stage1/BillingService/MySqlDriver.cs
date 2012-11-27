using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace BillingService
{
    class MySqlDriver : IDisposable
    {
        private const string DB_CONFIG_NAME = "DBConnection";

        private static MySqlDriver instance = null;

        MySqlConnection connection;

        // singleton
        public static MySqlDriver getInstance()
        {
            if (instance == null)
            {
                instance = new MySqlDriver();
            }
            return instance;
        }

        public MySqlDriver()
        {
            if (System.Configuration.ConfigurationManager.ConnectionStrings[DB_CONFIG_NAME] == null)
                throw new ApplicationException("missing DB configuration '" + DB_CONFIG_NAME + "'");

            string myConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

            connection = new MySqlConnection(myConnectionString);
            connection.Open();
        }

        public MySqlCommand getCommand()
        {
            return connection.CreateCommand();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }

        public void closeConnection()
        {
            connection.Close();
            instance = null;
        }

        void IDisposable.Dispose()
        {
            closeConnection();
        }
    }
}