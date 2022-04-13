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
    public class OccationConfiguration : IEntityTypeConfiguration<Occation>
    {
        public void Configure(EntityTypeBuilder<Occation> builder)
        {
            builder.ToTable("Occations");
            builder.HasKey(x => x.ID);
        }
    }
}
