using DeliveryApp.Data;
using DeliveryApp.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DeliveryApp
{
    public static class SeedDataOrders
    {
        /// <summary>
        /// Adding orders for database testing
        /// </summary>
        /// <param name="context"></param>
        public static void SeedDatabase(OrderDataContext context) 
        {
            context.Database.Migrate();
            if (context.Orders.Count() == 0)
            {
                context.Orders.AddRange(
                    new Order
                    {
                        NumberOrder = Guid.NewGuid().ToString("N"),
                        SenderCity = "Moscow",
                        SenderAdress = "Academician Anokhin street, 11",
                        RecipientCity = "Saint Petersburg",
                        RecipientAdress = "Red Street, 1",
                        CargoWeight = 11.8M,
                        DeliveryDate = DateTime.Today
                    },
                    new Order
                    {
                        NumberOrder = Guid.NewGuid().ToString("N"),
                        SenderCity = "Saint Petersburg",
                        SenderAdress = "Red Street, 1",
                        RecipientCity = "Krasnodar",
                        RecipientAdress = "Street 40 years of Victory, 40",
                        CargoWeight = 9.8M,
                        DeliveryDate = DateTime.Today
                    },
                    new Order
                    {
                        NumberOrder = Guid.NewGuid().ToString("N"),
                        SenderCity = "Saint Petersburg",
                        SenderAdress = "Red Street, 1",
                        RecipientCity = "Krasnodar",
                        RecipientAdress = "Street 40 years of Victory, 40",
                        CargoWeight = 120M,
                        DeliveryDate = DateTime.Today
                    },
                    new Order
                    {
                        NumberOrder = Guid.NewGuid().ToString("N"),
                        SenderCity = "Samara",
                        SenderAdress = "Apricot street, 31",
                        RecipientCity = "Vladivostok",
                        RecipientAdress = "Street 70 years of October, 154",
                        CargoWeight = 125M,
                        DeliveryDate = DateTime.Today
                    },
                    new Order
                    {
                        NumberOrder = Guid.NewGuid().ToString("N"),
                        SenderCity = "Kaliningrad",
                        SenderAdress = "Garden Street, 80",
                        RecipientCity = "Nizhnevartovsk",
                        RecipientAdress = "Factory street, 37",
                        CargoWeight = 150M,
                        DeliveryDate = DateTime.Today
                    });
                 context.SaveChanges();
            }
           
        }
    }
}
