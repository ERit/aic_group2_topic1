using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;


namespace aic_topic1_stage1
{
	public class Authenticator
	{
		public Authenticator ()
		{
		}

		public Boolean validateLogin (string username, string password)
		{
			UserDao userdao = new UserDao ();
			
			List<User> users = userdao.getUsersFromDb ();

			foreach (User user in users) {

				if(user.getUsername() == username && user.getPassword() == GetMD5Hash(password)) {

					return true;
				}
			}

			return false;
		}

		private string GetMD5Hash(string TextToHash)
		{
			if(string.IsNullOrEmpty(TextToHash))
			{
				return string.Empty;
			}

			MD5 md5Hasher = MD5.Create();
			return BitConverter.ToString(md5Hasher.ComputeHash(Encoding.Default.GetBytes(TextToHash))).Replace("-","").ToLower();
		} 
	}
}

