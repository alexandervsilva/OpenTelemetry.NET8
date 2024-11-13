using AVS.OTEL.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AVS.OTEL.Infra.Data.Mappings
{
    public class DiscountMapping : IEntityTypeConfiguration<Discount>
    {
        public void Configure(EntityTypeBuilder<Discount> builder)
        {
            builder.ToTable(nameof(Discount));
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Name).IsRequired().HasColumnName("Name").HasColumnType("varchar(100)");
            builder.Property(d => d.Description).IsRequired().HasColumnName("Description").HasColumnType("varchar(200)");
            builder.Property(d => d.Percent).IsRequired().HasColumnName("Percent").HasColumnType("decimal(18,2)");
        }
    }
}
