using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Knockout_Asp.NetMVC_1.Controllers
{
    public class KnockoutJSOneController : Controller
    {
        // GET: KnockoutJSOne
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Save(Person person)
        {
            if (person.Friends != null)
            {
                var message = string.Format("{0} {1}", person.FirstName, person.LastName);
                message += string.Format(" con {0} amigos.", person.Friends.Count);

                return Json(new { message });
            }

            return Json(new {  });
        }

    }
}