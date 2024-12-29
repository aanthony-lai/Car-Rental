namespace CarRental.Application.Customers
{
    public class AddCustomerModel
    {
        public int SocialSecurityNumber { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }
}
