using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace RentVehicle.Classes
{
    public class UserManager
    {
        private List<User> users;
        public UserManager() { users = new List<User>(); }

        public void DisplayDetails()
        {
            //   Console.WriteLine($"User ID: {UserId}, Name: {Name}, Email: {Email}");
            // Display other user details if necessary
        }
        public void AddUser(User user)
        {
            users.Add(user);
            Console.WriteLine("User added.");
        }
        public void DeleteUser(int userId)
        {
            User userToRemove = users.FirstOrDefault(v => v.UserId == userId);
            if (userToRemove != null)
            {
                {
                    users.Remove(userToRemove);
                    Console.WriteLine("User Deleted.");
                }

            }
        }
        public List<User> GetUsers() { return users; }
    }
}
