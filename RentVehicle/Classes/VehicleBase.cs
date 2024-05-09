using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentVehicle.Classes
{
    // Abstract base class representing a vehicle
    public abstract class VehicleBase
    {
        // Properties
        public int Id { get; protected set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal RentalPricePerDay { get; set; }
        public bool IsAvailable { get; set; }

        // Static counter for assigning unique IDs to vehicles
        private static int nextId = 1;

        // Constructor
        protected VehicleBase(string make, string model, int year, decimal rentalPricePerDay)
        {
            Id = nextId++; // Assign a unique ID to each vehicle
            Make = make;
            Model = model;
            Year = year;
            RentalPricePerDay = rentalPricePerDay;
            IsAvailable = true; // By default, vehicle is available
        }

        // Abstract method to display details of the vehicle
        public abstract void DisplayDetails();

        // Abstract method to calculate rental cost
        public abstract decimal CalculateRentalCost(int numberOfDays);
    }
}
