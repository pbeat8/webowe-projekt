using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using WeboweTwojDentysta.Models;

namespace WeboweTwojDentysta.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DatabaseContext")
        {
            Database.SetInitializer(new DentistInitializer());
        }

        public DbSet<Location> Locations { get; set; }
        public DbSet<Physician> Physicians { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}