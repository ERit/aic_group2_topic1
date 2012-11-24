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

            Reader.Close();
			return list;
		}


        public string getCompanyFromUser(string username)
        {

            try
            {
                MySqlCommand command = driver.getCommand();

                command.CommandText = "SELECT company FROM users WHERE username=?username";

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
    }
}
