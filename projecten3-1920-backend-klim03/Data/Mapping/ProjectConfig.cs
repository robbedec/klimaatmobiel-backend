using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using projecten3_1920_backend_klim03.Domain.Models.Domain;

namespace projecten3_1920_backend_klim03.Data.Mapping
{
    public class ProjectConfig : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Project");
            builder.HasKey(g => g.ProjectId);

            builder.HasMany(g => g.Groepen).WithOne(g => g.Project).HasForeignKey(g => g.ProjectId);
            builder.HasMany(g => g.Producten).WithOne(g => g.Project).HasForeignKey(g => g.ProjectId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(g => g.ToepassingsGebied).WithMany();
        }
    }
}
