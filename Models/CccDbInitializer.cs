using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CCC_JB_10793878.Models
{
    public class CccDbInitializer : DropCreateDatabaseAlways<CCC_JB_10793878Db>
    {
        protected override void Seed(CCC_JB_10793878Db context)
        {
            var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            base.Seed(context);
            context.SaveChanges();

            var user = new ApplicationUser { UserName = "kcrandall@pleasegivemeana.com", Email = "kcrandall@pleasegivemeana.com", SiteRoleId = 1, FirstName = "Kodey", LastName = "Crandall" };

            userManager.Create(user, "QW!@34er");

            roleManager.Create(new IdentityRole("canEdit"));
            userManager.AddToRole(user.Id, "canEdit");
        }
    }
}