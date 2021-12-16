using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users;
        public DbSet<CV> CVs;
        public DbSet<Project> Projects;

        public DataContext() : base("DefaultConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasMany(x => x.CVs)
            .WithOptional(x => x.users)
            .WillCascadeOnDelete(false);
        }
    }
}
