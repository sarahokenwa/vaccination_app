using Microsoft.EntityFrameworkCore;
using vaccination_app.VaccinationDB;

namespace vaccination_app.Context
{
    public class VaccinationContext: DbContext
    {
        public VaccinationContext(DbContextOptions<VaccinationContext> options): base (options)
        {

        }
        public DbSet<Vaccination>Vaccinations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vaccination>().HasNoKey();
        }
    }
}
