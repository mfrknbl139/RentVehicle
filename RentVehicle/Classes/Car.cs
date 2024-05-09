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

        // Constructor
        public Car(string make, string model, int year, decimal rentalPricePerDay, int seats, string fuelType, decimal trunkCapacity)
            : base(make, model, year, rentalPricePerDay)
        {
            Seats = seats;
            FuelType = fuelType;
            TrunkCapacity = trunkCapacity;
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
            return base.CalculateRentalCost(numberOfDays);
        }
    }
}
