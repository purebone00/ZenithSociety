namespace ZenithSociety_MichaelJung_AlbertChen.Migrations.ZenithSocietyMigrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ZenithDataLib;

    internal sealed class Configuration : DbMigrationsConfiguration<ZenithDataLib.ApplicationDbContext>
    {
        public const string ROLE_ADMIN = "Admin";
        public const string ROLE_USER = "User";

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
            UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            createRole(context);

            creatingUser("a","a@a.a", "P@$$w0rd",ROLE_ADMIN, userManager);
            creatingUser("m", "m@m.m", "P@$$w0rd", ROLE_USER, userManager);

            context.Activities.AddOrUpdate(f => new { f.ActivityDescription, f.CreationDate }, getActivites());
            context.SaveChanges();
        }

        private Activity[] getActivites()
        {
            List<Activity> activities = new List<Activity>()
            {
                new Activity()
                {
                    ActivityDescription = "Senior's Golf Tournament",
                    CreationDate = new DateTime(2017, 1, 30)
                },
                new Activity()
                {
                    ActivityDescription = "Leadership General Assembly Meeting",
                    CreationDate = new DateTime(2017, 1, 30)
                },
                new Activity()
                {
                    ActivityDescription = "Youth Bowling Tournament",
                    CreationDate = new DateTime(2017, 1, 30)
                },
                new Activity()
                {
                    ActivityDescription = "Young ladies cooking lessons",
                    CreationDate = new DateTime(2017, 1, 30)
                },
                new Activity()
                {
                    ActivityDescription = "Youth Craft lessons",
                    CreationDate = new DateTime(2017, 1, 30)
                },
                new Activity()
                {
                    ActivityDescription = "Youth Choir practice",
                    CreationDate = new DateTime(2017, 1, 30)
                },
                new Activity()
                {
                    ActivityDescription = "Lunch",
                    CreationDate = new DateTime(2017, 1, 30)
                },
                new Activity()
                {
                    ActivityDescription = "Pancake Breakfast",
                    CreationDate = new DateTime(2017, 1, 30)
                },
                new Activity()
                {
                    ActivityDescription = "Swimming lessons for the youth",
                    CreationDate = new DateTime(2017, 1, 30)
                },
                new Activity()
                {
                    ActivityDescription = "Swimming exercise for parents",
                    CreationDate = new DateTime(2017, 1, 30)
                },
                new Activity()
                {
                    ActivityDescription = "Bingo Tournament",
                    CreationDate = new DateTime(2017, 1, 30)
                },
                new Activity()
                {
                    ActivityDescription = "BBQ Lunch",
                    CreationDate = new DateTime(2017, 1, 30)
                },
                new Activity()
                {
                    ActivityDescription = "Garage Sale",
                    CreationDate = new DateTime(2017, 1, 30)
                }
            };

            return activities.ToArray();
        }

        private Event[] getEvents() 
        {
            List < Event > events = new List<Event>()
            {

            };
            return events.ToArray();
        }

        private void createRole(DbContext context)
        {
            RoleManager <IdentityRole> roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            if (!roleManager.RoleExists(ROLE_ADMIN))
            {
                var roleResult = roleManager.Create(new IdentityRole(ROLE_ADMIN));
            }
            if (!roleManager.RoleExists(ROLE_USER))
            {
                var roleResult = roleManager.Create(new IdentityRole(ROLE_USER));
            }

            
        }

        private void creatingUser(string userName, string email, string passWord, string role,  UserManager<ApplicationUser> userManager)
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
