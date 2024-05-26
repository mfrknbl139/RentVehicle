using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentVehicle.Classes
{

    // Base class representing a vehicle
    public class Vehicle
    {
        // Properties
        public int Id { get; private set; }

        public VehicleType Type { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal RentalPricePerDay { get; set; }
        public bool IsAvailable { get; set; }


        // Static counter for assigning unique IDs to vehicles
        private static int nextId = 1;

        public enum VehicleType
        {
            Car,
            Bike
        }
        // Constructor
        public Vehicle(string make, string model, int year, decimal rentalPricePerDay, VehicleType type)
        {
            Id = nextId++; // Assign a unique ID to each vehicle
            Make = make;
            Model = model;
            Year = year;
            RentalPricePerDay = rentalPricePerDay;
            IsAvailable = true; // By default, vehicle is available
            Type = type; // Set the vehicle typee
        }

        // Method to display details of the vehicle
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"ID: {Id}, Make: {Make}, Model: {Model}, Year: {Year}, Rental Price/Day: {RentalPricePerDay:C}, Available: {(IsAvailable ? "Yes" : "No")}");
        }

        // Method to calculate rental cost
        public virtual decimal CalculateRentalCost(int numberOfDays)
        {
            return RentalPricePerDay * numberOfDays;
        }
        // ToString() method override
        public override string ToString()
        {
            return $"{Make} {Model} ({Year})";
        }
    }
}

