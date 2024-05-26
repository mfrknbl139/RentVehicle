using RentVehicle.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentVehicle.Classes
{
    public class Car : Vehicle
    {
        // Additional attributes specific to cars
        public int Seats { get; set; }
        public string FuelType { get; set; }
        public decimal TrunkCapacity { get; set; }
        public bool HasAirConditioning { get; set; }

        // Constructor
        public Car(string make, string model, int year, decimal rentalPricePerDay, int seats, string fuelType, decimal trunkCapacity, bool hasAirConditioning)
            : base(make, model, year, rentalPricePerDay,VehicleType.Car)
        {
            Seats = seats;
            FuelType = fuelType;
            TrunkCapacity = trunkCapacity;
            HasAirConditioning = hasAirConditioning;
        }

        // Override method to display details of the car
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Seats: {Seats}, Fuel Type: {FuelType}, Trunk Capacity: {TrunkCapacity} liters");
        }

        // Override method to calculate rental cost for cars
        public override decimal CalculateRentalCost(int numberOfDays)
        {
            // Consider additional charges for cars
            decimal rentalCost = base.CalculateRentalCost(numberOfDays);
            // Add additional charge for air conditioning
            if (HasAirConditioning)
            {
                rentalCost += 10; // Additional charge for air conditioning
            }
            return rentalCost;
        }
    }
}
