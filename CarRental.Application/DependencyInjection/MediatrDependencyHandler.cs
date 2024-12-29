using CarRental.Application.Classes;
using Microsoft.Extensions.DependencyInjection;

namespace CarRental.Application.DependencyInjection
{
    public static class MediatrDependencyHandler
    {
        public static IServiceCollection RegisterMediatrHandlers(this IServiceCollection services)
        {
            return services.AddMediatR(o => o.RegisterServicesFromAssembly(typeof(BookingProcessor).Assembly));
        } 
    }
}
