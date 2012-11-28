using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SentimentLib
{
    public interface IUserDao
    {
        List<User> getUsersFromDb();

        string getCompanyFromUser(string username);

        void addStatisticCall(string username);

        Boolean register(string username, string password, string firstname, string lastname,
            string email, string creditcard, string company);

        Boolean unregister(string username);
    }
}
