using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UOM.Domain.Models.Dimensions;

namespace UOM.Persistence.EF.Mapping
{
    public class DimensionMapping : IEntityTypeConfiguration<Dimension>
    {
        public void Configure(EntityTypeBuilder<Dimension> builder)
        {
            builder.ToTable("Dimensions");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id)
                .ValueGeneratedNever();
        }
    }
}
