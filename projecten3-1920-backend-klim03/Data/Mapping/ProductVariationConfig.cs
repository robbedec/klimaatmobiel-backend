using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using projecten3_1920_backend_klim03.Domain.Models.Domain;

namespace projecten3_1920_backend_klim03.Data.Mapping
{
    public class ProductVariationConfig : IEntityTypeConfiguration<ProductVariation>
    {
        public void Configure(EntityTypeBuilder<ProductVariation> builder)
        {
            builder.ToTable("ProductVariation");
            builder.HasKey(g => g.ProductVariationId);  
        }
    }
}
