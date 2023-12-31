﻿using Monapp.Service.Implementation;
using Monapp.Service.Interface;

namespace Monapp_API.Extensions
{
    internal static class ServiceExtensions
    {
        public static void ConfigureApplicationServices(this IServiceCollection services)
        {
            // === APPLICATION CUSTOM SERVICES ===
            services.AddSingleton<IAuth, Auth>();

            // === APPLICATION CONFIGURATION SERVICES ===
            services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }
    }
}
