namespace ZenithWebSite.Migrations.Identity
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ZenithDataLib.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ZenithDataLib.Models.ApplicationDbContext>
    {
        public const string ROLE_ADMIN = "Admin";
        public const string ROLE_USER = "User";

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Identity";
        }

        protected override void Seed(ZenithDataLib.Models.ApplicationDbContext context)
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
            UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            createRole(context);

            creatingUser("a", "a@a.a", "P@$$w0rd", ROLE_ADMIN, userManager);
            creatingUser("m", "m@m.m", "P@$$w0rd", ROLE_USER, userManager);

            context.Activities.AddOrUpdate(f => new { f.ActivityDescription, f.CreationDate }, getActivites());
            context.SaveChanges();

            context.Events.AddOrUpdate(f => new { f.EventDate, f.CreatedTime, f.StartDateTime, f.EndDateTime, f.EnteredBy, f.IsActive }, getEvents(context));
            context.SaveChanges();
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
                EventDate     = new DateTime(2017, 04, 04),
                CreatedTime   = new DateTime(2017, 04, 01, 08, 30, 00),
                StartDateTime = new DateTime(2017, 04, 04, 08, 30 ,00),
                EndDateTime   = new DateTime(2017, 04, 04, 10, 30, 00),
                EnteredBy     = "a",
                IsActive      = true,
                ActivityId    = db.Activities.FirstOrDefault(f => f.ActivityDescription == "Senior's Golf Tournament").ActivityId
                },

                new Event()
                {
                EventDate     = new DateTime(2017, 04, 05),
                CreatedTime   = new DateTime(2017, 04, 02, 08, 30, 00),
                StartDateTime = new DateTime(2017, 04, 05, 08, 30 ,00),
                EndDateTime   = new DateTime(2017, 04, 05, 10, 30, 00),
                EnteredBy     = "a",
                IsActive      = true,
                ActivityId    = db.Activities.FirstOrDefault(f => f.ActivityDescription == "Leadership General Assembly Meeting").ActivityId
                },

                new Event()
                {
                EventDate     = new DateTime(2017, 04, 07),
                CreatedTime   = new DateTime(2017, 04, 03, 08, 30, 00),
                StartDateTime = new DateTime(2017, 04, 07, 17, 30 ,00),
                EndDateTime   = new DateTime(2017, 04, 07, 19, 15, 00),
                EnteredBy     = "a",
                IsActive      = true,
                ActivityId    = db.Activities.FirstOrDefault(f => f.ActivityDescription == "Youth Bowling Tournament").ActivityId
                },

                new Event()
                {
                EventDate     = new DateTime(2017, 04, 07),
                CreatedTime   = new DateTime(2017, 04, 04, 08, 30, 00),
                StartDateTime = new DateTime(2017, 04, 07, 19, 00 ,00),
                EndDateTime   = new DateTime(2017, 04, 07, 20, 00, 00),
                EnteredBy     = "a",
                IsActive      = true,
                ActivityId    = db.Activities.FirstOrDefault(f => f.ActivityDescription == "Young ladies cooking lessons").ActivityId
                },

                new Event()
                {
                EventDate     = new DateTime(2017, 04, 08),
                CreatedTime   = new DateTime(2017, 04, 05, 08, 30, 00),
                StartDateTime = new DateTime(2017, 04, 08, 08, 30 ,00),
                EndDateTime   = new DateTime(2017, 04, 08, 10, 30, 00),
                EnteredBy     = "a",
                IsActive      = true,
                ActivityId    = db.Activities.FirstOrDefault(f => f.ActivityDescription == "Youth craft lessons").ActivityId
                },

                new Event()
                {
                EventDate     = new DateTime(2017, 04, 08),
                CreatedTime   = new DateTime(2017, 04, 05, 08, 30, 00),
                StartDateTime = new DateTime(2017, 04, 08, 10, 30 ,00),
                EndDateTime   = new DateTime(2017, 04, 08, 12, 00, 00),
                EnteredBy     = "a",
                IsActive      = true,
                ActivityId    = db.Activities.FirstOrDefault(f => f.ActivityDescription == "Youth choir practice").ActivityId
                },

                new Event()
                {
                EventDate     = new DateTime(2017, 04, 08),
                CreatedTime   = new DateTime(2017, 04, 05, 08, 30, 00),
                StartDateTime = new DateTime(2017, 04, 08, 12, 00 ,00),
                EndDateTime   = new DateTime(2017, 04, 08, 12, 30, 00),
                EnteredBy     = "a",
                IsActive      = true,
                ActivityId    = db.Activities.FirstOrDefault(f => f.ActivityDescription == "Lunch").ActivityId
                },

                new Event()
                {
                EventDate     = new DateTime(2017, 04, 08),
                CreatedTime   = new DateTime(2017, 04, 05, 08, 30, 00),
                StartDateTime = new DateTime(2017, 04, 09, 07, 30 ,00),
                EndDateTime   = new DateTime(2017, 04, 09, 08, 30, 00),
                EnteredBy     = "a",
                IsActive      = true,
                ActivityId    = db.Activities.FirstOrDefault(f => f.ActivityDescription == "Youth choir practice").ActivityId
                },
            };
            return events.ToArray();
        }

        private void createRole(DbContext context)
        {
            RoleManager<IdentityRole> roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            if (!roleManager.RoleExists(ROLE_ADMIN))
            {
                var roleResult = roleManager.Create(new IdentityRole(ROLE_ADMIN));
            }
            if (!roleManager.RoleExists(ROLE_USER))
            {
                var roleResult = roleManager.Create(new IdentityRole(ROLE_USER));
            }


        }

        private void creatingUser(string userName, string email, string passWord, string role, UserManager<ApplicationUser> userManager)
        {
            ApplicationUser user = userManager.FindByName(userName);
            if (user == null)
            {
                user = new ApplicationUser()
                {
                    UserName = userName,
                    Email = email,
                    EmailConfirmed = true
                };
                IdentityResult userResult = userManager.Create(user, passWord);
                if (userResult.Succeeded)
                {
                    var result = userManager.AddToRole(user.Id, role);
                }
            }
        }
    }
}
