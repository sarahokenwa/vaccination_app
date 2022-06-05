using Microsoft.EntityFrameworkCore;
using vaccination_app.VaccinationDB;

namespace vaccination_app.Context
{
    public class StaffContext: DbContext
    {
        public StaffContext(DbContextOptions<StaffContext> options) : base(options)
        {

        }
        public DbSet<Staff>Staffs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Staff>().HasNoKey();
        }
    }
}
