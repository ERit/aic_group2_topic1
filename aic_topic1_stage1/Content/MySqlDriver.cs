using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace aic_topic1_stage1
{
	public class MySqlDriver
	{
		private static MySqlDriver instance = null;

		MySqlConnection connection;

		// singleton
		public static MySqlDriver getInstance() {
			if (instance == null) {
				instance = new MySqlDriver();
			}
			return instance;
		}

		public MySqlDriver ()
		{
			string myConnectionString = "SERVER=localhost;" +
				"DATABASE=aic_group2_topic1;" +
					"UID=root;" +
					"PASSWORD=mdhl";

			connection = new MySqlConnection(myConnectionString);
			connection.Open();
		}

		public MySqlCommand getCommand ()
		{
			return connection.CreateCommand();
		}

		public MySqlConnection getConnection ()
		{
			return connection;
		}

		public void closeConnection ()
		{
			connection.Close();
		}
	}
}

