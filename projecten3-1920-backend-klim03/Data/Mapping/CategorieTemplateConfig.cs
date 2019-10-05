using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using projecten3_1920_backend_klim03.Domain.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Data.Mapping
{
    public class CategorieTemplateConfig : IEntityTypeConfiguration<CategorieTemplate>
    {
        public void Configure(EntityTypeBuilder<CategorieTemplate> builder)
        {
            builder.ToTable("CategorieTemplate");
            builder.HasKey(g => g.CategorieTemplateId);

            builder.HasMany(g => g.ProductTemplates).WithOne(g => g.CategorieTemplate).HasForeignKey(g => g.CategorieTemplateId);
            builder.HasMany(g => g.ProjectTemplates).WithOne(g => g.CategorieTemplate).HasForeignKey(g => g.CategorieTemplateId);
        }
    }
}
