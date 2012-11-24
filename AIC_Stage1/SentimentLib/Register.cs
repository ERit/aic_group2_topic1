using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SentimentLib
{
    class Register
    {
        MySqlDriver driver;

        public Register()
		{
			// driver = MySqlDriver.getInstance();
			driver = new MySqlDriver();
		}

        /*
            INSERT INTO `users` 
            (`id`,`username`,`password`,`firstname`,`lastname`,`email`,`creditcard`,`company`)
            VALUES (1,'max','3720f54e919b22cce392b05de57102dd','Max','Mustermann','max.mustermann@tuwien.ac.at',
            '123ert-123645-456fdvfv-678sdfd','Apple');
        */
        public Boolean saveUserInDb(string username, string password, string firstname, string lastname, 
            string email, string creditcard, string company)
        {
            Authenticator auth = new Authenticator();

            string cmdText = "INSERT INTO users (`username`,`password`,`firstname`,`lastname`,`email`,`creditcard`,`company`)" + 
                "VALUES (?username ,?password, ?firstname, ?lastname, ?email, ?creditcard, ?company);";

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
    }
}
