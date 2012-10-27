using System;

namespace aic_topic1_stage1
{
	public class User
	{
		private string username;
		private string password;


		public string getUsername ()
		{
			return username;
		}

		public string getPassword ()
		{
			return password;
		}

		public void setUsername (string username)
		{
			this.username = username;
		}
		
		public void setPassword (string password)
		{
			this.password = password;
		}
	}
}

