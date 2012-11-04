using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace aic_topic1_stage1.Controllers
{
	public class StatisticsController : Controller
	{
		public ActionResult Index ()
		{
			ViewData ["Message"] = "";
			Console.WriteLine("\nDebug2\n");
			
			// TODO - get the name of the current logged in firm
			GetStatistic get_stats = new GetStatistic ("Game of Thrones");
			
			return View();
		}
	}
}

