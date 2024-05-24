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

        // Method to add a new vehicle to the system
        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
            Console.WriteLine("Vehicle added successfully.");
        }

        // Method to update details of an existing vehicle
        public void UpdateVehicle(int vehicleId, string make, string model, int year, decimal? rentalPricePerDay)
        {
            Vehicle vehicleToUpdate = vehicles.FirstOrDefault(v => v.Id == vehicleId);
            if (vehicleToUpdate != null)
            {
                vehicleToUpdate.Make = make;
                vehicleToUpdate.Model = model;
                vehicleToUpdate.Year = year;
                vehicleToUpdate.RentalPricePerDay = rentalPricePerDay ?? 0; // Provide a default value if rentalPricePerDay is null
                Console.WriteLine("Vehicle details updated successfully.");
            }
            else
            {
                Console.WriteLine("Vehicle not found.");
            }
        }

        // Method to remove a vehicle from the system
        public void RemoveVehicle(int vehicleId)
        {
            Vehicle vehicleToRemove = vehicles.FirstOrDefault(v => v.Id == vehicleId);
            if (vehicleToRemove != null)
            {
                vehicles.Remove(vehicleToRemove);
                Console.WriteLine("Vehicle removed successfully.");
            }
            else
            {
                Console.WriteLine("Vehicle not found.");
            }
        }

        // Method to display details of all vehicles in the system
        public void DisplayAllVehicles()
        {
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.DisplayDetails();
            }
        }

        // Method to check if a vehicle is available for rental
        public bool IsVehicleAvailable(int vehicleId)
        {
            Vehicle vehicle = vehicles.FirstOrDefault(v => v.Id == vehicleId);
            return vehicle != null && vehicle.IsAvailable;
        }

        // Method to book a vehicle for a specific duration
        public void BookVehicle(int vehicleId, int numberOfDays)
        {
            Vehicle vehicle = vehicles.FirstOrDefault(v => v.Id == vehicleId);
            if (vehicle != null)
            {
                if (vehicle.IsAvailable)
                {
                    // Mark the vehicle as unavailable
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

        // Method to calculate rental cost for a booked vehicle
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
