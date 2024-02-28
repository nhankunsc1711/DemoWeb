using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DemoWeb.Data;
using System;
using System.Linq;

namespace DemoWeb.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DemoWebContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DemoWebContext>>()))
            {
                if (context.Employee.Any())
                {
                    return;
                }

                context.Employee.AddRange(
                    new Employee
                    {
                        Name = "Ngo Trong Nhan",
                        Email = "nhanngo1711@gmail.com",
                        PhoneNumber = "0348491817",
                        DateOfBirth = DateTime.Parse("2002-11-17"),
                        Address = "Thai Phien, Phuong 12",
                        City = "Da Lat City"
                    },

                    new Employee
                    {
                        Name = "Thanh Thanh Thuong",
                        Email = "thanhthuong@gmail.com",
                        PhoneNumber = "0123456789",
                        DateOfBirth = DateTime.Parse("2002-7-19"),
                        Address = "Ninh Thuan",
                        City = "Phan Rang"
                    },

                    new Employee
                    {
                        Name = "Le Thi Bang Chau",
                        Email = "bangchau@gmail.com",
                        PhoneNumber = "0987654321",
                        DateOfBirth = DateTime.Parse("2005-11-6"),
                        Address = "Thua Thien Hue",
                        City = "Hue"
                    },

                    new Employee
                    {
                        Name = "Pham Thanh Hoa",
                        Email = "thanhhoa@gmail.com",
                        PhoneNumber = "0321456789",
                        DateOfBirth = DateTime.Parse("2002-5-5"),
                        Address = "Lam Dong",
                        City = "Bao Loc"
                    }
                ) ;
                context.SaveChanges();
            }
        }
    }
}