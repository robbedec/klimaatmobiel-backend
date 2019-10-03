using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using projecten3_1920_backend_klim03.Domain.Models.Domain;

namespace projecten3_1920_backend_klim03.Data.Mapping
{
    public class LeerlingConfig : IEntityTypeConfiguration<Leerling>
    {
        public void Configure(EntityTypeBuilder<Leerling> builder)
        {
            builder.ToTable("Leerling");
            builder.HasKey(g => g.LeerlingId);

        }
    }
}
