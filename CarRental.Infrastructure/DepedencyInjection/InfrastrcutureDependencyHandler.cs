using CarRental.Application.Data;
using CarRental.Application.Interfaces;
using CarRental.Application.Repositories;
using CarRental.Domain.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CarRental.Infrastructure.DepedencyInjection
{
    public static class InfrastrcutureDependencyHandler
    {
        public static IServiceCollection RegisterInfrastructureServices(this IServiceCollection services)
        {
            services.AddSingleton<IDataStore, DataStore>();
            services.AddScoped<IBookingRepository, BookingRepository>();
            services.AddScoped<IVechicleRepository, VechicleRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();

            return services;
        }
    }
}
