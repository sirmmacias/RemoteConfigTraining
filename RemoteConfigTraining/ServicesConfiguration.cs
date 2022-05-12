using MediatR;
using Microsoft.EntityFrameworkCore;
using RemoteConfigTraining.Infrastructure;

namespace RemoteConfigTraining
{
    public static class ServicesConfiguration
    {

        public static void ConfigureCustomServices(this IServiceCollection services)
        {
            services.AddMediatR(typeof(Program));
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddDbContext<ApiContext>(opt => opt.UseInMemoryDatabase("test"));

            services.AddScoped<IFeatureRepository, FeatureRepository>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }

    }
}
