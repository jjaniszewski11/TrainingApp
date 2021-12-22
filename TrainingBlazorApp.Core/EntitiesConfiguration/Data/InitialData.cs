namespace TrainingBlazorApp.Core.EntitiesConfiguration.Data
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public abstract class InitialData<TEntity> where TEntity : class
    {
        public abstract void PrepareInitialData(EntityTypeBuilder<TEntity> builder);
    }
}
