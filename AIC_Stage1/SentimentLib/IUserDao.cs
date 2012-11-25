using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SentimentLib
{
    [ServiceContract]
    public interface IUserDao
    {
        [OperationContract]
        List<User> getUsersFromDb();

        [OperationContract]
        string getCompanyFromUser(string username);

        [OperationContract]
        Boolean register(string username, string password, string firstname, string lastname,
            string email, string creditcard, string company);

        [OperationContract]
        Boolean unregister(string username);
    }
}
