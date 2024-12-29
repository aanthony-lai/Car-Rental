﻿using CarRental.Domain.Entities.Customers;
using CarRental.Domain.Entities.VechicleEntity;
using CarRental.Domain.Enums;

namespace CarRental.Domain.Entities.Booking
{
    public class Booking : IEntity
    {
        public int Id { get; }
        public string RegNumber { get; } = string.Empty;
        public IVehicle Vehicle { get; private set; }
        public int SocialSecurityNumber { get; }
        public Customer Customer { get; private set; }
        public DateTime RentedOn { get; }
        public DateTime ReturnedOn { get; private set; }
        public decimal TotalCost { get; private set; }
        public BookingStatuses Status { get; private set; }

        public Booking(IVehicle vehicle, Customer customer)
        {
            Id += 1;
            RegNumber = vehicle.RegNumber;
            Vehicle = vehicle ?? throw new ArgumentException("The selected vechicle is invalid.");
            SocialSecurityNumber = customer.SocialSecurityNumber;
            Customer = customer ?? throw new ArgumentException($"The selected customer is invalid.");
            RentedOn = DateTime.Now;
            Status = BookingStatuses.Open;
        }

        public void Resolve(decimal distance)
        {
            ReturnedOn = DateTime.Now;
            TotalCost = Vehicle.CostPerDay * (ReturnedOn.Day - RentedOn.Day + 1) + distance * Vehicle.CostPerKm;
            Status = BookingStatuses.Closed;
        }
    }
}
