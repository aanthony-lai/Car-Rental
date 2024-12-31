using CarRental.Application.Data;
using CarRental.Application.Repositories;
using CarRental.Domain.Repositories;
using CarRental.Infrastructure.Data;
using Microsoft.Extensions.DependencyInjection;

namespace CarRental.Infrastructure.DepedencyInjection
{
    public static class InfrastrcutureDependencyHandler
    {
        public static IServiceCollection RegisterInfrastructureServices(this IServiceCollection services)
        {
            services.AddSingleton<IDataStore, DataStore>();
            services.AddScoped<IBookingRepository, BookingRepository>();
            services.AddScoped<IVehicleRepository, VehicleRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();

            return services;
        }
    }
}
