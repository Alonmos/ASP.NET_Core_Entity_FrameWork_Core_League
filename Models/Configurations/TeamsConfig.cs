using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace inter.Models.Configurations
{
    public class TeamsConfig : IEntityTypeConfiguration<Teams>
    {
        public void Configure(EntityTypeBuilder<Teams> builder)
        {
            builder.HasKey(t => t.TeamID);
            builder.Property(t => t.Name).HasMaxLength(30);
            builder.HasOne(t => t.Owner).WithOne(O => O.Teams).HasForeignKey<Owner>(O => O.TeamID);
        }
    }
}
