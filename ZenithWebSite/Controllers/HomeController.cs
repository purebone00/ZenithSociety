using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZenithDataLib.Models;

using System.Net;
using ZenithWebSite.Utility;


namespace ZenithWebSite.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        

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
      
        public class EventActivityModel
        {
            public Event Event { get; set; }
            public Activity Activity { get; set; }
        }

        /* testing purposes to pass the data to view
        public ActionResult Index()
        {
            var x = from e in db.Events
                    join a in db.Activities on e.ActivityId equals a.ActivityId
                    select a;
                   
            return View(x.ToList());
        } */
    }
}