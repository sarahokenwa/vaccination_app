using Microsoft.EntityFrameworkCore;
using vaccination_app.VaccinationDB;

namespace vaccination_app.Context
{
    public class VaccineContext: DbContext
    {
        public VaccineContext(DbContextOptions<VaccineContext> options) : base(options)
        {

        }
        public DbSet<Vaccine>Vaccines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vaccine>().HasNoKey();
        }
    }
}
