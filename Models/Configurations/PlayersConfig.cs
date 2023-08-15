using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace inter.Models.Configurations
{
    public class PlayersConfig : IEntityTypeConfiguration<Players>
    {
        public void Configure (EntityTypeBuilder<Players> builder)
        {
            builder.Property(p => p.FirstName).HasMaxLength(20);
            builder.Property(p => p.LastName).HasMaxLength(20);
            builder.Property(p => p.DateOfBirth).HasPrecision(5, 2);
            builder.HasOne(P => P.Scouts).WithMany(S => S.Players)
                .HasForeignKey(P => P.ScoutID);
            builder.HasOne(P => P.Teams).WithMany(S => S.Players)
                  .HasForeignKey(P => P.TeamID).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(P => P.Agents)
                   .WithMany(S => S.Players);
        }
    }
}
