using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CCC_JB_10793878.Models
{
    public class CCC_JB_10793878Db : IdentityDbContext<ApplicationUser>
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public CCC_JB_10793878Db() : base("name=CCC_JB_10793878Db")
        {
        }

        public static CCC_JB_10793878Db Create()
        {
            return new CCC_JB_10793878Db();
        }

        public System.Data.Entity.DbSet<JB_Final_Project.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<JB_Final_Project.Models.SiteRole> SiteRoles { get; set; }
    }
}
