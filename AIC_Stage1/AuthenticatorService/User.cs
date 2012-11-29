using System;

namespace AuthenticatorService
{
    public class User
    {
        private string username;
        private string password;


        public string getUsername()
        {
            return username;
        }

        public string getPassword()
        {
            return password;
        }

        public void setUsername(string username)
        {
            this.username = username;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }
    }
}

