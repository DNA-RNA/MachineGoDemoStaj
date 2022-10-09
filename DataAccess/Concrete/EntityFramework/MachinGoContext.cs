using Entities.Concrete;
using Entities.Entities.Concrete;
using MachineGoDemo.Entities.Concrete;
using Microsoft.Azure.DevOps.Licensing.WebApi;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class MachinGoContext : DbContext
    {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=MachineGo;Trusted_Connection=true");
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Machine).Assembly);
           // modelBuilder.Entity<MachineType>().HasKey(x => x.Id);
        }

        public DbSet<Machine> machines { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<MachineType> MachineTypes { get; set; }
        public DbSet<Attachment> Attachments { get; set; }


    }
}
