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
    }
}
