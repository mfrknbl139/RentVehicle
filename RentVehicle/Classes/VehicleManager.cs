using System;
using System.Collections.Generic;
using System.Linq;

namespace RentVehicle.Classes
{
    public class VehicleManager
    {
        private List<Vehicle> vehicles;

        public VehicleManager()
        {
            vehicles = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
            Console.WriteLine("Vehicle added successfully.");
        }

        public void UpdateVehicle(int vehicleId, string make, string model, int year, decimal? rentalPricePerDay)
        {
            Vehicle vehicleToUpdate = vehicles.FirstOrDefault(v => v.Id == vehicleId);
            if (vehicleToUpdate != null)
            {
                vehicleToUpdate.UserName = make;
                vehicleToUpdate.Model = model;
                vehicleToUpdate.Year = year;
                vehicleToUpdate.RentalPricePerDay = rentalPricePerDay ?? 0; // Provide a default value if rentalPricePerDay is null
                Console.WriteLine("Vehicle details updated successfully.");
            }
        }
        public void RemoveVehicle(int vehicleId)
        {
            Vehicle vehicleToRemove = vehicles.FirstOrDefault(v => v.Id == vehicleId);
            if (vehicleToRemove != null)
            {
                vehicles.Remove(vehicleToRemove);
                Console.WriteLine("Vehicle removed successfully.");
            }
        }
        public bool IsVehicleAvailable(int vehicleId)
        {
            Vehicle vehicle = vehicles.FirstOrDefault(v => v.Id == vehicleId);
            return vehicle != null && vehicle.IsAvailable;
        }
        public void BookVehicle(int vehicleId, int numberOfDays)
        {
            Vehicle vehicle = vehicles.FirstOrDefault(v => v.Id == vehicleId);
            if (vehicle != null)
            {
                if (vehicle.IsAvailable)
                {
                    vehicle.IsAvailable = false;
                    Console.WriteLine($"Vehicle {vehicleId} booked successfully for {numberOfDays} days.");
                }
                else
                {
                    Console.WriteLine("Vehicle is not available for booking.");
                }
            }
            else
            {
                Console.WriteLine("Vehicle not found.");
            }
        }
        public decimal CalculateRentalCost(int vehicleId, int numberOfDays)
        {
            Vehicle vehicle = vehicles.FirstOrDefault(v => v.Id == vehicleId);
            if (vehicle != null)
            {
                if (!vehicle.IsAvailable)
                {
                    // Calculate rental cost
                    decimal rentalCost = vehicle.CalculateRentalCost(numberOfDays);
                    return rentalCost;
                }
                else
                {
                    Console.WriteLine("Vehicle is not booked.");
                }
            }
            else
            {
                Console.WriteLine("Vehicle not found.");
            }
            return 0; // Return 0 if rental cost cannot be calculated
        }

        // Method to get the list of all vehicles
        public List<Vehicle> GetVehicles()
        {
            return vehicles;
        }
    }
}
