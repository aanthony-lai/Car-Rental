using CarRental.Domain.Entities.Booking;
using CarRental.Domain.Repositories;
using MediatR;

namespace CarRental.Application.Bookings
{
    public class GetBookingsHandler : IRequestHandler<GetBookingsRequest, List<Booking>>
    {
        private readonly IBookingRepository _bookingRepository;
        public GetBookingsHandler(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        public async Task<List<Booking>> Handle(GetBookingsRequest request, CancellationToken cancellationToken)
        {
            return (await _bookingRepository.GetAsync()).ToList();
        }
    }
}
