using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using projecten3_1920_backend_klim03.Domain.Models.Domain;

namespace projecten3_1920_backend_klim03.Data.Mapping
{
    public class ProductWeergaveTemplateConfig : IEntityTypeConfiguration<ProductWeergaveTemplate>
    {
        public void Configure(EntityTypeBuilder<ProductWeergaveTemplate> builder)
        {
            builder.ToTable("ProductWeergaveTemplate");
            builder.HasKey(g => g.ProductWeergaveTemplateId);
        }
    }
}
