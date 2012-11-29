using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StatisticService
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
                return "";
            }
        }

        private int getIdFromUsername(string username)
        {
            int id = 0;

            MySqlCommand command = driver.getCommand();
            command.CommandText = "SELECT id FROM users WHERE username=?username";
            command.Parameters.Add("?username", MySqlDbType.VarChar).Value = username;

            MySqlDataReader print = command.ExecuteReader();
            
            while (print.Read())
            {
                id = Convert.ToInt32(print.GetValue(0).ToString());
            }
            print.Close();

            return id;
        }


        private int getCompanyFromUsername(string username)
        {
            int id = 0;

            MySqlCommand command = driver.getCommand();
            command.CommandText = "SELECT company FROM users WHERE username=?username";
            command.Parameters.Add("?username", MySqlDbType.VarChar).Value = username;

            MySqlDataReader print = command.ExecuteReader();

            while (print.Read())
            {
                id = Convert.ToInt32(print.GetValue(0).ToString());
            }
            print.Close();
            return id;
        }


        public void addStatisticCall(string username)
        {
            //insert into statcalls (username, call_time) values ('blub', CURDATE());
            string cmdText = "INSERT into statcalls(`username`, `call_time`) VALUES (?username ,?call_time)";

            MySqlCommand command = new MySqlCommand(cmdText, driver.getConnection());

            command.Parameters.Add("?username", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("?call_time", MySqlDbType.DateTime).Value = DateTime.Now;

            command.ExecuteNonQuery();
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
