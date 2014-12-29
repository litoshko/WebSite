using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace WebSite.Models
{
    public class WebSiteContext : DbContext
    {
        public WebSiteContext()
            : base("WebSiteConnection")
        {
        }

        public DbSet<UserProfile> UserProfile { get; set; }
        public DbSet<Car> Car { get; set; }
        public DbSet<CarRequest> CarRequst { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}