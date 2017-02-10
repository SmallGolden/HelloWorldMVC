using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace HelloWorldMVC.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			
			var mvcName = typeof(Controller).Assembly.GetName();
			var isMono = Type.GetType("Mono.Runtime") != null;

			ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
			ViewData["Runtime"] = isMono ? "Mono" : ".NET";

			/*
						return View();
						*/

			/*
			var users = new[]
			{
				new User(){Id=1001,Name="张医理",Email="dflkjslfjlsf@126.com"},
				new User(){Id=1001,Name="张医理",Email="dflkjslfjlsf@126.com"},
				new User(){Id=1001,Name="张医理",Email="dflkjslfjlsf@126.com"},
				new User(){Id=1001,Name="张医理",Email="dflkjslfjlsf@126.com"},
				new User(){Id=1001,Name="张医理",Email="dflkjslfjlsf@126.com"},
				new User(){Id=1001,Name="张医理",Email="dflkjslfjlsf@126.com"},
				new User(){Id=1001,Name="张医理",Email="dflkjslfjlsf@126.com"},
				new User(){Id=1001,Name="张医理",Email="dflkjslfjlsf@126.com"}
			};
			*/

			var users = new List<User>();
			for (int i = 1; i <= 100; i++)
			{
				var user = new User();
				user.Id = i;
				user.Name = "李医理";
				user.Email = "lkljlksjflsjf@126.com";
				users.Add(user);
			}

			ViewBag.Users = users;
			ViewBag.Title = "Test";
			return View();
		}
	}
}
