using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CleanArchitecture.CustomerInfo.Application.Core.Interfaces;
using CleanArchitecture.CustomerInfo.Infrastructure.Repositories;

namespace CleanArchitecture.CustomerInfo.Infrastructure.DIContainer
{
    public static class ServiceInjection
	{
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddScoped<ICustomerInfoRepository, CustomerInfoRepository>();

            return services;

        }
    }
}

