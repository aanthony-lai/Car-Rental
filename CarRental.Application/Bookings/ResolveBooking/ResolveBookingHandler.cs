using CarRental.Domain.Repositories;
using MediatR;

namespace CarRental.Application.Bookings.ResolveBooking;

public class ResolveBookingHandler(
    IBookingRepository bookingRepository): IRequestHandler<ResolveBookingRequest>
{
    public async Task Handle(ResolveBookingRequest request, CancellationToken cancellationToken)
    {
        var booking = bookingRepository.GetByIdAsync(request.ResolveBookingModel.BookingId);
        
        if (booking is null)
            throw new ArgumentException(
                $"Booking with id: {request.ResolveBookingModel.BookingId} was not found");
        
        
    }
}

// public async Task ReturnCar(IVechicle vechicle, int distance)
// {
//     await Task.Delay(100);
//     DateTime returnDate = DateTime.Today;
//     string returnDateWithoutTime = returnDate.ToString("yyyy-MM-dd");
//     IBooking originalBooking = _db.GetData<IBooking>().First(booking => booking.regNumber == vechicle.regNumber && booking.status == BookingStatuses.Open);
//     DateTime rentedDate = Convert.ToDateTime(originalBooking.rented).Date;
//     TimeSpan difference = returnDate.Date - rentedDate.Date;
//     int daysRented = difference.Days;
//     UpdateBooking(vechicle, daysRented, distance, returnDateWithoutTime, originalBooking);
//     UpdateVechicle(vechicle, distance);
//     GetData<ICustomer>().First(customer => customer.ssn == originalBooking.customer.ssn).isRenting = false;
// }
// void UpdateBooking(IVechicle Vechicle, int DaysRented, int Distance, string ReturnDate, IBooking OriginalBooking)
// {
//     OriginalBooking.cost = Convert.ToInt32(Vechicle.costPerDay + (Vechicle.costPerDay * DaysRented) + (Distance * Vechicle.costPerKm));
//     OriginalBooking.kmReturned = Vechicle.odometer + Distance;
//     OriginalBooking.returned = ReturnDate;
//     OriginalBooking.status = BookingStatuses.Closed;
// }
// void UpdateVechicle(IVechicle vechicle, int Distance)
// {
//     vechicle.odometer = vechicle.odometer + Distance;
//     vechicle.status = VechicleStatus.Available;
// }