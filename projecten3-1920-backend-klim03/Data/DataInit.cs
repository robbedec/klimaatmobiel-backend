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

                

                // category template
                CategoryTemplate ct1 = new CategoryTemplate
                {
                    CategoryName = "default categorytemplate"
                };

                //application domain

                ApplicationDomain ad = new ApplicationDomain
                {
                    ApplicationDomainName = "Natuurkunde",
                    ApplicationDomainDescr = "Alles over natuurkunde"
                };


                //school
                School schoolGO = new School
                {
                    Name = "Go school",
                    Email = "go@school.be",
                    TelNum = "049746382",
                    Adres = new Adres
                    {
                        Straat = "straat",
                        Postcode = "8490",
                        Huisnummer = "5",
                        Plaats = "Brugge"
                    }
                };

                _dbContext.Add(ct1);
                _dbContext.Add(schoolGO);
                _dbContext.Add(ad);
                _dbContext.SaveChanges();

                //classroom
                ClassRoom cr = new ClassRoom
                {
                    Name = "Klas 1",
                    SchoolId = schoolGO.SchoolId
                };
                schoolGO.ClassRooms.Add(cr);

                #region ProductTemplates

                ProductTemplate pt1 = new ProductTemplate
                {
                    ProductName = "Karton",
                    AddedByGO = true,
                    ProductImage = "https://karton.com",
                    HasMultipleDisplayVariations = true,
                    CategoryTemplateId = ct1.CategoryTemplateId,
                    SchoolId = schoolGO.SchoolId,
                    ProductVariationTemplates = new List<ProductVariationTemplate>
                    {
                        new ProductVariationTemplate
                        {
                            ProductDescr = "Eerste graad beschrijving karton",
                            ESchoolGrade = ESchoolGrade.EERSTE
                        },
                        new ProductVariationTemplate
                        {
                            ProductDescr = "Tweede graad beschrijving karton",
                            ESchoolGrade = ESchoolGrade.EERSTE
                        },
                        new ProductVariationTemplate
                        {
                            ProductDescr = "Derde graad beschrijving karton",
                            ESchoolGrade = ESchoolGrade.DERDE
                        }
                    }
                };
               
                ProductTemplate pt2 = new ProductTemplate
                {
                    ProductName = "Lijm",
                    AddedByGO = true,
                    ProductImage = "https://lijm.com",
                    HasMultipleDisplayVariations = true,
                    CategoryTemplateId = ct1.CategoryTemplateId,
                    SchoolId = schoolGO.SchoolId,
                    ProductVariationTemplates = new List<ProductVariationTemplate>
                    {
                        new ProductVariationTemplate
                        {
                            ProductDescr = "Eerste graad beschrijving Lijm",
                            ESchoolGrade = ESchoolGrade.EERSTE
                        },
                        new ProductVariationTemplate
                        {
                            ProductDescr = "Tweede graad beschrijving Lijm",
                            ESchoolGrade = ESchoolGrade.EERSTE
                        },
                        new ProductVariationTemplate
                        {
                            ProductDescr = "Derde graad beschrijving Lijm",
                            ESchoolGrade = ESchoolGrade.DERDE
                        }
                    }
                };
                ProductTemplate pt3 = new ProductTemplate
                {
                    ProductName = "Plakband",
                    AddedByGO = true,
                    ProductImage = "https://plakband.com",
                    HasMultipleDisplayVariations = true,
                    CategoryTemplateId = ct1.CategoryTemplateId,
                    SchoolId = schoolGO.SchoolId,
                    ProductVariationTemplates = new List<ProductVariationTemplate>
                    {
                        new ProductVariationTemplate
                        {
                            ProductDescr = "Eerste graad beschrijving Plakband",
                            ESchoolGrade = ESchoolGrade.EERSTE
                        },
                        new ProductVariationTemplate
                        {
                            ProductDescr = "Tweede graad beschrijving Plakband",
                            ESchoolGrade = ESchoolGrade.EERSTE
                        },
                        new ProductVariationTemplate
                        {
                            ProductDescr = "Derde graad beschrijving Plakband",
                            ESchoolGrade = ESchoolGrade.DERDE
                        }
                    }
                };

                ProductTemplate pt4 = new ProductTemplate
                {
                    ProductName = "Hout",
                    AddedByGO = true,
                    ProductImage = "https://hout.com",
                    HasMultipleDisplayVariations = true,
                    CategoryTemplateId = ct1.CategoryTemplateId,
                    SchoolId = schoolGO.SchoolId,
                    ProductVariationTemplates = new List<ProductVariationTemplate>
                    {
                        new ProductVariationTemplate
                        {
                            ProductDescr = "Eerste graad beschrijving Hout",
                            ESchoolGrade = ESchoolGrade.EERSTE
                        },
                        new ProductVariationTemplate
                        {
                            ProductDescr = "Tweede graad beschrijving Hout",
                            ESchoolGrade = ESchoolGrade.EERSTE
                        },
                        new ProductVariationTemplate
                        {
                            ProductDescr = "Derde graad beschrijving Hout",
                            ESchoolGrade = ESchoolGrade.DERDE
                        }
                    }
                };

                schoolGO.AddProductTemplate(pt1);
                schoolGO.AddProductTemplate(pt2);
                schoolGO.AddProductTemplate(pt3);
                schoolGO.AddProductTemplate(pt4);
                _dbContext.SaveChanges();
                #endregion

                #region ProjectTemplate

                ProjectTemplate projectTemplate = new ProjectTemplate
                {
                    AddedByGO = true,
                    ProjectDescr = "Dit is een project voor natuurkunde",
                    ProjectImage = "image",
                    ProjectName = "natuur kennismaking",
                    SchoolId = schoolGO.SchoolId,
                    ApplicationDomainId = ad.ApplicationDomainId
                };

                projectTemplate.AddProductTemplate(pt2);
                projectTemplate.AddProductTemplate(pt3);
                projectTemplate.AddProductTemplate(pt4);

                schoolGO.AddProjectTemplate(projectTemplate);

                _dbContext.SaveChanges();
                #endregion








                _dbContext.SaveChanges();
            }
        }

        private async Task CreateUser(AppUser user, string password)
        {
            await _userManager.CreateAsync(user, password);
        }
    }
}
