using EmlakOfisi.Entities.Mappings;
using EmlakOfisi.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakOfisi.Dal.Concrete.EntityFramework.Context
{
    public class EmlakOfisiContext : DbContext
    {
        public EmlakOfisiContext()
        : base("EmlakOfisiContext")
        {
        }

        public virtual DbSet<Adress> Adress { get; set; }
        public virtual DbSet<Agent> Agent { get; set; }
        public virtual DbSet<Property> Property { get; set; }
        public virtual DbSet<User> User { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new AdressMap());
            modelBuilder.Configurations.Add(new AgentMap());
            modelBuilder.Configurations.Add(new PropertyMap());
            base.OnModelCreating(modelBuilder);
        }
    }



}
