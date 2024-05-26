using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentVehicle.Classes
{
    public class Bike : Vehicle
    {
        // Additional attributes specific to bikes
        public int EngineCapacity { get; set; }
        public int TopSpeed { get; set; }
        public decimal Mileage { get; set; }

        // Constructor
        public Bike(string make, string model, int year, decimal rentalPricePerDay, int engineCapacity, int topSpeed, decimal mileage)
            : base(make, model, year, rentalPricePerDay,VehicleType.Bike)
        {
            EngineCapacity = engineCapacity;
            TopSpeed = topSpeed;
            Mileage = mileage;
        }

        // Override method to display details of the bike
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Engine Capacity: {EngineCapacity} cc, Top Speed: {TopSpeed} km/h, Mileage: {Mileage} km/l");
        }

        // Override method to calculate rental cost for bikes
        public override decimal CalculateRentalCost(int numberOfDays)
        {
            // Consider additional charges for bikes
            decimal rentalCost = base.CalculateRentalCost(numberOfDays);
            // Add additional charge for mileage
            if (Mileage < 50)
            {
                rentalCost -= 5; // Discount for bikes with low mileage
            }
            return rentalCost;
        }
    }
}
