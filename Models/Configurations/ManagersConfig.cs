using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace inter.Models.Configurations
{
    public class ManagersConfig : IEntityTypeConfiguration<Managers>
    {
        public void Configure(EntityTypeBuilder<Managers> builder)
        {
            builder.HasOne(M => M.Team)
                    .WithMany(T => T.Managers)
                    .HasForeignKey(M => M.TeamID)
                    .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
