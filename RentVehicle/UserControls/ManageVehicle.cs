using RentVehicle.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentVehicle.UserControllers
{
    public partial class ManageVehicle : UserControl
    {
        private VehicleManager vehicleManager;
        private string make;
        private string model;
        private int year;
        private decimal rentalPrice;
        private int vehicleId; // Assuming you need this for Update and Remove operations

        public ManageVehicle()
        {
            InitializeComponent();
            vehicleManager = new VehicleManager();

            button1.Click += AddVehicleButton_Click;
            button2.Click += UpdateVehicleButton_Click;
            button3.Click += RemoveVehicleButton_Click;
            button5.Click += ExitConsoleButton_Click;
        }
     
        private void AddVehicleButton_Click(object sender, EventArgs e)
        {
           
            vehicleManager.AddVehicle(new Vehicle(make, model, year, rentalPrice));
            MessageBox.Show("AddVehicle!");
        }

        private void UpdateVehicleButton_Click(object sender, EventArgs e)
        {
          
            vehicleManager.UpdateVehicle(vehicleId, make, model, year, rentalPrice);
            MessageBox.Show("UpdateVehicle!");
        }

       
        private void RemoveVehicleButton_Click(object sender, EventArgs e)
        {
         
             vehicleManager.RemoveVehicle(vehicleId);
            MessageBox.Show("Remove Vehicle!");
        }

        private void ExitConsoleButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
          

        }
    }

}

