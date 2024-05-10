namespace RentVehicle
{
    public partial class Form1 : Form
    {
        NavigationControl navigationControl;
        NavigationButtons navigationButtons;
        public Form1()
        {
            InitializeComponent();
            InitializeNavigationControl();
            InitializeNavigationButtons();

            Color btnDefaultColor=Color.FromKnownColor(KnownColor.ControlLight);
            Color btnSelectedColor=Color.FromKnownColor(KnownColor.ControlDark);

            // Attach event handlers to buttons
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;
            button4.Click += Button4_Click;
            button5.Click += Button5_Click;
        }

        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>()
            {new UserControl1(),new UserControl2(),new UserControl3()}; //button names
          
            navigationControl = new NavigationControl(userControls, panel2);
            navigationControl.Display(0);
        }








        private void InitializeNavigationButtons()
        {
            List<Button> buttons = new List<Button>()
            { button1, button2 , button3 , button4 ,};

            navigationButtons = new NavigationButtons(buttons, btnDefaultColor, btnSelectedColor);
            navigationButtons.Highlight(button1);
        }





        private void Button1_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);

            navigationButtons.Highlight(button1);


            // Implement functionality for button1 click
            MessageBox.Show("Button 1 clicked!");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            navigationButtons.Highlight(button2);


            navigationControl.Display(1);




            // Implement functionality for button2 click
            MessageBox.Show("Button 2 clicked!");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            navigationButtons.Highlight(button3);
            navigationControl.Display(2);




            // Implement functionality for button3 click
            MessageBox.Show("Button 3 clicked!");
        }

        private void Button4_Click(object sender, EventArgs e)
        {

            navigationButtons.Highlight(button4);
            // Implement functionality for button4 click
            MessageBox.Show("Button 4 clicked!");
        }

        private void Button5_Click(object sender, EventArgs e)
        {

            navigationButtons.Highlight(button5);
            // Implement functionality for button5 click
            MessageBox.Show("Button 5 clicked!");
        }
    }
}
