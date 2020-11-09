using Microsoft.Extensions.DependencyInjection;
using ShoppingCart.Domain.Interfaces;
using ShoppingCart.Data.Repositories;
using ShoppingCart.Application.Interfaces;
using ShoppingCart.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace ShoppingCart.IOC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services) {
            //When are these instances triggered?
            //As soon as the application starts?
            //As soon as the user makes the first call?
            //As soon as the user makes the second call? and so on...

            //Answer: https://www.tutorialsteacher.com/core/dependency-injection-in-aspnet-core

            /*
             * Singleton: IOC container will create and share a single instance of a service throughout the application's lifetime.
             * Transient: The IOC container will create a new instance of the specified service (E.G. ProductService) type every time you ask for it.
             * Scoped: IOC will create an instance of the specified service type once per request and will be shared in a single request.
             * 
             

            services.AddDbContext<ShoppingCartDbContext>(options =>
         options.UseSqlServer(
             Configuration.GetConnectionString("DefaultConnection")));
            */

            services.AddScoped<IProductsRepository, ProductsRepository>();
            services.AddScoped<IProductsService, ProductsService>();
        }
    }
}
