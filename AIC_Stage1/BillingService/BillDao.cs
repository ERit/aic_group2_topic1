using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace BillingService
{
    public class BillDao
    {
        private const string TABLE = "bill";

        public static Bill getById(int Id)
        {
            using (MySqlDriver d = MySqlDriver.getInstance()) 
            {
                using (MySqlCommand command = d.getCommand()) 
                {
                    command.CommandText = "SELECT * FROM " + TABLE + " WHERE id=?id";
                    command.Parameters.Add("?id", MySqlDbType.Int32).Value = Id;
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader != null)
                    {
                        if (reader.Read())
                        {
                            return new Bill(
                                reader.GetInt32("id"),
                                reader.GetInt32("userId"),
                                reader.GetDouble("price"),
                                reader.GetBoolean("isPayed"),
                                reader.GetDateTime("accountedUntil"),
                                reader.GetDateTime("created"));
                        }
                    }
                }
            }
            return null;
        }

        public static int getQueriesByUser(String userName, DateTime offset)
        {
            using (MySqlDriver d = MySqlDriver.getInstance())
            {
                using (MySqlCommand command = d.getCommand())
                {
                    try
                    {
                        command.CommandText = "SELECT COUNT(*) as count FROM statcalls WHERE username=?userName and call_time>=?offset";
                        command.Parameters.Add("?userName", MySqlDbType.String).Value = userName;
                        command.Parameters.Add("?offset", MySqlDbType.DateTime).Value = offset;
                        MySqlDataReader reader = command.ExecuteReader();
                        if (reader != null)
                        {
                            if (reader.Read())
                            {
                                return reader.GetInt32("count");
                            }
                        }
                    }
                    catch (MySqlException e)
                    {
                        throw new ApplicationException("error in quering DB: " + e.Message);
                    }
                }
            }
            return -1;
        }

        public static IList<Bill> getByUserId(int userId)
        {
            IList<Bill> result = new List<Bill>();
            try
            {
                using (MySqlDriver d = MySqlDriver.getInstance())
                {
                    using (MySqlCommand command = d.getCommand())
                    {
                        command.CommandText = "SELECT * FROM " + TABLE + " WHERE userId=?id order by accountedUntil";
                        command.Parameters.Add("?id", MySqlDbType.Int32).Value = userId;
                        MySqlDataReader reader = command.ExecuteReader();
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                result.Add(new Bill(
                                    reader.GetInt32("id"),
                                    reader.GetInt32("userId"),
                                    reader.GetDouble("price"),
                                    reader.GetBoolean("isPayed"),
                                    reader.GetDateTime("accountedUntil"),
                                    reader.GetDateTime("created")));
                            }
                        }
                    }
                }
            }
            catch (MySqlException e)
            {
                throw new ApplicationException("could not query user, details: " + e.Message);
            }

            return result;
        }


        public static Bill getLastBillForUser(int userId)
        {
            try
            {
                using (MySqlDriver d = MySqlDriver.getInstance())
                {
                    using (MySqlCommand command = d.getCommand())
                    {
                        command.CommandText = "SELECT * FROM " + TABLE + " WHERE userId=?id order by accountedUntil desc limit 1";
                        command.Parameters.Add("?id", MySqlDbType.Int32).Value = userId;
                        MySqlDataReader reader = command.ExecuteReader();
                        if (reader != null)
                        {
                            if (reader.Read())
                            {
                                return new Bill(
                                    reader.GetInt32("id"),
                                    reader.GetInt32("userId"),
                                    reader.GetDouble("price"),
                                    reader.GetBoolean("isPayed"),
                                    reader.GetDateTime("accountedUntil"),
                                    reader.GetDateTime("created"));
                            }
                        }
                    }
                }
            }
            catch (MySqlException e)
            {
                throw new ApplicationException("could not query bill, details: " + e.Message);
            }
            return null;
        }


        public static void insert(Bill b)
        {
            using (MySqlDriver d = MySqlDriver.getInstance())
            {
                using (MySqlCommand command = d.getCommand())
                {
                    command.CommandText = "INSERT INTO " + TABLE + " (userId, price, isPayed, accountedUntil, created) " +
                            "VALUES (?uId, ?price, ?payed, ?acc, ?cre)";
                    command.Parameters.Add("?uId", MySqlDbType.Int32).Value = b.userId;
                    command.Parameters.Add("?price", MySqlDbType.Double).Value = b.price;
                    command.Parameters.Add("?payed", MySqlDbType.Int16).Value = b.isPayed;
                    command.Parameters.Add("?acc", MySqlDbType.DateTime).Value = b.accountedUntil;
                    command.Parameters.Add("?cre", MySqlDbType.DateTime).Value = b.created;
                    try
                    {
                        command.ExecuteNonQuery();
                        b.id = (int) command.LastInsertedId;
                    }
                    catch (MySqlException e)
                    {
                        throw new ArgumentException("could not insert given Bill, details: " + e.Message);
                    }
                }
            }
        }


        public static void update(Bill b)
        {
            using (MySqlDriver d = MySqlDriver.getInstance())
            {
                using (MySqlCommand command = d.getCommand())
                {
                    command.CommandText = "UPDATE " + TABLE + " SET "+
                        "userId=?uId, price=?price, isPayed=?payed, accountedUntil=?acc, created=?cre " +
                        "WHERE id=?id";
                    command.Parameters.Add("?uId", MySqlDbType.Int32).Value = b.userId;
                    command.Parameters.Add("?price", MySqlDbType.Double).Value = b.price;
                    command.Parameters.Add("?payed", MySqlDbType.Int16).Value = b.isPayed;
                    command.Parameters.Add("?acc", MySqlDbType.DateTime).Value = b.accountedUntil;
                    command.Parameters.Add("?cre", MySqlDbType.DateTime).Value = b.created; 
                    command.Parameters.Add("?id", MySqlDbType.Int32).Value = b.id;

                    try
                    {
                        command.ExecuteNonQuery();
                        b.id = (int)command.LastInsertedId;
                    }
                    catch (MySqlException e)
                    {
                        throw new ArgumentException("could not update given Bill, details: " + e.Message);
                    }
                }
            }
        }
    }
}