using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;


namespace aic_topic1_stage1
{
	public class UserDao
	{
		MySqlDriver driver;
		
		public UserDao ()
		{
			// driver = MySqlDriver.getInstance();
			driver = new MySqlDriver();
		}
		
		public List<User> getUsersFromDb ()
		{
			MySqlCommand command = driver.getCommand();
			
			command.CommandText = "SELECT * FROM users";
			
			List<User> list = new List<User>();
			
			MySqlDataReader Reader = command.ExecuteReader();
			while (Reader.Read())
			{
				User user = new User();
				user.setUsername(Reader.GetValue(1).ToString());
				user.setPassword(Reader.GetValue(2).ToString());
				list.Add(user);
			}
			
			return list;
		}

		public Boolean saveUserInDb (string username, string password)
		{
			Authenticator auth = new Authenticator();

			string cmdText = "INSERT INTO users (username ,password) VALUES (?username ,?password);";

			MySqlCommand command = new MySqlCommand(cmdText, driver.getConnection());

			command.Parameters.Add("?username", MySqlDbType.VarChar).Value = username;
			command.Parameters.Add("?password", MySqlDbType.VarChar).Value = auth.GetMD5Hash(password);

			if(command.ExecuteNonQuery() == 1)
				return true;
			else
				return false;
		}
	}
}

