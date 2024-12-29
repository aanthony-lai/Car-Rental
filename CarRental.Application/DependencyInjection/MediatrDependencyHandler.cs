using CarRental.Application.Bookings;
using Microsoft.Extensions.DependencyInjection;

namespace CarRental.Application.DependencyInjection
{
    public static class MediatrDependencyHandler
    {
        public static IServiceCollection RegisterMediatrHandlers(this IServiceCollection services)
        {
            return services.AddMediatR(o => 
                o.RegisterServicesFromAssembly(typeof(AddBookingHandler).Assembly));
        } 
    }
}
