using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using projecten3_1920_backend_klim03.Domain.Models.Domain;

namespace projecten3_1920_backend_klim03.Data.Mapping
{
    public class ApplicationDomainConfig : IEntityTypeConfiguration<ApplicationDomain>
    {
        public void Configure(EntityTypeBuilder<ApplicationDomain> builder)
        {
            builder.ToTable("ApplicationDomain");
            builder.HasKey(g => g.ApplicationDomainId);


          
        }
    }
}
