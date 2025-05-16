using BootcampHomework.Entities;
using BootcampHomework.Repositories.Concretes.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace BootcampHomework.Repositories.Concretes.Contexts
{
    public class BaseDbContext : DbContext
    {
        public BaseDbContext(DbContextOptions<BaseDbContext> options) : base(options)
        {
        }

        public DbSet<Application> Applications { get; set; }
        public DbSet<Bootcamp> Bootcamps { get; set; }
        public DbSet<BlackList> BlackLists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ApplicationConfiguration());
            modelBuilder.ApplyConfiguration(new BootcampConfiguration());
            modelBuilder.ApplyConfiguration(new BlackListConfiguration());
        }
    }
}