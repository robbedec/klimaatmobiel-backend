using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using projecten3_1920_backend_klim03.Domain.Models.Domain;

namespace projecten3_1920_backend_klim03.Data.Mapping
{
    public class ToepassingsGebiedConfig : IEntityTypeConfiguration<ToepassingsGebied>
    {
        public void Configure(EntityTypeBuilder<ToepassingsGebied> builder)
        {
            builder.ToTable("ToepassingsGebied");
            builder.HasKey(g => g.ToepassingsGebiedId);


          
        }
    }
}
