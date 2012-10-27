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

				Console.WriteLine ("logged in");
			} else {
				Console.WriteLine ("failure");
			}

			foreach (string _formData in formCollection)
			{
				ViewData[_formData] = formCollection[_formData];
			}

			return View ();
		}
	}
}

