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
    public class FavoriteProductConfiguration : IEntityTypeConfiguration<FavoriteProduct>
    {
        public void Configure(EntityTypeBuilder<FavoriteProduct> builder)
        {
            builder.ToTable("FavoriteProducts");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Created).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.Updated).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.Active).HasDefaultValue(true);
            builder.HasOne(x => x.User).WithMany(x => x.FavoriteProducts).HasForeignKey(x => x.UserID);
            builder.HasOne(x => x.Product).WithMany(x => x.FavoriteProducts).HasForeignKey(x => x.ProductID);
        }
    }
}
