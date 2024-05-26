using RentVehicle.Classes;
using System;
using System.Windows.Forms;

namespace RentVehicle.UserControllers
{
    public partial class RentSpecificVehicle : UserControl
    {
        private VehicleManager vehicleManager;
        private int selectedVehicleId;

        // VehicleManager parametresini alacak şekilde yapıcıyı tanımlayın
        public RentSpecificVehicle(VehicleManager manager)
        {
            InitializeComponent();
            vehicleManager = manager;
            LoadVehicles(); // Araçları yükle ve listele
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
            button1.Click += CheckAvailabilityButton_Click;
            button2.Click += BookVehicleButton_Click;
            button3.Click += CalculateCostButton_Click;
            button4.Click += ListAddedVehiclesButton_Click; // button4 olay işleyicisini ekle
        }

        private void LoadVehicles()
        {
            listBox1.Items.Clear();
            foreach (var vehicle in vehicleManager.GetVehicles())
            {
                listBox1.Items.Add(vehicle.Make + " " + vehicle.Model); // Görüntülenecek bilgileri özelleştirin
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                var selectedVehicle = vehicleManager.GetVehicles()[listBox1.SelectedIndex];
                selectedVehicleId = selectedVehicle.Id;
                // Burada gerekli bilgileri başka yerlere gösterebilirsiniz.
            }
        }

        private void CheckAvailabilityButton_Click(object sender, EventArgs e)
        {
            if (vehicleManager.IsVehicleAvailable(selectedVehicleId))
            {
                MessageBox.Show("Vehicle is available for booking.");
            }
            else
            {
                MessageBox.Show("Vehicle is not available.");
            }
        }

        private void BookVehicleButton_Click(object sender, EventArgs e)
        {
            int numberOfDays = 3; // Örnek olarak sabit bir değer verdim
            vehicleManager.BookVehicle(selectedVehicleId, numberOfDays);
            LoadVehicles(); // Araçları yeniden yükleyerek güncellenmiş durumu gösterebilirsiniz
            MessageBox.Show("Vehicle booked!");
        }

        private void CalculateCostButton_Click(object sender, EventArgs e)
        {
            int numberOfDays = 3; // Örnek olarak sabit bir değer verdim
            decimal cost = vehicleManager.CalculateRentalCost(selectedVehicleId, numberOfDays);
            MessageBox.Show($"Total cost for {numberOfDays} days is ${cost}");
        }

        // button4 için olay işleyicisi
        private void ListAddedVehiclesButton_Click(object sender, EventArgs e)
        {
            // ManageVehicle'da eklenen araçları listele
            listBox1.Items.Clear();
            foreach (var vehicle in vehicleManager.GetVehicles())
            {
                listBox1.Items.Add(vehicle.Make + " " + vehicle.Model);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
