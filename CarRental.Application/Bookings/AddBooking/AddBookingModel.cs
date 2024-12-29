namespace CarRental.Application.Bookings;

public class AddBookingModel
{
    public string RegNumber { get; }
    public int SocialSecurityNumber { get; }

    public AddBookingModel(string regNumber, int socialSecurityNumber)
    {
        RegNumber = regNumber;
        SocialSecurityNumber = socialSecurityNumber;
    }
}