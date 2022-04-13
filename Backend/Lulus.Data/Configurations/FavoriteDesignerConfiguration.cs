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
    public class FavoriteDesignerConfiguration : IEntityTypeConfiguration<FavoriteDesigner>
    {
        public void Configure(EntityTypeBuilder<FavoriteDesigner> builder)
        {
            builder.ToTable("FavoriteDesigners");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.User).WithMany(x => x.FavoriteDesigners).HasForeignKey(x => x.UserID);
            builder.HasOne(x => x.Desinger).WithMany(x => x.FavoriteDesigners).HasForeignKey(x => x.DesignerID);
        }
    }
}
