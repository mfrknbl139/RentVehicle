﻿using RentVehicle.Classes;
using RentVehicle.Forms;
using System;
using System.Windows.Forms;
using static RentVehicle.Classes.Vehicle;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RentVehicle.UserControllers
{
    public partial class UC_ManageVehicle : UserControl
    {
        private VehicleManager vehicleManager;
        private int selectedVehicleId;

        public UC_ManageVehicle(VehicleManager vehicleManager)
        {
            InitializeComponent();
            this.vehicleManager = vehicleManager;

            button1.Click += AddVehicleButton_Click;
            button2.Click += UpdateVehicleButton_Click;
            button3.Click += RemoveVehicleButton_Click;
            button5.Click += ExitConsoleButton_Click;

            LoadVehicles();
            var vehicleTypes = Enum.GetValues(typeof(VehicleType)).Cast<VehicleType>().ToList();

            // ComboBox'a veri kaynağını ata
            VehicleType.DataSource = vehicleTypes;
        }
        private void LoadVehicles()
        {
            listBox1.Items.Clear();
            foreach (var vehicle in vehicleManager.GetVehicles())
            {
                listBox1.Items.Add(vehicle);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedVehicle = listBox1.SelectedItem as Vehicle;
            if (selectedVehicle != null)
            {
                selectedVehicleId = selectedVehicle.Id;
                textBoxMake.Text = selectedVehicle.UserName;
                textBoxModel.Text = selectedVehicle.Model;
                textBoxYear.Text = selectedVehicle.Year.ToString();
                textBoxRentalPrice.Text = selectedVehicle.RentalPricePerDay.ToString();
            }
        }
        private void AddVehicleButton_Click(object? sender, EventArgs e)
        {
            var make = textBoxMake.Text;
            var model = textBoxModel.Text;
            var year = int.Parse(textBoxYear.Text);
            var rentalPrice = decimal.Parse(textBoxRentalPrice.Text);
            var vehicleType = (Vehicle.VehicleType)Enum.Parse(typeof(Vehicle.VehicleType), VehicleType.SelectedItem.ToString());

            var newVehicle = new Vehicle(make, model, year, rentalPrice, vehicleType);
            vehicleManager.AddVehicle(newVehicle);

            listBox1.Items.Add(newVehicle.ToString());

            LoadVehicles();
            MessageBox.Show("Vehicle added!");

        }
        private void UpdateVehicleButton_Click(object? sender, EventArgs e)
        {
            var make = textBoxMake.Text;
            var model = textBoxModel.Text;
            var year = int.Parse(textBoxYear.Text);
            var rentalPrice = decimal.Parse(textBoxRentalPrice.Text);

            vehicleManager.UpdateVehicle(selectedVehicleId, make, model, year, rentalPrice);

            LoadVehicles();
            MessageBox.Show("Vehicle updated!");
        }

        private void RemoveVehicleButton_Click(object? sender, EventArgs e)
        {
            vehicleManager.RemoveVehicle(selectedVehicleId);
            LoadVehicles();
            MessageBox.Show("Vehicle removed!");
        }
        private void ExitConsoleButton_Click(object? sender, EventArgs e)
        {
            //Application.Exit();
        }
        private void Form_Load(object sender, EventArgs e)
        {
            // VehicleType enumundaki değerleri diziye al
            var vehicleTypes = Enum.GetValues(typeof(VehicleType)).Cast<VehicleType>().ToList();

            // ComboBox'a veri kaynağını ata
            
            VehicleType.DataSource = vehicleTypes;
        }
    }
}
