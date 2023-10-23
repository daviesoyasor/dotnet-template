using Monapp.Service.Implementation;
using Monapp.Service.Interface;

namespace Monapp_API.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureApplicationServices(this IServiceCollection services)
        {
            services.AddSingleton<IAuth, Auth>();
            services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }
    }
}
