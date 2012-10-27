using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace aic_topic1_stage1.Controllers
{
	public class Register : Controller
	{
		public Boolean registerUser (string username, string password)
		{
			UserDao userdao = new UserDao ();

			//TODO: filter username special characters



			return userdao.saveUserInDb(username, password);
		}
	}
}

