using System;
using System.Collections.Generic;
using System.Text;
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
            //lets pass the connection string hard coded
            optionsBuilder.UseSqlServer("Server=.;Database=AppDb;Integrated Security=true;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
