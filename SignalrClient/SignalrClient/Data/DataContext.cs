using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SignalrClient.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("dbConnectionString")
        {
            Database.SetInitializer<DataContext>(new CreateDatabaseIfNotExists<DataContext>());
        }

        public DbSet<Employee> Employees { get; set; }
    }
}