using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using projecten3_1920_backend_klim03.Domain.Models.Domain;

namespace projecten3_1920_backend_klim03.Data.Mapping
{
    public class KlasConfig : IEntityTypeConfiguration<Klas>
    {
        public void Configure(EntityTypeBuilder<Klas> builder)
        {
            builder.ToTable("Klas");
            builder.HasKey(g => g.KlasId);

            builder.HasMany(g => g.Projecten).WithOne(g => g.Klas).HasForeignKey(g => g.KlasId);
        }
    }
}
