using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace inter.Models.Configurations
{
    public class ScoutsConfig : IEntityTypeConfiguration<Scouts>
    {
        public void Configure(EntityTypeBuilder<Scouts> builder)
        {
            builder.HasKey(S => S.ScoutID);
            builder.Property(S => S.FirstName).HasMaxLength(20);
            builder.Property(S => S.LastName).HasMaxLength(20);
        }
    }
}
