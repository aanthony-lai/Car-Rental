using MediatR;

namespace CarRental.Application.Bookings;

public class AddBookingRequest: IRequest
{
    public AddBookingModel AddBookingModel { get; set; }

    public AddBookingRequest(AddBookingModel addBookingModel)
    {
        AddBookingModel = addBookingModel;
    }
}