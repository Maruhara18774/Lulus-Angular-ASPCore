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
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Addresses");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.User).WithMany(x => x.Addresses).HasForeignKey(x => x.UserID);
            builder.HasOne(x => x.Province).WithMany(x => x.Addresses).HasForeignKey(x => x.ProvinceID);
        }
    }
}
