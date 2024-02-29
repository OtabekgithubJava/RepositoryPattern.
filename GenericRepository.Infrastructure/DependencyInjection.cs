using GenericRepository.Infrastructure.BaseRepositories;
using GenericRepository.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using GenericRepository.Application.Abstractions;
using GenericRepository.Infrastructure.BaseRepositories;

namespace GenericRepository.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration conf)
        {
            services.AddDbContext<GenericRepositoryDbContext>(options =>
            {
                options.UseNpgsql(conf.GetConnectionString("CONNECT"));
            });

            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
    }
}