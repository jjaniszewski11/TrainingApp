namespace TrainingBlazorApp.Core
{
    using Microsoft.EntityFrameworkCore;
    using TrainingBlazorApp.Core.Entities;
    using TrainingBlazorApp.Core.EntitiesConfiguration;

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Unit> Units { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            _ = builder.ApplyConfiguration(new UnitConfig());

            base.OnModelCreating(builder);
        }
    }
}
