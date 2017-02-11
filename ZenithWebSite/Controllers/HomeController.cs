using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZenithDataLib.Models;

namespace ZenithWebSite.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var x = from e in db.Events
                    join a in db.Activities on e.ActivityId equals a.ActivityId
                    select a;
                   
            return View(x.ToList());
        }
    }
}