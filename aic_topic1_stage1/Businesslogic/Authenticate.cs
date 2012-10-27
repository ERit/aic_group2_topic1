using System;

namespace aic_topic1_stage1
{
	public class Authenticate
	{
		Authenticator auth;
		
		public Authenticate ()
		{
			auth = new Authenticator();
		}

		public Boolean validateLogin (string username, string password)
		{
			Boolean loggedIn = auth.validateLogin(username, password);

			// store user in session
			//TODO

			return loggedIn;
		}

		public Boolean isLoggedIn ()
		{
			// get user from session and check if logged in
			//TODO

			return auth.isLoggedIn();
		}
	}
}

