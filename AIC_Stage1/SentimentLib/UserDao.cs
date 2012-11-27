using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SentimentLib
{
    class UserDao:IUserDao
    {
        MySqlDriver driver;

        public UserDao()
		{
			// driver = MySqlDriver.getInstance();
			driver = new MySqlDriver();
		}
		
		public List<User> getUsersFromDb ()
		{
			MySqlCommand command = driver.getCommand();

            command.CommandText = "SELECT * FROM users WHERE isActivated=TRUE";
			
			List<User> list = new List<User>();
			
			MySqlDataReader Reader = command.ExecuteReader();
			while (Reader.Read())
			{
				User user = new User();
				user.setUsername(Reader.GetValue(1).ToString());
				user.setPassword(Reader.GetValue(2).ToString());
				list.Add(user);
			}

            Reader.Close();
			return list;
		}


        public string getCompanyFromUser(string username)
        {

            try
            {
                MySqlCommand command = driver.getCommand();

                command.CommandText = "SELECT company FROM users WHERE username=?username AND isActivated=TRUE";

                command.Parameters.Add("?username", MySqlDbType.VarChar).Value = username;


                MySqlDataReader print = command.ExecuteReader();

                string ret="";
                while (print.Read())
                {
                    ret = print.GetValue(0).ToString();
                }

                print.Close();
                return ret;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetBaseException());
            }

            return "";
        }

        public Boolean register(string username, string password, string firstname, string lastname,
            string email, string creditcard, string company)
        {
            Authenticator auth = new Authenticator();

            string cmdText = "INSERT INTO users (`username`,`password`,`firstname`,`lastname`,`email`,`creditcard`,`company`,`activeDate`,`deactiveDate`,`statistics_count`,`isActivated`)" +
                "VALUES (?username ,?password, ?firstname, ?lastname, ?email, ?creditcard, ?company , NOW(), NULL, 0, TRUE);";

            MySqlCommand command = new MySqlCommand(cmdText, driver.getConnection());

            command.Parameters.Add("?username", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("?password", MySqlDbType.VarChar).Value = auth.GetMD5Hash(password);

            command.Parameters.Add("?firstname", MySqlDbType.VarChar).Value = firstname;
            command.Parameters.Add("?lastname", MySqlDbType.VarChar).Value = lastname;
            command.Parameters.Add("?email", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("?creditcard", MySqlDbType.VarChar).Value = creditcard;
            command.Parameters.Add("?company", MySqlDbType.VarChar).Value = company;

            if (command.ExecuteNonQuery() == 1)
                return true;
            else
                return false;
        }


        public bool unregister(string username)
        {
            // string cmdText = "DELETE FROM users WHERE username=?username";
            string cmdText = "UPDATE users SET isActivated=FALSE, deactiveDate=NOW() WHERE username=?username";

            MySqlCommand command = new MySqlCommand(cmdText, driver.getConnection());

            command.Parameters.Add("?username", MySqlDbType.VarChar).Value = username;

            if (command.ExecuteNonQuery() == 1)
                return true;
            else
                return false;
        }
    }
}
