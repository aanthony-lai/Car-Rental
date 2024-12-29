using MediatR;
using CarRental.Domain.Entities.Booking;

namespace CarRental.Application.Bookings
{
    public class GetBookingsRequest: IRequest<List<Booking>> 
    {
    }
}
