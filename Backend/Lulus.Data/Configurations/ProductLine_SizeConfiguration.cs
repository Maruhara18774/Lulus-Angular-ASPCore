using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lulus.Data.Entities;
using Lulus.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lulus.Data.Configurations
{
    public class ProductLine_SizeConfiguration: IEntityTypeConfiguration<ProductLine_Size>
    {
        public void Configure(EntityTypeBuilder<ProductLine_Size> builder)
        {
            builder.ToTable("LineQuantities");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Quantity).HasDefaultValue(0);
            builder.HasOne(x => x.ProductLine).WithMany(x => x.ProductLine_Sizes).HasForeignKey(x => x.ProductLineID);
            builder.HasOne(x => x.Size).WithMany(x => x.ProductLine_Sizes).HasForeignKey(x => x.SizeID);
        }
    }
}
