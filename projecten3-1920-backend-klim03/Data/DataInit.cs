using Microsoft.AspNetCore.Identity;
using projecten3_1920_backend_klim03.Domain.Models.Domain;
using projecten3_1920_backend_klim03.Domain.Models.Domain.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Data
{
    public class DataInit
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<AppUser> _userManager;

        public DataInit(ApplicationDbContext dbContext, UserManager<AppUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }



        public async Task InitializeData()
        {
            _dbContext.Database.EnsureDeleted();
            if (_dbContext.Database.EnsureCreated())
            {

                //seeding
                AppUser leraar = new AppUser
                {
                    UserName = "leraar",
                    Email = "leerkracht@school.be"
                };

                await CreateUser(leraar, "P@ssword1");

                // project template

                // category template
                CategoryTemplate ct1 = new CategoryTemplate
                {
                    CategoryName = "template 1"

                };

                // product templates


                // school
                School go = new School
                {
                    Name = "Go school",
                    Email = "go@school.be",
                    ClassRooms = null,
                    TelNum = "049746382",
                    Adres = new Adres
                    {
                        Straat = "straat",
                        Postcode = "8490",
                        Huisnummer = "5",
                        Plaats = "Brugge"
                    },
                    ProductTemplates = new List<ProductTemplate>
                    {
                        new ProductTemplate
                        {
                        ProductName = "Karton",
                        CategoryTemplate = ct1,
                        SchoolId = 1,
                        ProductVariationTemplates = new List<ProductVariationTemplate>
                        {
                            new ProductVariationTemplate
                            {
                                IsSimple = true,
                                ProductDescr = "Simpele beschrijving",
                                ESchoolGrade = ESchoolGrade.EERSTE
                            },
                            new ProductVariationTemplate
                            {
                                IsSimple = false,
                                ProductDescr = "Moeilijke beschrijving",
                                ESchoolGrade = ESchoolGrade.DERDE
                            }
                        }
                    }
                },
                    ProjectTemplates = new List<ProjectTemplate> { },
                };




                _dbContext.Add(go);
                _dbContext.SaveChanges();
            }
        }

        private async Task CreateUser(AppUser user, string password)
        {
            await _userManager.CreateAsync(user, password);
        }
    }
}
