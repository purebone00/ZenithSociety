namespace ZenithSociety_MichaelJung_AlbertChen.Migrations.ZenithSocietyMigrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ZenithDataLib;

    internal sealed class Configuration : DbMigrationsConfiguration<ZenithDataLib.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\ZenithSocietyMigrations";
        }

        protected override void Seed(ZenithDataLib.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //


        }

        private Activity[] getActivites()
        {
            List<Activity> activities = new List<Activity>()
            {

            };

            return activities.ToArray();
        }

        private Event[] getEvents(ApplicationDbContext db) 
        {
            List<Event> events = new List<Event>()
            {
                new Event()
                { 
                StartDateTime = new DateTime(2017, 04, 04, 08, 30 ,00),
                EndDateTime   = new DateTime(2017, 04, 04, 10, 30, 00),
                Activity      = db.Activities.First(a => a.ActivityDescription == "Seniors Golf Tournament"),
                EnteredBy     = db.Users.First(a => a.UserName == 'a'),
                CreatedTime   = new DateTime(2017, 04, 01, 08, 30, 00),
                IsActive      = true
                },

                new Event()
                {
                StartDateTime = new DateTime(2017, 04, 05, 08, 30 ,00),
                EndDateTime   = new DateTime(2017, 04, 05, 10, 30, 00),
                Activity      = db.Activities.First(a => a.ActivityDescription == "Leadership General Assembly Meeting"),
                EnteredBy     = db.Users.First(a => a.UserName == 'a'),
                CreatedTime   = new DateTime(2017, 04, 02, 08, 30, 00),
                IsActive      = true
                },

                new Event()
                {
                StartDateTime = new DateTime(2017, 04, 07, 17, 30 ,00),
                EndDateTime   = new DateTime(2017, 04, 07, 19, 15, 00),
                Activity      = db.Activities.First(a => a.ActivityDescription == "Youth Bowling Tournament"),
                EnteredBy     = db.Users.First(a => a.UserName == 'a'),
                CreatedTime   = new DateTime(2017, 04, 03, 08, 30, 00),
                IsActive      = true
                },

                new Event()
                {
                StartDateTime = new DateTime(2017, 04, 07, 19, 00 ,00),
                EndDateTime   = new DateTime(2017, 04, 07, 20, 00, 00),
                Activity      = db.Activities.First(a => a.ActivityDescription == "Young ladies cooking lessons"),
                EnteredBy     = db.Users.First(a => a.UserName == 'a'),
                CreatedTime   = new DateTime(2017, 04, 04, 08, 30, 00),
                IsActive      = true
                },

                new Event()
                {
                StartDateTime = new DateTime(2017, 04, 08, 08, 30 ,00),
                EndDateTime   = new DateTime(2017, 04, 08, 10, 30, 00),
                Activity      = db.Activities.First(a => a.ActivityDescription == "Youth craft lessons"),
                EnteredBy     = db.Users.First(a => a.UserName == 'a'),
                CreatedTime   = new DateTime(2017, 04, 05, 08, 30, 00),
                IsActive      = true
                },

                new Event()
                {
                StartDateTime = new DateTime(2017, 04, 08, 10, 30 ,00),
                EndDateTime   = new DateTime(2017, 04, 08, 12, 00, 00),
                Activity      = db.Activities.First(a => a.ActivityDescription == "Youth choir practice"),
                EnteredBy     = db.Users.First(a => a.UserName == 'a'),
                CreatedTime   = new DateTime(2017, 04, 05, 08, 30, 00),
                IsActive      = true
                },

                new Event()
                {
                StartDateTime = new DateTime(2017, 04, 08, 12, 00 ,00),
                EndDateTime   = new DateTime(2017, 04, 08, 12, 30, 00),
                Activity      = db.Activities.First(a => a.ActivityDescription == "Lunch"),
                EnteredBy     = db.Users.First(a => a.UserName == 'a'),
                CreatedTime   = new DateTime(2017, 04, 05, 08, 30, 00),
                IsActive      = true
                },

                new Event()
                {
                StartDateTime = new DateTime(2017, 04, 09, 07, 30 ,00),
                EndDateTime   = new DateTime(2017, 04, 09, 08, 30, 00),
                Activity      = db.Activities.First(a => a.ActivityDescription == "Youth choir practice"),
                EnteredBy     = db.Users.First(a => a.UserName == 'a'),
                CreatedTime   = new DateTime(2017, 04, 05, 08, 30, 00),
                IsActive      = true
                },
            };
            return events.ToArray();
        }
    }
}
