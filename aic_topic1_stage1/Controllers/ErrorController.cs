using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace aic_topic1_stage1.Controllers
{
	public class ErrorController : Controller
	{
		public ActionResult FailWhale ()
		{
			Response.StatusCode = 404;
			Response.TrySkipIisCustomErrors = true;
			return View ();
		}
	}
}

