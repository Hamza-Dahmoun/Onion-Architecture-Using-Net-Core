using System;
using System.Collections.Generic;
using System.Text;
using CompanyName.AppName.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace CompanyName.AppName.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext():base()
        {

        }
        public AppDbContext(DbContextOptions options):base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //---> We don't need to pass the connection string anymore because we already passed it when registering
            //db context services inside Startup file<---

            //lets pass the connection string hard coded
            //optionsBuilder.UseSqlServer("Server=.;Database=AppDb;Integrated Security=true;");
            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<Commune> Commune { get; set; }
        public virtual DbSet<Activity> Activity { get; set; }
    }
}
