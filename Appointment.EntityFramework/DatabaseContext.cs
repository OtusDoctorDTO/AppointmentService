using Microsoft.EntityFrameworkCore;

namespace Appointment.EntityFramework
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Entities.Appointment> Appointments { get; set; }
    }
}
