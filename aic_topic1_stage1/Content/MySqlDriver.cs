using System;
using MySql.Data.MySqlClient;

namespace aic_topic1_stage1
{
	public class MySqlDriver
	{
		public MySqlDriver ()
		{
		}

		public void Connect ()
		{
			string myConnectionString = "SERVER=localhost;" +
				"DATABASE=aic_group2_topic1;" +
					"UID=root;" +
					"PASSWORD=;";
			
			MySqlConnection connection = new MySqlConnection(myConnectionString);
			MySqlCommand command = connection.CreateCommand();
			command.CommandText = "SELECT * FROM users";
			MySqlDataReader Reader;
			connection.Open();
			Reader = command.ExecuteReader();
			while (Reader.Read())
			{
				string row = "";
				for (int i = 0; i < Reader.FieldCount; i++)
					row += Reader.GetValue(i).ToString() + ", ";
				Console.WriteLine(row);
			}
			connection.Close();
		}
	}
}

