using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using projecten3_1920_backend_klim03.Data.Mapping;
using projecten3_1920_backend_klim03.Domain.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Adres> Adres { get; set; }
        public DbSet<Bestelling> Bestellingen { get; set; }
        public DbSet<Categorie> Categorieen { get; set; }
        public DbSet<Gebruiker> Gebruikers { get; set; }
        public DbSet<Groep> Groepen { get; set; }
        public DbSet<Klas> Klassen { get; set; }
        public DbSet<Leerling> Leerlingen { get; set; }
        public DbSet<Product> Producten { get; set; }
        public DbSet<Project> Projecten { get; set; }
        public DbSet<Promotie> Promoties { get; set; }
        public DbSet<School> Scholen { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new AdresConfig());
            builder.ApplyConfiguration(new BestellingConfig());
            builder.ApplyConfiguration(new CategorieConfig());
            builder.ApplyConfiguration(new GebruikerConfig());
            builder.ApplyConfiguration(new GroepConfig());
            builder.ApplyConfiguration(new KlasConfig());
            builder.ApplyConfiguration(new LeerlingConfig());
            builder.ApplyConfiguration(new ProductConfig());
            builder.ApplyConfiguration(new ProjectConfig());
            builder.ApplyConfiguration(new PromotieConfig());
            builder.ApplyConfiguration(new AdresConfig());
            builder.ApplyConfiguration(new SchoolConfig());
        }
    }
}
