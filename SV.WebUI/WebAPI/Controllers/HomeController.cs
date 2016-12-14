﻿using System.Web.Mvc;

namespace WebAPI.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Title = "Home Page";

			return View();
		}

		public ActionResult GitHub()
		{
			return Redirect("https://github.com/Marusyk/SmartVillageOnline");
		}

		public ViewResult TestDict()
		{
			return View();
		}
	}
}
