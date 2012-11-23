using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SentimentLib
{
    public class LoginService : ILogin
    {
        private string username;

        public bool login(string username, string password)
        {
            this.username = username;
            return true;
        }

        public string getUsername()
        {
            return this.username;
        }
    }
}
