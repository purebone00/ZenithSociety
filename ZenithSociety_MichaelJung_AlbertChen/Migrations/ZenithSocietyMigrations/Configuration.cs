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
                new Activity()
                {
                    ActivityDescription = "Senior's Golf Tournament",
                    CreationDate = new DateTime(2017, 04, 01, 08, 30, 00)
                },

                new Activity()
                {
                    ActivityDescription = "Leadership General Assembly Meeting",
                    CreationDate = new DateTime(2017, 04, 02, 08, 30, 00)
                },

                new Activity()
                {
                    ActivityDescription = "Youth Bowling Tournament",
                    CreationDate = new DateTime(2017, 04, 03, 08, 30, 00)
                },

                new Activity()
                {
                    ActivityDescription = "Young ladies cooking lessons",
                    CreationDate = new DateTime(2017, 04, 04, 08, 30, 00)
                },

                new Activity()
                {
                    ActivityDescription = "Youth craft lessons",
                    CreationDate = new DateTime(2017, 04, 05, 08, 30, 00)
                },

                new Activity()
                {
                    ActivityDescription = "Youth choir practice",
                    CreationDate = new DateTime(2017, 04, 05, 08, 30, 00)
                },

                new Activity()
                {
                    ActivityDescription = "Lunch",
                    CreationDate = new DateTime(2017, 04, 05, 08, 30, 00)
                },

                new Activity()
                {
                    ActivityDescription = "Pancake Breakfast",
                    CreationDate = new DateTime(2017, 04, 06, 08, 30, 00)
                },

                new Activity()
                {
                    ActivityDescription = "Swimming Lessons for the youth",
                    CreationDate = new DateTime(2017, 04, 06, 09, 30, 00)
                },

                new Activity()
                {
                    ActivityDescription = "Swimming Exercise for parents",
                    CreationDate = new DateTime(2017, 04, 06, 10, 30, 00)
                },

                new Activity()
                {
                    ActivityDescription = "Bingo Tournament",
                    CreationDate = new DateTime(2017, 04, 06, 11, 30, 00)
                },

                new Activity()
                {
                    ActivityDescription = "BBQ Lunch",
                    CreationDate = new DateTime(2017, 04, 06, 12, 30, 00)
                },

                new Activity()
                {
                    ActivityDescription = "Garage Sale",
                    CreationDate = new DateTime(2017, 04, 06, 13, 30, 00)
                },
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
                ActivityId    = db.Activities.FirstOrDefault(a => a.ActivityDescription == "Seniors Golf Tournament").ActivityId,
                EnteredBy     = "a",
                CreatedTime   = new DateTime(2017, 04, 01, 08, 30, 00),
                IsActive      = true
                },

                new Event()
                {
                StartDateTime = new DateTime(2017, 04, 05, 08, 30 ,00),
                EndDateTime   = new DateTime(2017, 04, 05, 10, 30, 00),
                ActivityId      = db.Activities.FirstOrDefault(a => a.ActivityDescription == "Leadership General Assembly Meeting").ActivityId,
                EnteredBy     = "a",
                CreatedTime   = new DateTime(2017, 04, 02, 08, 30, 00),
                IsActive      = true
                },

                new Event()
                {
                StartDateTime = new DateTime(2017, 04, 07, 17, 30 ,00),
                EndDateTime   = new DateTime(2017, 04, 07, 19, 15, 00),
                ActivityId      = db.Activities.FirstOrDefault(a => a.ActivityDescription == "Youth Bowling Tournament").ActivityId,
                EnteredBy     = "a",
                CreatedTime   = new DateTime(2017, 04, 03, 08, 30, 00),
                IsActive      = true
                },

                new Event()
                {
                StartDateTime = new DateTime(2017, 04, 07, 19, 00 ,00),
                EndDateTime   = new DateTime(2017, 04, 07, 20, 00, 00),
                ActivityId      = db.Activities.FirstOrDefault(a => a.ActivityDescription == "Young ladies cooking lessons").ActivityId,
                EnteredBy     = "a",
                CreatedTime   = new DateTime(2017, 04, 04, 08, 30, 00),
                IsActive      = true
                },

                new Event()
                {
                StartDateTime = new DateTime(2017, 04, 08, 08, 30 ,00),
                EndDateTime   = new DateTime(2017, 04, 08, 10, 30, 00),
                ActivityId      = db.Activities.FirstOrDefault(a => a.ActivityDescription == "Youth craft lessons").ActivityId,
                EnteredBy     = "a",
                CreatedTime   = new DateTime(2017, 04, 05, 08, 30, 00),
                IsActive      = true
                },

                new Event()
                {
                StartDateTime = new DateTime(2017, 04, 08, 10, 30 ,00),
                EndDateTime   = new DateTime(2017, 04, 08, 12, 00, 00),
                ActivityId      = db.Activities.FirstOrDefault(a => a.ActivityDescription == "Youth choir practice").ActivityId,
                EnteredBy     = "a",
                CreatedTime   = new DateTime(2017, 04, 05, 08, 30, 00),
                IsActive      = true
                },

                new Event()
                {
                StartDateTime = new DateTime(2017, 04, 08, 12, 00 ,00),
                EndDateTime   = new DateTime(2017, 04, 08, 12, 30, 00),
                ActivityId      = db.Activities.FirstOrDefault(a => a.ActivityDescription == "Lunch").ActivityId,
                EnteredBy     = "a",
                CreatedTime   = new DateTime(2017, 04, 05, 08, 30, 00),
                IsActive      = true
                },

                new Event()
                {
                StartDateTime = new DateTime(2017, 04, 09, 07, 30 ,00),
                EndDateTime   = new DateTime(2017, 04, 09, 08, 30, 00),
                ActivityId      = db.Activities.FirstOrDefault(a => a.ActivityDescription == "Pancake Breakfast").ActivityId,
                EnteredBy     = "a",
                CreatedTime   = new DateTime(2017, 04, 06, 08, 30, 00),
                IsActive      = true
                },

                new Event()
                {
                StartDateTime = new DateTime(2017, 04, 09, 08, 30 ,00),
                EndDateTime   = new DateTime(2017, 04, 09, 10, 30, 00),
                ActivityId      = db.Activities.FirstOrDefault(a => a.ActivityDescription == "Swimming Lessons for the youth").ActivityId,
                EnteredBy     = "a",
                CreatedTime   = new DateTime(2017, 04, 06, 09, 30, 00),
                IsActive      = true
                },

                new Event()
                {
                StartDateTime = new DateTime(2017, 04, 09, 08, 30 ,00),
                EndDateTime   = new DateTime(2017, 04, 09, 10, 30, 00),
                ActivityId      = db.Activities.FirstOrDefault(a => a.ActivityDescription == "Swimming Exercise for parents").ActivityId,
                EnteredBy     = "a",
                CreatedTime   = new DateTime(2017, 04, 06, 10, 30, 00),
                IsActive      = true
                },

                new Event()
                {
                StartDateTime = new DateTime(2017, 04, 09, 10, 30 ,00),
                EndDateTime   = new DateTime(2017, 04, 09, 12, 00, 00),
                ActivityId      = db.Activities.FirstOrDefault(a => a.ActivityDescription == "Bingo Tournament").ActivityId,
                EnteredBy     = "a",
                CreatedTime   = new DateTime(2017, 04, 06, 11, 30, 00),
                IsActive      = true
                },

                new Event()
                {
                StartDateTime = new DateTime(2017, 04, 09, 12, 00 ,00),
                EndDateTime   = new DateTime(2017, 04, 09, 13, 00, 00),
                ActivityId      = db.Activities.FirstOrDefault(a => a.ActivityDescription == "BBQ Lunch").ActivityId,
                EnteredBy     = "a",
                CreatedTime   = new DateTime(2017, 04, 06, 12, 30, 00),
                IsActive      = true
                },

                new Event()
                {
                StartDateTime = new DateTime(2017, 04, 09, 13, 00 ,00),
                EndDateTime   = new DateTime(2017, 04, 09, 18, 00, 00),
                ActivityId      = db.Activities.FirstOrDefault(a => a.ActivityDescription == "Garage Sale").ActivityId,
                EnteredBy     = "a",
                CreatedTime   = new DateTime(2017, 04, 06, 13, 30, 00),
                IsActive      = true
                },
            };
            return events.ToArray();
        }
    }
}
