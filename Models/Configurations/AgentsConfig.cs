using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace inter.Models.Configurations
{
    public class AgentsConfig : IEntityTypeConfiguration<Agents>
    {
        public void Configure(EntityTypeBuilder<Agents> builder)
        {
            builder.Property(P => P.FirstName).IsRequired(false);
            builder.HasIndex(p => p.FirstName).IsUnique(true);

        }
    }
}
