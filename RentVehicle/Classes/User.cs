using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentVehicle.Classes
{
    public class User
    {
        // Properties
        public int UserId { get; private set; }
        public string Name { get; set; }
        public string Email { get; set; }
        // Add more properties as needed

        // Static counter for assigning unique IDs to users
        private static int nextUserId = 1;

        // Constructor
        public User(string name, string email)
        {
            UserId = nextUserId++; // Assign a unique ID to each user
            Name = name;
            Email = email;
            // Initialize other properties if necessary
        }
        public override string ToString()
        {
            return $"{Name} ({Email})";
        }
    }
}
