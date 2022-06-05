using Microsoft.EntityFrameworkCore;
using vaccination_app.VaccinationDB;

namespace vaccination_app.Context
{
    public class ChildContext: DbContext
    {
        public ChildContext(DbContextOptions<ChildContext> options) : base(options)
        {

        }
        public DbSet<Child> Children { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Child>().HasNoKey();
        }
    }
}
