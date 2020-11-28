using eMall.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eMall.Infrastructure.Mapping.Base
{
    public abstract class EntityMap<TEntity> : IEntityTypeConfiguration<TEntity>
            where TEntity : class, IEntity<int>
    {
        protected abstract string TableName { get; }

        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.ToTable(TableName);
            builder.HasKey(e => e.Id);
        }
    }
}
