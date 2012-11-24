using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SentimentLib
{
    [ServiceContract]
    public interface IAuthenticator
    {
        [OperationContract]
        Boolean validateLogin(string username, string password);

        [OperationContract]
        string getCompanyFromUsername(string username);

        string GetMD5Hash(string TextToHash);

        [OperationContract]
        Boolean isLoggedIn();
    }
}
