using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace aic_topic1_stage1
{
	public class MySqlDriver
	{
		MySqlConnection connection;

		public MySqlDriver ()
		{
			string myConnectionString = "SERVER=localhost;" +
				"DATABASE=aic_group2_topic1;" +
					"UID=root;" +
					"PASSWORD=;";

			connection = new MySqlConnection(myConnectionString);
			connection.Open();
		}

		public MySqlCommand getCommand ()
		{
			return connection.CreateCommand();
		}

		public void closeConnection ()
		{
			connection.Close();
		}
	}
}

