using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace aic_topic1_stage1.Controllers
{
	public class RegisterController : Controller
	{
		public ActionResult Index (FormCollection formCollection)
		{

			//TODO: delete the ifs?

			if (formCollection ["user_name"] == "" && formCollection ["user_password"] == "" && formCollection ["user_password2"] == "")
				return View ();

			if (formCollection ["user_name"] != "" && formCollection ["user_password"] != "" && formCollection ["user_password2"] == "") {

				TempData ["register_output"] = "Please type password again.";
				return Redirect ("/Register");
			}

			if (formCollection ["user_name"] == "") {
				
				TempData ["register_output"] = "Please enter a valid username.";
				return Redirect ("/Register");
			}

			if (formCollection ["user_password"] == "" || formCollection ["user_password2"] == "") {

				TempData ["register_output"] = "Please enter a password.";
				return Redirect ("/Register");
			}



			if (formCollection ["user_name"] != null && formCollection ["user_password"] != null && formCollection ["user_password2"] != null) {

				Register reg = new Register ();

				if (formCollection ["user_password"] == formCollection ["user_password2"]) {

					if(!reg.registerUser (formCollection ["user_name"], formCollection ["user_password"])) {

						//TODO: registration failed
					}
					else {

						//TODO: registration succeeded: redirect to billing?
					}
				}
			}

			return View ();
		}
	}
}

