using Piofthings.Data.Migrations;
using Piofthings.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piofthings.Data.Contexts
{
    public class DeviceContext : DbContext
    {
        public DeviceContext():base("DefaultConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DeviceContext, Configuration>());
        }

        public DbSet<Device> Devices { get; set; }
    }
}
