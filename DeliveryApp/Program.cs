using DeliveryApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using DeliveryApp.Interfaces;
using DeliveryApp.Repository;

namespace DeliveryApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<OrderDataContext>(opts =>
            {
                opts.UseSqlServer(builder.Configuration["ConnectionStrings:OrdersConnection"]);
                opts.EnableSensitiveDataLogging(true);
            });
            builder.Services.Configure<MvcOptions>(opts => opts.ModelBindingMessageProvider
                        .SetValueMustNotBeNullAccessor(value => "Please enter a value"));
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IOrderRepository, OrderRepository>();

            // Add services to the container.

            var app = builder.Build();
            app.UseStaticFiles();
            app.MapControllers();
            //app.MapControllerRoute("Default", "{controller=Order}/{action=Index}/{id?}");
            app.MapControllerRoute("forms", "/{controller=Order}/{action=Index}/{id?}");

            var context = app.Services.CreateScope().ServiceProvider
                          .GetRequiredService<OrderDataContext>();
            SeedDataOrders.SeedDatabase(context);

            app.Run();
        }
    }
}