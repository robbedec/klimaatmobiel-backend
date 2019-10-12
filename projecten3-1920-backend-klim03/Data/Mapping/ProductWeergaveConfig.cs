using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using projecten3_1920_backend_klim03.Domain.Models.Domain;

namespace projecten3_1920_backend_klim03.Data.Mapping
{
    public class ProductWeergaveConfig : IEntityTypeConfiguration<ProductWeergave>
    {
        public void Configure(EntityTypeBuilder<ProductWeergave> builder)
        {
            builder.ToTable("ProductWeergave");
            builder.HasKey(g => g.ProductWeergaveId);  
        }
    }
}
