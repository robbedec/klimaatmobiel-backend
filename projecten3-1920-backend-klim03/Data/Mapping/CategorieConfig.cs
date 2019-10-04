using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using projecten3_1920_backend_klim03.Domain.Models.Domain;

namespace projecten3_1920_backend_klim03.Data.Mapping
{
    public class CategorieConfig : IEntityTypeConfiguration<Categorie>
    {
        public void Configure(EntityTypeBuilder<Categorie> builder)
        {
            builder.ToTable("Categorie");
            builder.HasKey(g => g.CategorieId);

            builder.HasMany(g => g.Producten).WithOne(g => g.Categorie).HasForeignKey(g => g.CategorieId);
            builder.HasMany(g => g.Projecten).WithOne(g => g.Categorie).HasForeignKey(g => g.CategorieId);
        }
    }
}
