using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace inter.Models.Configurations
{
    public class ScoutsTeamsConfig : IEntityTypeConfiguration<ScoutsTeams>
    {
        public void Configure(EntityTypeBuilder<ScoutsTeams> builder)
        {
           builder.HasKey(ST => new { ST.ScoutsID, ST.TeamsID });
        }
    }
}
