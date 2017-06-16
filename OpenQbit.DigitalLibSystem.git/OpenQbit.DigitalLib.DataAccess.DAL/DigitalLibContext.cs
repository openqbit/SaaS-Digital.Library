using OpenQbit.DigitalLib.Common.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.DigitalLib.DataAccess.DAL
{
    public class DigitalLibContext : DbContext
    {
        public DigitalLibContext() : base("DigitalLibContext")
        {
            this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<DigitalItem> DigitalItems { get; set; }

        public DbSet<MultimediaType> MultimediaType { get; set; }

        public DbSet<ResourcePath> ResourcePath { get; set; }

        public DbSet<Systems> System { get; set; }

        public DbSet<SystemPaths> SystemPath { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
