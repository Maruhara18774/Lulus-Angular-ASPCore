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
    public class TextureConfiguration : IEntityTypeConfiguration<Texture>
    {
        public void Configure(EntityTypeBuilder<Texture> builder)
        {
            builder.ToTable("Textures");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Created).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.Updated).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.Active).HasDefaultValue(true);
        }
    }
}
