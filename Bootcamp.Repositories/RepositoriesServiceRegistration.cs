using BootcampHomework.Repositories.Abstracts;
using BootcampHomework.Repositories.Concretes;
using BootcampHomework.Repositories.Concretes.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampHomework.Repositories
{
    public static class RepositoriesServiceRegistration
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            // Add DbContext
            services.AddDbContext<BaseDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            // Add Repository Implementations
            services.AddScoped<IApplicationRepository, ApplicationRepository>();
            services.AddScoped<IBootcampRepository, BootcampRepository>();
            services.AddScoped<IBlackListRepository, BlackListRepository>();
            return services;
        }
    }
}
