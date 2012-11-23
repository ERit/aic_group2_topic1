using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SentimentLib
{
    [ServiceContract]
    public interface ILogin
    {
        [OperationContract]
        bool login(string username, string password);

        [OperationContract]
        string getUsername();

    }
}
