using Microsoft.AspNetCore.Identity;
using projecten3_1920_backend_klim03.Domain.Models.Domain;
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
            }
        }

        private async Task CreateUser(AppUser user, string password)
        {
            await _userManager.CreateAsync(user, password);
        }
    }
}
