using RentVehicle.Classes;
using RentVehicle.Forms;
using RentVehicle.UserControllers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RentVehicle
{
    public partial class Main : Form
    {
        NavigationControl navigationControl;
        NavigationButtons navigationButtons;

        Color btnDefaultColor = Color.FromKnownColor(KnownColor.ControlLight);
        Color btnSelectedColor = Color.FromKnownColor(KnownColor.ControlDark);

        private VehicleManager vehicleManager;

        public Main()
        {
            InitializeComponent();

            vehicleManager = new VehicleManager(); // VehicleManager burada ba?lat?l?yor

            InitializeNavigationControl();
            InitializeNavigationButtons();

            // Attach event handlers to buttons
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;
            button4.Click += Button4_Click;
            button5.Click += Button5_Click;

            var manageVehicleControl = new ManageVehicle(vehicleManager);
            var rentSpecificVehicleControl = new RentSpecificVehicle(vehicleManager);

            // UserControl'leri form üzerine ekleyin
            this.Controls.Add(manageVehicleControl);
            this.Controls.Add(rentSpecificVehicleControl);
        }

        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>()
            {
                new ManageVehicle(vehicleManager), new RentSpecificVehicle(vehicleManager), new SearchVehicle()
            };

            navigationControl = new NavigationControl(userControls, panel3);
            navigationControl.Display(3);
        }

        private void InitializeNavigationButtons()
        {
            List<Button> buttons = new List<Button>()
            { button1, button2 , button3 , button4 ,button5 };

            navigationButtons = new NavigationButtons(buttons, btnDefaultColor, btnSelectedColor);
            navigationButtons.Highlight(button1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
            navigationButtons.Highlight(button1);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            navigationButtons.Highlight(button2);
            navigationControl.Display(1);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            navigationButtons.Highlight(button3);
            navigationControl.Display(2);
           // MessageBox.Show("Button 3 clicked!");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            navigationButtons.Highlight(button4);
            MessageBox.Show("Button 4 clicked!");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            navigationButtons.Highlight(button5);
            Application.Exit();
          //  MessageBox.Show("Button 5 clicked!");
        }
    }
}
