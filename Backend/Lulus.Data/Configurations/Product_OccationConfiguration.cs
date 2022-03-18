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
    public class Product_OccationConfiguration : IEntityTypeConfiguration<Product_Occation>
    {
        public void Configure(EntityTypeBuilder<Product_Occation> builder)
        {
            builder.ToTable("Product_Occations");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Occation).WithMany(x => x.Product_Occations).HasForeignKey(x => x.OccationID);
            builder.HasOne(x => x.Product).WithMany(x => x.Product_Occations).HasForeignKey(x => x.ProductID);
        }
    }
}
