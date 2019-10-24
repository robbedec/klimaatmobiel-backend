using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using projecten3_1920_backend_klim03.Domain.Models.Domain;

namespace projecten3_1920_backend_klim03.Data.Mapping
{
    public class ProductVariationTemplateConfig : IEntityTypeConfiguration<ProductVariationTemplate>
    {
        public void Configure(EntityTypeBuilder<ProductVariationTemplate> builder)
        {
            builder.ToTable("ProductVariationTemplate");
            builder.HasKey(g => g.ProductVariationTemplateId);
        }
    }
}
