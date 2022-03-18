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
    public class Product_SubCategoryConfiguration : IEntityTypeConfiguration<Product_SubCategory>
    {
        public void Configure(EntityTypeBuilder<Product_SubCategory> builder)
        {
            builder.ToTable("Product_SubCategories");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Product).WithMany(x => x.Product_SubCategories).HasForeignKey(x => x.ProductID);
            builder.HasOne(x => x.Subcategory).WithMany(x => x.Product_SubCategories).HasForeignKey(x => x.SubcategoryID);
        }
    }
}
