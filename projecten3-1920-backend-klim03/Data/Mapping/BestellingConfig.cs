using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using projecten3_1920_backend_klim03.Domain.Models.Domain;

namespace projecten3_1920_backend_klim03.Data.Mapping
{
    public class BestellingConfig : IEntityTypeConfiguration<Bestelling>
    {
        public void Configure(EntityTypeBuilder<Bestelling> builder)
        {
            builder.ToTable("Bestelling");
            builder.HasKey(g => g.BestellingId);

            builder.HasMany(g => g.BestellingsItems).WithOne(g => g.Bestelling).HasForeignKey(g => g.BestellingId).OnDelete(DeleteBehavior.Restrict);  
        }
    }
}
