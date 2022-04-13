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
            builder.HasOne(x => x.User).WithMany(x => x.FavoriteProducts).HasForeignKey(x => x.UserID);
            builder.HasOne(x => x.Product).WithMany(x => x.FavoriteProducts).HasForeignKey(x => x.ProductID);
        }
    }
}
