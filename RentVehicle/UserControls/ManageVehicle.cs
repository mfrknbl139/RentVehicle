using RentVehicle.Classes;
using System;
using System.Windows.Forms;

namespace RentVehicle.UserControllers
{
    public partial class ManageVehicle : UserControl
    {
        private VehicleManager vehicleManager;
        private int selectedVehicleId;

        public ManageVehicle(VehicleManager vehicleManager)
        {
            InitializeComponent();
            this.vehicleManager = vehicleManager;

            button1.Click += AddVehicleButton_Click;
            button2.Click += UpdateVehicleButton_Click;
            button3.Click += RemoveVehicleButton_Click;
            button5.Click += ExitConsoleButton_Click;

            LoadVehicles();
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
                textBoxMake.Text = selectedVehicle.Make;
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

            var newVehicle = new Vehicle(make, model, year, rentalPrice);
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
            Application.Exit();
        }

        private void labelRentalPrice_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelMake_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
