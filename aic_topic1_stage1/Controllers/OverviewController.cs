using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace aic_topic1_stage1.Controllers
{
	public class OverviewController : Controller
	{
		public ActionResult Index ()
		{
			ViewData ["Message"] = "";
			Console.WriteLine("\nDebug1\n");
			return View();
		}
		
		public ActionResult show_stats ()
		{
			return Redirect("/Statistics");
		}
	}
}

