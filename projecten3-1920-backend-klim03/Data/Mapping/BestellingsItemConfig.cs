using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using projecten3_1920_backend_klim03.Domain.Models.Domain;

namespace projecten3_1920_backend_klim03.Data.Mapping
{
    public class BestellingsItemConfig : IEntityTypeConfiguration<BestellingsItem>
    {
        public void Configure(EntityTypeBuilder<BestellingsItem> builder)
        {
            builder.ToTable("BestellingsItem");
            builder.HasKey(g => g.BestellingsItemId);

            builder.HasOne(g => g.Product).WithOne().HasForeignKey<BestellingsItem>(g => g.ProductId).OnDelete(DeleteBehavior.Cascade);

        }
    }
}
