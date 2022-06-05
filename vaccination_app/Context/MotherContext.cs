using Microsoft.EntityFrameworkCore;
using vaccination_app.VaccinationDB;

namespace vaccination_app.Context
{
    public class MotherContext: DbContext
    {
        public MotherContext(DbContextOptions<MotherContext> options) : base(options)
        {

        }
        public DbSet<Mother>Mothers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mother>().HasNoKey();
        }
    }
}
