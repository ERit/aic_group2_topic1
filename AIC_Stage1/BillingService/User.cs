using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;


namespace BillingService
{
    public class User
    {
        private const string TABLE = "users";

        public int id { get; set; }
        public string username { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string company { get; set; }
        public string creditcard { get; set; }
        public DateTime acitveDate { get; set; }
        public DateTime deactiveDate { get; set; }


        public static User getById(int id)
        {
            using (MySqlDriver d = MySqlDriver.getInstance())
            {
                using (MySqlCommand command = d.getCommand())
                {
                    command.CommandText = "SELECT * FROM " + TABLE + " WHERE id=?id";
                    command.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader != null)
                    {
                        if (reader.Read())
                        {
                            User u = new User();
                            u.id = reader.GetInt32("id");
                            u.username = reader.GetString("username");
                            u.firstname = reader.GetString("firstname");
                            u.lastname = reader.GetString("lastname");
                            u.email = reader.GetString("email");
                            u.company = reader.GetString("company");
                            u.creditcard = reader.GetString("creditcard");
                            u.acitveDate = reader.IsDBNull(reader.GetOrdinal("activeDate")) ? DateTime.MinValue : reader.GetDateTime("activeDate");
                            u.deactiveDate = reader.IsDBNull(reader.GetOrdinal("deactiveDate")) ? DateTime.MinValue : reader.GetDateTime("deactiveDate");
                            return u;
                        }
                    }
                }
            }
            return null;
        }


        public static User getByUsername(string username)
        {
            using (MySqlDriver d = MySqlDriver.getInstance())
            {
                using (MySqlCommand command = d.getCommand())
                {
                    command.CommandText = "SELECT * FROM " + TABLE + " WHERE username=?user";
                    command.Parameters.Add("?user", MySqlDbType.String).Value = username;
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader != null)
                    {
                        if (reader.Read())
                        {
                            User u = new User();
                            u.id = reader.GetInt32("id");
                            u.username = reader.GetString("username");
                            u.firstname = reader.GetString("firstname");
                            u.lastname = reader.GetString("lastname");
                            u.email = reader.GetString("email");
                            u.company = reader.GetString("company");
                            u.creditcard = reader.GetString("creditcard");
                            u.acitveDate = reader.IsDBNull(reader.GetOrdinal("activeDate")) ? DateTime.MinValue : reader.GetDateTime("activeDate");
                            u.deactiveDate = reader.IsDBNull(reader.GetOrdinal("deactiveDate")) ? DateTime.MinValue : reader.GetDateTime("deactiveDate");
                            return u;
                        }
                    }
                }
            }
            return null;
        }
    }
}