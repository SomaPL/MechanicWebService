using MechanicWebService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using MechanicWebService.Data;

namespace MechanicWebService.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                context.Database.EnsureCreated();

                if (context.Reservations.Any())
                {
                    return; // dane już zostały dodane do bazy danych
                }
                context.Reservations.AddRange(
                new Reservation
                {
                    ReservationId = 1,
                    CustomerId = 1,
                    MechanicId = 1,
                    ServiceId = 1,
                    DateAndTime = DateTime.Parse("2023-01-22 10:35:59"),
                    Customer = new Customer()
                    {
                        CustomerId=1,
                        FirstName="Jakub",
                        LastName="Kot",
                        PhoneNumber="123456789",
                        Address="Kraków"
                    },
                    Mechanic = new Mechanic()
                    {
                        MechanicId=1,
                        FirstName="Jan",
                        LastName="Kowalski",
                        Experiance="2",
                        Specialization="Wulkanizacja"
                    },
                    Service = new Service()
                    {
                        ServiceId=1,
                        Description="Zamiana Opon",
                        Price=30,
                    }
                }
                );
                context.SaveChanges();
            }
        }
    }
}