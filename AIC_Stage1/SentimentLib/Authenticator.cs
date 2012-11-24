using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;


namespace SentimentLib
{
    public class Authenticator:IAuthenticator
    {
        Boolean loggedIn;
        UserDao userdao;

        public Authenticator()
        {
            userdao = new UserDao();
        }

        public Boolean validateLogin(string username, string password)
        {
            List<User> users = userdao.getUsersFromDb();

            foreach (User user in users)
            {
                if (user.getUsername() == username && user.getPassword() == GetMD5Hash(password))
                {

                    loggedIn = true;

                    return true;
                }
            }

            return false;
        }

        public Boolean isLoggedIn()
        {
            return loggedIn;
        }

        public string GetMD5Hash(string TextToHash)
        {
            if (string.IsNullOrEmpty(TextToHash))
            {
                return string.Empty;
            }

            MD5 md5Hasher = MD5.Create();
            return BitConverter.ToString(md5Hasher.ComputeHash(Encoding.Default.GetBytes(TextToHash))).Replace("-", "").ToLower();
        }


        public string getCompanyFromUsername(string username)
        {
            return userdao.getCompanyFromUser(username);
        }
    }
}

