using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorldMVC.Controllers
{
    public class ContactController : Controller
    {
		public List<User> GetAllList()
		{
			var users = new List<User>();
			for (int i = 1; i <= 100; i++)
			{
				var user = new User();
				user.Id = i;
				user.Name = "李医理";
				user.Email = "lkljlksjflsjf@126.com";
				users.Add(user);
			}

			return users;
		}
    }
}