﻿using CarRental.Domain.Entities.VechicleEntity;
using CarRental.Domain.Enums;

namespace CarRental.Domain.Entities.Vechicle
{
    public class Car : IVehicle
    {
        public string RegNumber { get; init; } = string.Empty;
        public string Brand { get; } = string.Empty;
        public decimal Odometer { get; private set; }
        public decimal CostPerKm { get; }
        public int CostPerDay { get; }
        public VehicleType Type { get; } 
        public VehicleStatus Status { get; private set; }

        public Car(
            string regNumber, 
            string brand,
            VehicleType type,
            decimal odometer = 0, 
            decimal costPerKm = 0)
        {
            if (string.IsNullOrWhiteSpace(regNumber) ||
                regNumber.Length != 6)
            {
                throw new ArgumentException("Invalid registration number.");
            }

            if (string.IsNullOrWhiteSpace(brand))
                throw new ArgumentException("Brand name can't be empty.");

            RegNumber = regNumber;
            Brand = brand;
            Odometer = odometer;
            CostPerKm = costPerKm;
            CostPerDay = (int)type;
            Type = type;
            Status = VehicleStatus.Available;
        }
        
        public void MakeAvailable()
        {
            Status = VehicleStatus.Available;
        }

        public void UpdateOdometer(decimal distance)
        {
            if (distance < 0)
                throw new ArgumentException("Distance can't be negative.");
            
            Odometer += distance;
        }
    }
}
