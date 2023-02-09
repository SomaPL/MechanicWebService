using MechanicWebService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace MechanicWebService.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                context.Database.EnsureCreated();

                if (context.Cars.Any())
                {
                    return; // dane już zostały dodane do bazy danych
                }

                //Dodanie jednego samochodu
                var car = new Car()
                {
                    Model = "Astra",
                    Mark = "Opel",
                    VIN = "12345678900987654321",
                    Year = "2006"
                };
                

                context.Cars.Add(car);
                context.SaveChanges();
            }
        }
    }
}
