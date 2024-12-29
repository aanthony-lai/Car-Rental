namespace CarRental.Application.Classes
{
    public class BookingProcessor
    {
        //private readonly IDataStore _db;

        //public BookingProcessor()
        //{
        //    _db = new DataStore();
        //}
        //public IEnumerable<T> GetData<T>()
        //{
        //    return _db.GetData<T>();
        //}
        //public async Task CreateCustomer(int Ssn, string LastName, string FirstName)
        //{
        //    ICustomer newCustomer = new Customer(Ssn, LastName, FirstName);
        //    await _db.PostData(newCustomer);
        //}
        //public async Task CreateVechicle(IVechicle newVechicle)
        //{
        //    await _db.PostData(newVechicle);
        //}
        //public async Task CreateBookings(IVechicle vechicle, ICustomer customer)
        //{
        //    DateTime today = DateTime.Now;
        //    string todayWithoutTime = today.ToString("yyyy-MM-dd");
        //    IBooking booking = new Booking(vechicle.regNumber, customer, vechicle.odometer, todayWithoutTime);
        //    IVechicle? updateVechicleStatus = _db.GetData<IVechicle>().First(vechicle => vechicle.regNumber == booking.regNumber);
        //    updateVechicleStatus.status = VechicleStatus.Booked;
        //    customer.isRenting = true;
        //    await _db.PostData(booking);

        //}
        //public async Task ReturnCar(IVechicle vechicle, int distance)
        //{
        //    await Task.Delay(100);
        //    DateTime returnDate = DateTime.Today;
        //    string returnDateWithoutTime = returnDate.ToString("yyyy-MM-dd");
        //    IBooking originalBooking = _db.GetData<IBooking>().First(booking => booking.regNumber == vechicle.regNumber && booking.status == BookingStatuses.Open);
        //    DateTime rentedDate = Convert.ToDateTime(originalBooking.rented).Date;
        //    TimeSpan difference = returnDate.Date - rentedDate.Date;
        //    int daysRented = difference.Days;
        //    UpdateBooking(vechicle, daysRented, distance, returnDateWithoutTime, originalBooking);
        //    UpdateVechicle(vechicle, distance);
        //    GetData<ICustomer>().First(customer => customer.ssn == originalBooking.customer.ssn).isRenting = false;
        //}
        //void UpdateBooking(IVechicle Vechicle, int DaysRented, int Distance, string ReturnDate, IBooking OriginalBooking)
        //{
        //    OriginalBooking.cost = Convert.ToInt32(Vechicle.costPerDay + (Vechicle.costPerDay * DaysRented) + (Distance * Vechicle.costPerKm));
        //    OriginalBooking.kmReturned = Vechicle.odometer + Distance;
        //    OriginalBooking.returned = ReturnDate;
        //    OriginalBooking.status = BookingStatuses.Closed;
        //}
        //void UpdateVechicle(IVechicle vechicle, int Distance)
        //{
        //    vechicle.odometer = vechicle.odometer + Distance;
        //    vechicle.status = VechicleStatus.Available;
        //}
    }
}
