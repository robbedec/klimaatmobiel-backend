using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using projecten3_1920_backend_klim03.Domain.Models.Domain;

namespace projecten3_1920_backend_klim03.Data.Mapping
{
    public class GroepConfig : IEntityTypeConfiguration<Groep>
    {
        public void Configure(EntityTypeBuilder<Groep> builder)
        {
            builder.ToTable("Groep");
            builder.HasKey(g => g.GroepId);

            builder.HasOne(g => g.Bestelling).WithOne(g => g.Groep).HasForeignKey<Bestelling>(g => g.GroepId);
        }
    }
}
