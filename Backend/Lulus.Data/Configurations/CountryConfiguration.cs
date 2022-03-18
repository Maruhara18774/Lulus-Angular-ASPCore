using Lulus.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("Countries");
            builder.Property(x => x.Created).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.Updated).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.Active).HasDefaultValue(true);
            builder.HasKey(x => x.ID);
        }
    }
}
