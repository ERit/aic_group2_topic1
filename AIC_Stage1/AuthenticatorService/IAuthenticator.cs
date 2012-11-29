using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AuthenticatorService
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

        [OperationContract]
        Boolean register(string username, string password, string firstname, string lastname,
            string email, string creditcard, string company);

        [OperationContract]
        Boolean unregister(string username);
    }
}
