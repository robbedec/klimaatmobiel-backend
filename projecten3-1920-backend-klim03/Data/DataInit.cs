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
                    CategoryName = "default categorytemplate",
                    AddedByGO = true,
                    CategoryDescr = "default categorytemplate descr"
                };

                //application domain

                ApplicationDomain ad = new ApplicationDomain
                {
                    ApplicationDomainName = "Energie",
                    ApplicationDomainDescr = "Alles over energie"
                };
                
                ApplicationDomain ad2 = new ApplicationDomain
                {
                    ApplicationDomainName = "Informatie & communicactie",
                    ApplicationDomainDescr = "Alles over informatie & communicactie"
                };
                
                ApplicationDomain ad3 = new ApplicationDomain
                {
                    ApplicationDomainName = "Constructie",
                    ApplicationDomainDescr = "Alles over constructie"
                };
                
                ApplicationDomain ad4 = new ApplicationDomain
                {
                    ApplicationDomainName = "Transport",
                    ApplicationDomainDescr = "Alles over transport"
                };
                
                ApplicationDomain ad5 = new ApplicationDomain
                {
                    ApplicationDomainName = "Biochemie",
                    ApplicationDomainDescr = "Alles over biochemie"
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
                _dbContext.Add(ad2);
                _dbContext.Add(ad3);
                _dbContext.Add(ad4);
                _dbContext.Add(ad5);
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
                    Description = "Dit is karton",
                    AddedByGO = true,
                    ProductImage = "https://karton.com",
                    HasMultipleDisplayVariations = true,
                    CategoryTemplateId = ct1.CategoryTemplateId,
                    SchoolId = schoolGO.SchoolId,
                    ProductVariationTemplates = new List<ProductVariationTemplate>
                    {
                        new ProductVariationTemplate
                        {
                            ProductDescr = "Algemene beschrijving karton",
                            ESchoolGrade = ESchoolGrade.ALGEMEEN
                        },
                        new ProductVariationTemplate
                        {
                            ProductDescr = "Eerste graad beschrijving karton",
                            ESchoolGrade = ESchoolGrade.EERSTE
                        },
                        new ProductVariationTemplate
                        {
                            ProductDescr = "Tweede graad beschrijving karton",
                            ESchoolGrade = ESchoolGrade.TWEEDE
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
                    Description = "Dit is lijm",
                    AddedByGO = true,
                    ProductImage = "https://lijm.com",
                    HasMultipleDisplayVariations = true,
                    CategoryTemplateId = ct1.CategoryTemplateId,
                    SchoolId = schoolGO.SchoolId,
                    ProductVariationTemplates = new List<ProductVariationTemplate>
                    {
                        new ProductVariationTemplate
                        {
                            ProductDescr = "Algemene beschrijving Lijm",
                            ESchoolGrade = ESchoolGrade.ALGEMEEN
                        },
                        new ProductVariationTemplate
                        {
                            ProductDescr = "Eerste graad beschrijving Lijm",
                            ESchoolGrade = ESchoolGrade.EERSTE
                        },
                        new ProductVariationTemplate
                        {
                            ProductDescr = "Tweede graad beschrijving Lijm",
                            ESchoolGrade = ESchoolGrade.TWEEDE
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
                    Description = "Dit is Plakband",
                    AddedByGO = true,
                    ProductImage = "https://plakband.com",
                    HasMultipleDisplayVariations = true,
                    CategoryTemplateId = ct1.CategoryTemplateId,
                    SchoolId = schoolGO.SchoolId,
                    ProductVariationTemplates = new List<ProductVariationTemplate>
                    {
                         new ProductVariationTemplate
                        {
                            ProductDescr = "Algemene beschrijving Plakband",
                            ESchoolGrade = ESchoolGrade.ALGEMEEN
                        },
                        new ProductVariationTemplate
                        {
                            ProductDescr = "Eerste graad beschrijving Plakband",
                            ESchoolGrade = ESchoolGrade.EERSTE
                        },
                        new ProductVariationTemplate
                        {
                            ProductDescr = "Tweede graad beschrijving Plakband",
                            ESchoolGrade = ESchoolGrade.TWEEDE
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
                    Description = "Dit is hout",
                    AddedByGO = true,
                    ProductImage = "https://hout.com",
                    HasMultipleDisplayVariations = true,
                    CategoryTemplateId = ct1.CategoryTemplateId,
                    SchoolId = schoolGO.SchoolId,
                    ProductVariationTemplates = new List<ProductVariationTemplate>
                    {
                        new ProductVariationTemplate
                        {
                            ProductDescr = "Algemene beschrijving hout",
                            ESchoolGrade = ESchoolGrade.ALGEMEEN
                        },
                        new ProductVariationTemplate
                        {
                            ProductDescr = "Eerste graad beschrijving Hout",
                            ESchoolGrade = ESchoolGrade.EERSTE
                        },
                        new ProductVariationTemplate
                        {
                            ProductDescr = "Tweede graad beschrijving Hout",
                            ESchoolGrade = ESchoolGrade.TWEEDE
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



                Category cat1 = new Category
                {
                    CategoryName = "Bouwmaterialen",
                    CategoryDescr = "Zaken waarmee je kan bouwen"
                };

                Product pr1 = new Product
                {
                    Category = cat1,
                    ProductName = "hout",
                    Description = "Algemene beschrijving van hout",
                    Price = 5,
                };

                Group groep1 = new Group
                {
                    GroupName = "Groep 1"
                };

                Project project1 = new Project
                {
                    ProjectCode = "AAA",
                    ProjectBudget = 200,
                    ProjectDescr = "Dit is een project voor natuurkunde",
                    ProjectImage = "image",
                    ProjectName = "natuur kennismaking",
                    ApplicationDomainId = ad.ApplicationDomainId,
                    ESchoolGrade = ESchoolGrade.ALGEMEEN,
                };

                project1.AddProduct(pr1);
                project1.AddGroup(groep1);
                cr.AddProject(project1);
                _dbContext.SaveChanges();

                groep1.Order = new Order
                {
                    OrderItems = new List<OrderItem>
                    {
                        new OrderItem
                        {
                            ProductId = pr1.ProductId,
                            Amount = 2
                        }
                    }
                };




                _dbContext.SaveChanges();
            }
        }

        private async Task CreateUser(AppUser user, string password)
        {
            await _userManager.CreateAsync(user, password);
        }
    }
}
