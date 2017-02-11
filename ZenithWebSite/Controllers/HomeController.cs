using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using ZenithDataLib.Models;
using ZenithSociety.Utility;

namespace ZenithWebSite.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        
        public ActionResult Index()
        {
            var firstdayOfThisWeek = DateTime.Now.FirstDayOfWeek();
            var lastdayOfThisWeek = DateTime.Now.LastDayOfWeek();

            var ActivityEventsList = from e in db.Events
                                     join a in db.Activities on e.ActivityId equals a.ActivityId
                                     where (e.StartDateTime >= firstdayOfThisWeek)
                                     && (e.StartDateTime < lastdayOfThisWeek)
                                     && (e.IsActive == true)
                                     orderby (e.CreatedTime)
                                     select new EventActivityModel { Event = e, Activity = a };
    
            return View(ActivityEventsList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public class EventActivityModel
        {
            public Event Event { get; set; }
            public Activity Activity { get; set; }
        }
    }
}