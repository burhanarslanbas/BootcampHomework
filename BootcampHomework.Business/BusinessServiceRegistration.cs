using BootcampHomework.Business.Abstracts;
using BootcampHomework.Business.Concretes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BootcampHomework.Business
{
    public static class BusinessServiceRegistration
    {
        public static IServiceCollection AddBusinessServices (this IServiceCollection services)
        {
            // AutoMapper Configuration
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            // Add Business Implementations
            services.AddScoped<IBootcampService, BootcampManager>();
            services.AddScoped<IApplicationService, ApplicationManager>();
            services.AddScoped<IBlackListService, BlackListManager>();
            return services;
        }
    }
}
