using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using ServicesCatalog.API.Models;
using ServicesCatalog.API.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesCatalog.API.Data
{
    public static class PrepDb
    {
        public static void InitializeData(IApplicationBuilder app)
        {
            using( var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void SeedData(AppDbContext context)
        {
            if (!context.Services.Any())
            {
                Console.WriteLine("--> seeding data");
                context.Services.AddRange(
                    new Service()
                    {
                        ServiceName = "Yoga",
                        ServiceProvider = "Yoga World",
                        ProviderEmail = "yogaworld@gmail.com",
                        ProviderContactNumber = 1122334455,
                        PinCodeCovers = ListConverter.ListToString(new List<int> { 226008, 226001, 226002}),
                        Cost = "3456",
                        Description = "From booking a yoga trainer at home to booking a class at a professional yoga studio, the Yoga World partners give customers an experience that makes this the most popular category on the app. For those who want to get fit mentally and physically, this is the go-to category."
                    },
                    new Service()
                    {
                        ServiceName = "Fitness trainer",
                        ServiceProvider = "A-Z Fitness",
                        ProviderEmail = "fit32@gmail.com",
                        ProviderContactNumber = 2039456372,
                        PinCodeCovers = ListConverter.ListToString(new List<int> { 226003, 226004, 226005 }),
                        Cost = "2312",
                        Description = "The fitness industry in India is worth a staggering Rs. 4,500 crore. It is not a surprise that a fitness trainer at home as a service makes it to this list. Book a fitness trainer and follow the pursuit of staying fit and leading a healthy lifestyle."
                    },
                    new Service()
                    {
                        ServiceName = "Salon at home",
                        ServiceProvider = "Unisex Salon",
                        ProviderEmail = "salon_uni@gmail.com",
                        ProviderContactNumber = 3452348967,
                        PinCodeCovers = ListConverter.ListToString(new List<int> { 226006, 226007, 226009 }),
                        Cost = "6699",
                        Description = "Beauty treatments aren’t just the best way to pamper yourself but also help you look your presentable best. With a host of services like facials, clean ups, waxing, threading, pedicure, manicure and the newly launched massage at home service."
                    },
                    new Service()
                    {
                        ServiceName = "Party make-up",
                        ServiceProvider = "MakupOp",
                        ProviderEmail = "makeop07@gmail.com",
                        ProviderContactNumber = 9985673458,
                        PinCodeCovers = ListConverter.ListToString(new List<int> { 226010, 226011, 226012 }),
                        Cost = "5643",
                        Description = "After the basic care, comes going out in style. Party make-up professionals on Urban Company use quality brands (MAC, Bobby Brown, Maybeline etc.) that do not put a dent on your pocket."
                    },
                    new Service()
                    {
                        ServiceName = "Interior Designer",
                        ServiceProvider = "Home Interior Designer",
                        ProviderEmail = "interiordes09@gmail.com",
                        ProviderContactNumber = 8756447891,
                        PinCodeCovers = ListConverter.ListToString(new List<int> { 226013, 226014, 226015 }),
                        Cost = "7645",
                        Description = "Home is always where the heart is. But care needs to be taken to have a comfortable abode that appeals to your every sense. If after a hard days work you come back to an inviting place, it ends your day on the perfect note every time."
                    }
                    );
                context.SaveChanges();
                Console.WriteLine("hellllo",context.Services.TakeLast(2));
            }
            else
            {
                Console.WriteLine("--> we already have data");
            }
        }
    }
}
