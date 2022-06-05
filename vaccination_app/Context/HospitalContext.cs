using Microsoft.EntityFrameworkCore;
using vaccination_app.VaccinationDB;

namespace vaccination_app.Context
{
    public class HospitalContext: DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options) : base(options)
        {

        }
        public DbSet<Hospital> Hospitals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Hospital>().HasNoKey();
        }
    }
}
