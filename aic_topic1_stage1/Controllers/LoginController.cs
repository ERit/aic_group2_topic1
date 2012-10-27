using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace aic_topic1_stage1.Controllers
{
	public class LoginController : Controller
	{
		public ActionResult Index (FormCollection formCollection)
		{
			Authenticate auth = new Authenticate ();

			if (auth.validateLogin (formCollection ["user_name"], formCollection ["user_password"])) {

				return Redirect("/Overview");

			} else {

				TempData["loginFailed"] = "Wrong username or password.";
				return Redirect("/");
			}
		}
	}
}

