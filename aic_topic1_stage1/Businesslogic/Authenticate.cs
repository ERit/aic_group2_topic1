using System;

namespace aic_topic1_stage1
{
	public class Authenticate
	{
		public Authenticate ()
		{
		}

		public Boolean validateLogin (string username, string password)
		{
			Authenticator auth = new Authenticator();

			return auth.validateLogin(username, password);
		}
	}
}

