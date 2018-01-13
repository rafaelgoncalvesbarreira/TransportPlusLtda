using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportPlusLtda.Data.Entities;
using TransportPlusLtda.Models;
using TransportPlusLtda.Services;

namespace TransportPlusLtda.Data
{
    public static class DatabaseSeed
    {
        public static void SeedUsers(UserManager<ApplicationUser> userManager)
        {
            if(userManager.FindByNameAsync("admin").Result == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "admin@localhost",
                    Email = "admin@localhost",
                };

                var result = userManager.CreateAsync(user, "123456").Result;

            }
        }

        public static void SeedVehicles(ApplicationDbContext dbContext)
        {
            dbContext.VehicleItems.Add(new Vehicle
            {
                Id = 1,
                GpsId = Guid.Parse("5a16662f-a28f-424f-8c3f-2e662704ee29"),
                Name = "Vehicle secure #23"
            });
            dbContext.VehicleItems.Add(new Vehicle
            {
                Id = 2,
                GpsId = Guid.Parse("4f46fd87-d029-4b55-8c83-b0425a61b7b0"),
                Name = "oil truck #332"
            });
            dbContext.VehicleItems.Add(new Vehicle
            {
                Id = 3,
                GpsId = Guid.Parse("4f46fd87-d029-4b55-8c83-b0425a61b7b0"),
                Name = "CEO's car"
            });

            dbContext.SaveChanges();
        }
    }
}
