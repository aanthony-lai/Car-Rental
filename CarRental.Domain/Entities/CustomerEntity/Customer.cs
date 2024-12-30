﻿namespace CarRental.Domain.Entities.Customers
{
    public class Customer : IEntity
    {
        public int SocialSecurityNumber { get; init; }
        public string FirstName { get; }
        public string LastName { get; }

        public Customer(string firstName, string lastName, int socialSecurityNumber)
        {
            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentException("First name and last name, are not allowed to be empty");
            }

            if (socialSecurityNumber < 100000 && 
                socialSecurityNumber > 600000)
            {
                throw new ArgumentException("Invalid social security number.");
            }

            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
        }
    }
}
