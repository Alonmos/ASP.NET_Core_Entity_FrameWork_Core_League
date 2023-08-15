using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace inter.Models.Configurations
{
    public class OwnerConfig : IEntityTypeConfiguration<Owner>
    {
        public void Configure(EntityTypeBuilder<Owner> builder)
        {
            builder.HasKey(O => O.OwnerID);
            builder.Property(O => O.FirstName).IsRequired(); 
            builder.Property(O => O.LastName).IsRequired();  
        }
    }
}
